namespace WebcamApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cameraSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.cameraOriginal = new System.Windows.Forms.PictureBox();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblBodyContentNote = new System.Windows.Forms.Label();
            this.lblBodyContent = new System.Windows.Forms.Label();
            this.txtBodyContent = new System.Windows.Forms.TextBox();
            this.txtSendTo = new System.Windows.Forms.TextBox();
            this.lblSendTo = new System.Windows.Forms.Label();
            this.videoFrameRateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snapshotFormatLabel = new System.Windows.Forms.Label();
            this.videoResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.recordingActiveIconPictureBox = new System.Windows.Forms.PictureBox();
            this.recordingTimeLabel = new System.Windows.Forms.Label();
            this.refreshCameraSettingsButton = new System.Windows.Forms.Button();
            this.stopRecordingButton = new System.Windows.Forms.Button();
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVideo = new System.Windows.Forms.RadioButton();
            this.lblOR = new System.Windows.Forms.Label();
            this.radCamera = new System.Windows.Forms.RadioButton();
            this.groupCamera = new System.Windows.Forms.GroupBox();
            this.groupVideoFile = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nmbHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nmbWidth = new System.Windows.Forms.NumericUpDown();
            this.lblFps = new System.Windows.Forms.Label();
            this.nmrFps = new System.Windows.Forms.NumericUpDown();
            this.btnSelectVideo = new System.Windows.Forms.Button();
            this.txtVideoFile = new System.Windows.Forms.TextBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.btnStartStreaming = new System.Windows.Forms.Button();
            this.btnClearResponse = new System.Windows.Forms.Button();
            this.cameraOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.cameraOutput = new System.Windows.Forms.PictureBox();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.radBase64 = new System.Windows.Forms.RadioButton();
            this.chkPrintResponse = new System.Windows.Forms.CheckBox();
            this.cameraSourceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOriginal)).BeginInit();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupCamera.SuspendLayout();
            this.groupVideoFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).BeginInit();
            this.cameraOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraSourceGroupBox
            // 
            this.cameraSourceGroupBox.Controls.Add(this.cameraOriginal);
            this.cameraSourceGroupBox.Location = new System.Drawing.Point(583, 12);
            this.cameraSourceGroupBox.Name = "cameraSourceGroupBox";
            this.cameraSourceGroupBox.Size = new System.Drawing.Size(418, 402);
            this.cameraSourceGroupBox.TabIndex = 0;
            this.cameraSourceGroupBox.TabStop = false;
            this.cameraSourceGroupBox.Text = "Video Source";
            // 
            // cameraOriginal
            // 
            this.cameraOriginal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cameraOriginal.Location = new System.Drawing.Point(6, 58);
            this.cameraOriginal.Name = "cameraOriginal";
            this.cameraOriginal.Size = new System.Drawing.Size(400, 300);
            this.cameraOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraOriginal.TabIndex = 0;
            this.cameraOriginal.TabStop = false;
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.txtMethod);
            this.configurationGroupBox.Controls.Add(this.lblMethod);
            this.configurationGroupBox.Controls.Add(this.lblBodyContentNote);
            this.configurationGroupBox.Controls.Add(this.lblBodyContent);
            this.configurationGroupBox.Controls.Add(this.txtBodyContent);
            this.configurationGroupBox.Controls.Add(this.txtSendTo);
            this.configurationGroupBox.Controls.Add(this.lblSendTo);
            this.configurationGroupBox.Location = new System.Drawing.Point(268, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(309, 273);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Destination";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(9, 76);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(153, 20);
            this.txtMethod.TabIndex = 15;
            this.txtMethod.Text = "POST";
            this.txtMethod.TextChanged += new System.EventHandler(this.txtMethod_TextChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(6, 60);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 11;
            this.lblMethod.Text = "Method";
            // 
            // lblBodyContentNote
            // 
            this.lblBodyContentNote.AutoSize = true;
            this.lblBodyContentNote.Location = new System.Drawing.Point(52, 198);
            this.lblBodyContentNote.Name = "lblBodyContentNote";
            this.lblBodyContentNote.Size = new System.Drawing.Size(251, 13);
            this.lblBodyContentNote.TabIndex = 10;
            this.lblBodyContentNote.Text = "(use the keyword $frame$ to be replaced in runtime)";
            // 
            // lblBodyContent
            // 
            this.lblBodyContent.AutoSize = true;
            this.lblBodyContent.Location = new System.Drawing.Point(6, 104);
            this.lblBodyContent.Name = "lblBodyContent";
            this.lblBodyContent.Size = new System.Drawing.Size(70, 13);
            this.lblBodyContent.TabIndex = 9;
            this.lblBodyContent.Text = "Body content";
            // 
            // txtBodyContent
            // 
            this.txtBodyContent.Location = new System.Drawing.Point(9, 120);
            this.txtBodyContent.Multiline = true;
            this.txtBodyContent.Name = "txtBodyContent";
            this.txtBodyContent.Size = new System.Drawing.Size(294, 75);
            this.txtBodyContent.TabIndex = 16;
            this.txtBodyContent.Text = "{\"img_base64str\": \"$frame$\"}";
            this.txtBodyContent.TextChanged += new System.EventHandler(this.txtBodyContent_TextChanged);
            // 
            // txtSendTo
            // 
            this.txtSendTo.Location = new System.Drawing.Point(9, 34);
            this.txtSendTo.Name = "txtSendTo";
            this.txtSendTo.Size = new System.Drawing.Size(294, 20);
            this.txtSendTo.TabIndex = 14;
            this.txtSendTo.Text = "http://localhost:5000/";
            this.txtSendTo.TextChanged += new System.EventHandler(this.txtSendTo_TextChanged);
            // 
            // lblSendTo
            // 
            this.lblSendTo.AutoSize = true;
            this.lblSendTo.Location = new System.Drawing.Point(6, 18);
            this.lblSendTo.Name = "lblSendTo";
            this.lblSendTo.Size = new System.Drawing.Size(44, 13);
            this.lblSendTo.TabIndex = 7;
            this.lblSendTo.Text = "Send to";
            // 
            // videoFrameRateComboBox
            // 
            this.videoFrameRateComboBox.FormattingEnabled = true;
            this.videoFrameRateComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.videoFrameRateComboBox.Location = new System.Drawing.Point(6, 139);
            this.videoFrameRateComboBox.Name = "videoFrameRateComboBox";
            this.videoFrameRateComboBox.Size = new System.Drawing.Size(213, 21);
            this.videoFrameRateComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video Frame Rate";
            // 
            // snapshotFormatLabel
            // 
            this.snapshotFormatLabel.AutoSize = true;
            this.snapshotFormatLabel.Location = new System.Drawing.Point(3, 58);
            this.snapshotFormatLabel.Name = "snapshotFormatLabel";
            this.snapshotFormatLabel.Size = new System.Drawing.Size(87, 13);
            this.snapshotFormatLabel.TabIndex = 3;
            this.snapshotFormatLabel.Text = "Snapshot Format";
            // 
            // videoResolutionComboBox
            // 
            this.videoResolutionComboBox.FormattingEnabled = true;
            this.videoResolutionComboBox.Items.AddRange(new object[] {
            "1280x720",
            "320x180",
            "320x240",
            "352x288",
            "424x240",
            "640x360",
            "640x480",
            "848x480",
            "960x540"});
            this.videoResolutionComboBox.Location = new System.Drawing.Point(6, 99);
            this.videoResolutionComboBox.Name = "videoResolutionComboBox";
            this.videoResolutionComboBox.Size = new System.Drawing.Size(213, 21);
            this.videoResolutionComboBox.TabIndex = 9;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(3, 83);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.ResolutionLabel.TabIndex = 2;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(6, 34);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(213, 21);
            this.deviceComboBox.TabIndex = 7;
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(3, 18);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(41, 13);
            this.deviceLabel.TabIndex = 0;
            this.deviceLabel.Text = "Device";
            // 
            // recordingActiveIconPictureBox
            // 
            this.recordingActiveIconPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recordingActiveIconPictureBox.BackgroundImage")));
            this.recordingActiveIconPictureBox.Location = new System.Drawing.Point(6, 169);
            this.recordingActiveIconPictureBox.Name = "recordingActiveIconPictureBox";
            this.recordingActiveIconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.recordingActiveIconPictureBox.TabIndex = 9;
            this.recordingActiveIconPictureBox.TabStop = false;
            this.recordingActiveIconPictureBox.Visible = false;
            // 
            // recordingTimeLabel
            // 
            this.recordingTimeLabel.AutoSize = true;
            this.recordingTimeLabel.Location = new System.Drawing.Point(32, 173);
            this.recordingTimeLabel.Name = "recordingTimeLabel";
            this.recordingTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.recordingTimeLabel.TabIndex = 8;
            this.recordingTimeLabel.Text = "Recording";
            this.recordingTimeLabel.Visible = false;
            // 
            // refreshCameraSettingsButton
            // 
            this.refreshCameraSettingsButton.Location = new System.Drawing.Point(6, 224);
            this.refreshCameraSettingsButton.Name = "refreshCameraSettingsButton";
            this.refreshCameraSettingsButton.Size = new System.Drawing.Size(213, 23);
            this.refreshCameraSettingsButton.TabIndex = 13;
            this.refreshCameraSettingsButton.Text = "Refresh camera settings";
            this.refreshCameraSettingsButton.UseVisualStyleBackColor = true;
            this.refreshCameraSettingsButton.Click += new System.EventHandler(this.refreshCameraSettingsButton_Click);
            // 
            // stopRecordingButton
            // 
            this.stopRecordingButton.Location = new System.Drawing.Point(120, 195);
            this.stopRecordingButton.Name = "stopRecordingButton";
            this.stopRecordingButton.Size = new System.Drawing.Size(103, 23);
            this.stopRecordingButton.TabIndex = 12;
            this.stopRecordingButton.Text = "Stop Recording";
            this.stopRecordingButton.UseVisualStyleBackColor = true;
            this.stopRecordingButton.Click += new System.EventHandler(this.stopRecordingButton_Click);
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.Location = new System.Drawing.Point(6, 195);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(108, 23);
            this.startRecordingButton.TabIndex = 11;
            this.startRecordingButton.Text = "Start Recording";
            this.startRecordingButton.UseVisualStyleBackColor = true;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.chkPrintResponse);
            this.controlsGroupBox.Controls.Add(this.btnClearResponse);
            this.controlsGroupBox.Controls.Add(this.txtResponse);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 420);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(1413, 255);
            this.controlsGroupBox.TabIndex = 2;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(9, 41);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(1392, 179);
            this.txtResponse.TabIndex = 17;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVideo);
            this.groupBox1.Controls.Add(this.lblOR);
            this.groupBox1.Controls.Add(this.radCamera);
            this.groupBox1.Controls.Add(this.groupCamera);
            this.groupBox1.Controls.Add(this.groupVideoFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Configuration";
            // 
            // radVideo
            // 
            this.radVideo.AutoSize = true;
            this.radVideo.Checked = true;
            this.radVideo.Location = new System.Drawing.Point(12, 14);
            this.radVideo.Name = "radVideo";
            this.radVideo.Size = new System.Drawing.Size(68, 17);
            this.radVideo.TabIndex = 12;
            this.radVideo.TabStop = true;
            this.radVideo.Text = "Video file";
            this.radVideo.UseVisualStyleBackColor = true;
            this.radVideo.CheckedChanged += new System.EventHandler(this.radVideo_CheckedChanged);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(133, 123);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(25, 13);
            this.lblOR.TabIndex = 10;
            this.lblOR.Text = "OR";
            // 
            // radCamera
            // 
            this.radCamera.AutoSize = true;
            this.radCamera.Location = new System.Drawing.Point(12, 133);
            this.radCamera.Name = "radCamera";
            this.radCamera.Size = new System.Drawing.Size(61, 17);
            this.radCamera.TabIndex = 13;
            this.radCamera.TabStop = true;
            this.radCamera.Text = "Camera";
            this.radCamera.UseVisualStyleBackColor = true;
            this.radCamera.CheckedChanged += new System.EventHandler(this.radCamera_CheckedChanged);
            // 
            // groupCamera
            // 
            this.groupCamera.Controls.Add(this.deviceComboBox);
            this.groupCamera.Controls.Add(this.recordingActiveIconPictureBox);
            this.groupCamera.Controls.Add(this.label1);
            this.groupCamera.Controls.Add(this.startRecordingButton);
            this.groupCamera.Controls.Add(this.recordingTimeLabel);
            this.groupCamera.Controls.Add(this.stopRecordingButton);
            this.groupCamera.Controls.Add(this.deviceLabel);
            this.groupCamera.Controls.Add(this.snapshotFormatLabel);
            this.groupCamera.Controls.Add(this.ResolutionLabel);
            this.groupCamera.Controls.Add(this.videoFrameRateComboBox);
            this.groupCamera.Controls.Add(this.videoResolutionComboBox);
            this.groupCamera.Controls.Add(this.refreshCameraSettingsButton);
            this.groupCamera.Enabled = false;
            this.groupCamera.Location = new System.Drawing.Point(6, 137);
            this.groupCamera.Name = "groupCamera";
            this.groupCamera.Size = new System.Drawing.Size(233, 254);
            this.groupCamera.TabIndex = 11;
            this.groupCamera.TabStop = false;
            this.groupCamera.Text = "Camera";
            // 
            // groupVideoFile
            // 
            this.groupVideoFile.Controls.Add(this.lblHeight);
            this.groupVideoFile.Controls.Add(this.nmbHeight);
            this.groupVideoFile.Controls.Add(this.lblWidth);
            this.groupVideoFile.Controls.Add(this.nmbWidth);
            this.groupVideoFile.Controls.Add(this.lblFps);
            this.groupVideoFile.Controls.Add(this.nmrFps);
            this.groupVideoFile.Controls.Add(this.btnSelectVideo);
            this.groupVideoFile.Controls.Add(this.txtVideoFile);
            this.groupVideoFile.Controls.Add(this.chkLoop);
            this.groupVideoFile.Location = new System.Drawing.Point(6, 18);
            this.groupVideoFile.Name = "groupVideoFile";
            this.groupVideoFile.Size = new System.Drawing.Size(233, 97);
            this.groupVideoFile.TabIndex = 1;
            this.groupVideoFile.TabStop = false;
            this.groupVideoFile.Text = "Video File";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(110, 74);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Height";
            // 
            // nmbHeight
            // 
            this.nmbHeight.Location = new System.Drawing.Point(151, 72);
            this.nmbHeight.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nmbHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbHeight.Name = "nmbHeight";
            this.nmbHeight.Size = new System.Drawing.Size(58, 20);
            this.nmbHeight.TabIndex = 6;
            this.nmbHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nmbHeight.ValueChanged += new System.EventHandler(this.nmbHeight_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 74);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 16;
            this.lblWidth.Text = "Width";
            // 
            // nmbWidth
            // 
            this.nmbWidth.Location = new System.Drawing.Point(47, 72);
            this.nmbWidth.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nmbWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmbWidth.Name = "nmbWidth";
            this.nmbWidth.Size = new System.Drawing.Size(58, 20);
            this.nmbWidth.TabIndex = 5;
            this.nmbWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.nmbWidth.ValueChanged += new System.EventHandler(this.nmbWidth_ValueChanged);
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Location = new System.Drawing.Point(6, 48);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(21, 13);
            this.lblFps.TabIndex = 10;
            this.lblFps.Text = "fps";
            // 
            // nmrFps
            // 
            this.nmrFps.Location = new System.Drawing.Point(32, 46);
            this.nmrFps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrFps.Name = "nmrFps";
            this.nmrFps.Size = new System.Drawing.Size(63, 20);
            this.nmrFps.TabIndex = 3;
            this.nmrFps.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrFps.ValueChanged += new System.EventHandler(this.nmrFps_ValueChanged);
            // 
            // btnSelectVideo
            // 
            this.btnSelectVideo.Location = new System.Drawing.Point(199, 19);
            this.btnSelectVideo.Name = "btnSelectVideo";
            this.btnSelectVideo.Size = new System.Drawing.Size(25, 21);
            this.btnSelectVideo.TabIndex = 1;
            this.btnSelectVideo.Text = "...";
            this.btnSelectVideo.UseVisualStyleBackColor = true;
            this.btnSelectVideo.Click += new System.EventHandler(this.btnSelectVideo_Click);
            // 
            // txtVideoFile
            // 
            this.txtVideoFile.Location = new System.Drawing.Point(7, 19);
            this.txtVideoFile.Name = "txtVideoFile";
            this.txtVideoFile.Size = new System.Drawing.Size(186, 20);
            this.txtVideoFile.TabIndex = 0;
            this.txtVideoFile.TextChanged += new System.EventHandler(this.txtVideoFile_TextChanged);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Checked = true;
            this.chkLoop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoop.Location = new System.Drawing.Point(113, 47);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(46, 17);
            this.chkLoop.TabIndex = 4;
            this.chkLoop.Text = "loop";
            this.chkLoop.UseVisualStyleBackColor = true;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // btnStartStreaming
            // 
            this.btnStartStreaming.Location = new System.Drawing.Point(277, 291);
            this.btnStartStreaming.Name = "btnStartStreaming";
            this.btnStartStreaming.Size = new System.Drawing.Size(294, 105);
            this.btnStartStreaming.TabIndex = 9;
            this.btnStartStreaming.Text = "&Start Streaming";
            this.btnStartStreaming.UseVisualStyleBackColor = true;
            this.btnStartStreaming.Click += new System.EventHandler(this.btnStartStreaming_Click);
            // 
            // btnClearResponse
            // 
            this.btnClearResponse.Location = new System.Drawing.Point(1310, 226);
            this.btnClearResponse.Name = "btnClearResponse";
            this.btnClearResponse.Size = new System.Drawing.Size(91, 23);
            this.btnClearResponse.TabIndex = 18;
            this.btnClearResponse.Text = "Clear";
            this.btnClearResponse.UseVisualStyleBackColor = true;
            this.btnClearResponse.Click += new System.EventHandler(this.btnClearResponse_Click);
            // 
            // cameraOutputGroupBox
            // 
            this.cameraOutputGroupBox.Controls.Add(this.radBase64);
            this.cameraOutputGroupBox.Controls.Add(this.radNone);
            this.cameraOutputGroupBox.Controls.Add(this.cameraOutput);
            this.cameraOutputGroupBox.Location = new System.Drawing.Point(1007, 12);
            this.cameraOutputGroupBox.Name = "cameraOutputGroupBox";
            this.cameraOutputGroupBox.Size = new System.Drawing.Size(418, 402);
            this.cameraOutputGroupBox.TabIndex = 1;
            this.cameraOutputGroupBox.TabStop = false;
            this.cameraOutputGroupBox.Text = "Video Output";
            // 
            // cameraOutput
            // 
            this.cameraOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cameraOutput.Location = new System.Drawing.Point(6, 58);
            this.cameraOutput.Name = "cameraOutput";
            this.cameraOutput.Size = new System.Drawing.Size(400, 300);
            this.cameraOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraOutput.TabIndex = 0;
            this.cameraOutput.TabStop = false;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Location = new System.Drawing.Point(6, 34);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(51, 17);
            this.radNone.TabIndex = 1;
            this.radNone.TabStop = true;
            this.radNone.Text = "None";
            this.radNone.UseVisualStyleBackColor = true;
            // 
            // radBase64
            // 
            this.radBase64.AutoSize = true;
            this.radBase64.Location = new System.Drawing.Point(63, 34);
            this.radBase64.Name = "radBase64";
            this.radBase64.Size = new System.Drawing.Size(106, 17);
            this.radBase64.TabIndex = 2;
            this.radBase64.Text = "response base64";
            this.radBase64.UseVisualStyleBackColor = true;
            // 
            // chkPrintResponse
            // 
            this.chkPrintResponse.AutoSize = true;
            this.chkPrintResponse.Checked = true;
            this.chkPrintResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrintResponse.Location = new System.Drawing.Point(9, 18);
            this.chkPrintResponse.Name = "chkPrintResponse";
            this.chkPrintResponse.Size = new System.Drawing.Size(92, 17);
            this.chkPrintResponse.TabIndex = 19;
            this.chkPrintResponse.Text = "print response";
            this.chkPrintResponse.UseVisualStyleBackColor = true;
            this.chkPrintResponse.CheckedChanged += new System.EventHandler(this.chkPrintResponse_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 687);
            this.Controls.Add(this.cameraOutputGroupBox);
            this.Controls.Add(this.btnStartStreaming);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.cameraSourceGroupBox);
            this.Name = "MainWindow";
            this.Text = "video-streamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cameraSourceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraOriginal)).EndInit();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupCamera.ResumeLayout(false);
            this.groupCamera.PerformLayout();
            this.groupVideoFile.ResumeLayout(false);
            this.groupVideoFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).EndInit();
            this.cameraOutputGroupBox.ResumeLayout(false);
            this.cameraOutputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cameraSourceGroupBox;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.PictureBox cameraOriginal;
        private System.Windows.Forms.Button stopRecordingButton;
        private System.Windows.Forms.Button startRecordingButton;
        private System.Windows.Forms.Button refreshCameraSettingsButton;
        private System.Windows.Forms.PictureBox recordingActiveIconPictureBox;
        private System.Windows.Forms.Label recordingTimeLabel;
        private System.Windows.Forms.ComboBox videoFrameRateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label snapshotFormatLabel;
        private System.Windows.Forms.ComboBox videoResolutionComboBox;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.TextBox txtSendTo;
        private System.Windows.Forms.Label lblSendTo;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblBodyContentNote;
        private System.Windows.Forms.Label lblBodyContent;
        private System.Windows.Forms.TextBox txtBodyContent;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.TextBox txtVideoFile;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.GroupBox groupCamera;
        private System.Windows.Forms.GroupBox groupVideoFile;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.NumericUpDown nmrFps;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nmbWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nmbHeight;
        private System.Windows.Forms.RadioButton radCamera;
        private System.Windows.Forms.RadioButton radVideo;
        private System.Windows.Forms.Button btnStartStreaming;
        private System.Windows.Forms.Button btnClearResponse;
        private System.Windows.Forms.GroupBox cameraOutputGroupBox;
        private System.Windows.Forms.PictureBox cameraOutput;
        private System.Windows.Forms.RadioButton radBase64;
        private System.Windows.Forms.RadioButton radNone;
        private System.Windows.Forms.CheckBox chkPrintResponse;
    }
}

