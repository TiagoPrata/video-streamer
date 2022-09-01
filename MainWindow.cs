using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Accord.Video.FFMPEG;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebcamApp
{
    public partial class MainWindow : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private VideoFileWriter fileWriter;
        private bool recording = false;
        private DateTime? _firstFrameTime;

        private bool isProcessing;

        private Thread thread_file_stream;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                deviceComboBox.Items.Add(device.Name);
            }

            deviceComboBox.SelectedIndex = 0;
            videoResolutionComboBox.SelectedIndex = 0;
            videoFrameRateComboBox.SelectedIndex = 2;
            FinalFrame = new VideoCaptureDevice();

        }

        private void SetCameraSettings()
        {
            
        }

        public void AppendTextBox(string value)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                    return;
                }
                txtResponse.Text += value;

            } catch (Exception e)
            {

            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (recording)
                {
                    using (var bitmap = (Bitmap) eventArgs.Frame.Clone())
                    {
                        if (_firstFrameTime != null)
                        {
                            fileWriter.WriteVideoFrame(bitmap,
                                DateTime.Now - _firstFrameTime.Value);
                            
                        }
                        else
                        {
                            fileWriter.WriteVideoFrame(bitmap);
                            _firstFrameTime = DateTime.Now;
                        }

                    }
                }

                using (var bitmap = (Bitmap) eventArgs.Frame.Clone())
                {
                    cameraOriginal.Image = (Bitmap)bitmap.Clone();
                    AppendTextBox(Environment.NewLine + sendVideoFrames(bitmap));
                    //System.Console.WriteLine(sendVideoFrames(bitmap));
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error on FinalFrame_NewFrame:\n" + e.Message, "Error",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //StopCamera();
                System.Console.WriteLine(e.Message);
            }
        }

        private string GetDetectionResult(Bitmap bmp)
        {
            string response_str = String.Empty;

            try
            {
                //GET DATA
                

                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(txtSendTo.Text);
                Request.ContentType = "application/json";
                Request.Accept = "application/json";
                Request.KeepAlive = true;
                Request.Method = txtMethod.Text;

                byte[] arr;
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                }

                var img_base64 = Convert.ToBase64String(arr);
                string body_content = txtBodyContent.Text;
                body_content = body_content.Replace("$frame$", img_base64);
                string json = body_content;
                Request.ContentLength = json.Length;

                using (var stream = Request.GetRequestStream())
                {
                    stream.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);
                }

                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                if (Response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream stream = Response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        string strResponse = reader.ReadToEnd();
                        response_str = strResponse.Replace("\\", "");
                    }
                }
            }
            catch (Exception ex) {  }

            return response_str;
        }


        private string sendVideoFrames(Bitmap bmp)
        {
            isProcessing = true;

            string detections = GetDetectionResult(bmp);

            isProcessing = false;

            //return img;
            return detections;
        }

        private void StartCamera()
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[deviceComboBox.SelectedIndex].MonikerString);
            FinalFrame.VideoResolution = SelectResolution(FinalFrame);
            FinalFrame.SnapshotResolution = SelectResolution(FinalFrame);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            
            FinalFrame.Start();
        }

        private VideoCapabilities SelectResolution(VideoCaptureDevice device)
        {
            foreach (var cap in device.VideoCapabilities)
            {
                if (cap.FrameSize.Height == getHeight() && cap.FrameSize.Width == getWidth())
                {
                    return cap;
                }
            }

            return device.VideoCapabilities.Last();
        }

        private void StopCamera()
        {
            if (FinalFrame.IsRunning)
            {
                FinalFrame.Stop();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // StopCamera();
            thread_file_stream?.Abort();
            try
            {
                Environment.Exit(0);
            } catch (Exception)
            {

            }
        }

        private void startRecordingButton_Click(object sender, EventArgs e)
        {
            //int width = getWidth();
            //int height = getHeight();
            int width = FinalFrame.VideoResolution.FrameSize.Width;
            int height = FinalFrame.VideoResolution.FrameSize.Height;
            int frameRate = getVideoFrameRate();
            var dialog = new SaveFileDialog();
            dialog.FileName = "video";
            dialog.DefaultExt = ".avi";
            dialog.AddExtension = true;
            var dialogResult = dialog.ShowDialog();
            if (dialogResult.Equals(true))
            {
                return;
            }
            fileWriter = new VideoFileWriter();
            fileWriter.Open(dialog.FileName, width, height, frameRate);
            recording = true;
            recordingActiveIconPictureBox.Visible = true;
            recordingTimeLabel.Visible = true;
        }

        private void stopRecordingButton_Click(object sender, EventArgs e)
        {
            recording = false;
            recordingActiveIconPictureBox.Visible = false;
            recordingTimeLabel.Visible = false;
            _firstFrameTime = null;
            fileWriter.Close();
            fileWriter.Dispose();
        }

        private int getWidth()
        {
            int width = 0;
            switch (videoResolutionComboBox.SelectedIndex)
            {
                case 0:
                    width = 1280;
                    break;
                case 1:
                    width = 320;
                    break;
                case 2:
                    width = 320;
                    break;
                case 3:
                    width = 352;
                    break;
                case 4:
                    width = 424;
                    break;
                case 5:
                    width = 640;
                    break;
                case 6:
                    width = 640;
                    break;
                case 7:
                    width = 848;
                    break;
                case 8:
                    width = 960;
                    break;
            }

            return width;
        }

        private int getHeight()
        {
            int height = 0;
            switch (videoResolutionComboBox.SelectedIndex)
            {
                case 0:
                    height = 720;
                    break;
                case 1:
                    height = 180;
                    break;
                case 2:
                    height = 240;
                    break;
                case 3:
                    height = 288;
                    break;
                case 4:
                    height = 240;
                    break;
                case 5:
                    height = 360;
                    break;
                case 6:
                    height = 480;
                    break;
                case 7:
                    height = 480;
                    break;
                case 8:
                    height = 540;
                    break;
            }

            return height;
        }

        private int getVideoFrameRate()
        {
            int frameRate = 0;
            switch (videoFrameRateComboBox.SelectedIndex)
            {
                case 0:
                    frameRate = 10;
                    break;
                case 1:
                    frameRate = 15;
                    break;
                case 2:
                    frameRate = 20;
                    break;
                case 3:
                    frameRate = 25;
                    break;
                case 4:
                    frameRate = 30;
                    break;
            }

            return frameRate;
        }

        private void refreshCameraSettingsButton_Click(object sender, EventArgs e)
        {
            StopCamera();
            StartCamera();
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            txtResponse.SelectionStart = txtResponse.TextLength;
            txtResponse.ScrollToCaret();
        }

        public void SendVideoStream()
        {
            using (var vFReader = new VideoFileReader())
            {
                do
                {
                    vFReader.Open(txtVideoFile.Text);
                    for (int i = 0; i < vFReader.FrameCount; i++)
                    {
                        Bitmap bmpBaseOriginal = vFReader.ReadVideoFrame();
                        using (var bitmap = (Bitmap)bmpBaseOriginal.Clone())
                        {
                            cameraOriginal.Image = (Bitmap)bitmap.Clone();
                            Bitmap resized = new Bitmap(bitmap, new Size(Decimal.ToInt32(nmbWidth.Value), Decimal.ToInt32(nmbHeight.Value)));
                            AppendTextBox(Environment.NewLine + Environment.NewLine + sendVideoFrames(resized));
                            //System.Console.WriteLine(sendVideoFrames(bitmap));
                        }
                        System.Threading.Thread.Sleep(Decimal.ToInt32(1000 / nmrFps.Value));
                    }
                    vFReader.Close();

                } while (chkLoop.Checked);
            }
        }

        private void btnSelectVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Video files (*.mp4, *.avi)|*.mp4;*.avi";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                txtVideoFile.Text = selectedFileName;
            }
        }

        private void EnableVideoSource()
        {
            if (radVideo.Checked)
            {
                groupCamera.Enabled = false;
                groupVideoFile.Enabled = true;
            }
            else
            {
                groupCamera.Enabled = true;
                groupVideoFile.Enabled = false;
            }
        }

        private void radVideo_CheckedChanged(object sender, EventArgs e)
        {
            EnableVideoSource();
        }

        private void radCamera_CheckedChanged(object sender, EventArgs e)
        {
            EnableVideoSource();
        }

        private void btnStartStreaming_Click(object sender, EventArgs e)
        {
            if (btnStartStreaming.Text == "&Start Streaming")
            {
                if (radVideo.Checked)
                {
                    thread_file_stream = new Thread(SendVideoStream);
                    thread_file_stream.Start();
                }
                else
                {
                    SetCameraSettings();
                    StartCamera();
                }
                btnStartStreaming.Text = "STOP";
            }
            else
            {
                // restart application
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                this.Close();
            }
            
        }
    }
}
