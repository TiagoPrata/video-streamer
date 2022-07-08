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
            this.cameraOutputGroupBox = new System.Windows.Forms.GroupBox();
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
            this.connectToCameraButton = new System.Windows.Forms.Button();
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
            this.lblOR = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFps = new System.Windows.Forms.Label();
            this.nmrFps = new System.Windows.Forms.NumericUpDown();
            this.btnSelectVideo = new System.Windows.Forms.Button();
            this.btnStreamVideo = new System.Windows.Forms.Button();
            this.txtVideoFile = new System.Windows.Forms.TextBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nmbWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nmbHeight = new System.Windows.Forms.NumericUpDown();
            this.cameraOutputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraOriginal)).BeginInit();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraOutputGroupBox
            // 
            this.cameraOutputGroupBox.Controls.Add(this.cameraOriginal);
            this.cameraOutputGroupBox.Location = new System.Drawing.Point(668, 12);
            this.cameraOutputGroupBox.Name = "cameraOutputGroupBox";
            this.cameraOutputGroupBox.Size = new System.Drawing.Size(601, 402);
            this.cameraOutputGroupBox.TabIndex = 0;
            this.cameraOutputGroupBox.TabStop = false;
            this.cameraOutputGroupBox.Text = "Video Output";
            // 
            // cameraOriginal
            // 
            this.cameraOriginal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cameraOriginal.Location = new System.Drawing.Point(10, 39);
            this.cameraOriginal.Name = "cameraOriginal";
            this.cameraOriginal.Size = new System.Drawing.Size(577, 338);
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
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(309, 402);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Destination";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(9, 76);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(153, 20);
            this.txtMethod.TabIndex = 12;
            this.txtMethod.Text = "POST";
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
            this.txtBodyContent.TabIndex = 1;
            this.txtBodyContent.Text = "{\"img_base64str\": \"$frame$\"}";
            // 
            // txtSendTo
            // 
            this.txtSendTo.Location = new System.Drawing.Point(9, 34);
            this.txtSendTo.Name = "txtSendTo";
            this.txtSendTo.Size = new System.Drawing.Size(294, 20);
            this.txtSendTo.TabIndex = 8;
            this.txtSendTo.Text = "http://localhost:5000/";
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
            this.videoFrameRateComboBox.TabIndex = 6;
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
            // connectToCameraButton
            // 
            this.connectToCameraButton.Location = new System.Drawing.Point(225, 33);
            this.connectToCameraButton.Name = "connectToCameraButton";
            this.connectToCameraButton.Size = new System.Drawing.Size(75, 21);
            this.connectToCameraButton.TabIndex = 3;
            this.connectToCameraButton.Text = "Connect";
            this.connectToCameraButton.UseVisualStyleBackColor = true;
            this.connectToCameraButton.Click += new System.EventHandler(this.connectToCameraButton_Click);
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
            this.videoResolutionComboBox.TabIndex = 3;
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
            this.deviceComboBox.TabIndex = 1;
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
            this.refreshCameraSettingsButton.TabIndex = 7;
            this.refreshCameraSettingsButton.Text = "Refresh camera settings";
            this.refreshCameraSettingsButton.UseVisualStyleBackColor = true;
            this.refreshCameraSettingsButton.Click += new System.EventHandler(this.refreshCameraSettingsButton_Click);
            // 
            // stopRecordingButton
            // 
            this.stopRecordingButton.Location = new System.Drawing.Point(120, 195);
            this.stopRecordingButton.Name = "stopRecordingButton";
            this.stopRecordingButton.Size = new System.Drawing.Size(103, 23);
            this.stopRecordingButton.TabIndex = 2;
            this.stopRecordingButton.Text = "Stop Recording";
            this.stopRecordingButton.UseVisualStyleBackColor = true;
            this.stopRecordingButton.Click += new System.EventHandler(this.stopRecordingButton_Click);
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.Location = new System.Drawing.Point(6, 195);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(108, 23);
            this.startRecordingButton.TabIndex = 1;
            this.startRecordingButton.Text = "Start Recording";
            this.startRecordingButton.UseVisualStyleBackColor = true;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingButton_Click);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.txtResponse);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 420);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(1257, 236);
            this.controlsGroupBox.TabIndex = 2;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(9, 19);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(1234, 202);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOR);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 402);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Configuration";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deviceComboBox);
            this.groupBox3.Controls.Add(this.recordingActiveIconPictureBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.startRecordingButton);
            this.groupBox3.Controls.Add(this.recordingTimeLabel);
            this.groupBox3.Controls.Add(this.stopRecordingButton);
            this.groupBox3.Controls.Add(this.deviceLabel);
            this.groupBox3.Controls.Add(this.snapshotFormatLabel);
            this.groupBox3.Controls.Add(this.ResolutionLabel);
            this.groupBox3.Controls.Add(this.videoFrameRateComboBox);
            this.groupBox3.Controls.Add(this.videoResolutionComboBox);
            this.groupBox3.Controls.Add(this.connectToCameraButton);
            this.groupBox3.Controls.Add(this.refreshCameraSettingsButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 254);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHeight);
            this.groupBox2.Controls.Add(this.nmbHeight);
            this.groupBox2.Controls.Add(this.lblWidth);
            this.groupBox2.Controls.Add(this.nmbWidth);
            this.groupBox2.Controls.Add(this.lblFps);
            this.groupBox2.Controls.Add(this.nmrFps);
            this.groupBox2.Controls.Add(this.btnSelectVideo);
            this.groupBox2.Controls.Add(this.btnStreamVideo);
            this.groupBox2.Controls.Add(this.txtVideoFile);
            this.groupBox2.Controls.Add(this.chkLoop);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 97);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video File";
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
            this.nmrFps.TabIndex = 15;
            this.nmrFps.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnSelectVideo
            // 
            this.btnSelectVideo.Location = new System.Drawing.Point(199, 19);
            this.btnSelectVideo.Name = "btnSelectVideo";
            this.btnSelectVideo.Size = new System.Drawing.Size(25, 21);
            this.btnSelectVideo.TabIndex = 14;
            this.btnSelectVideo.Text = "...";
            this.btnSelectVideo.UseVisualStyleBackColor = true;
            this.btnSelectVideo.Click += new System.EventHandler(this.btnSelectVideo_Click);
            // 
            // btnStreamVideo
            // 
            this.btnStreamVideo.Location = new System.Drawing.Point(226, 19);
            this.btnStreamVideo.Name = "btnStreamVideo";
            this.btnStreamVideo.Size = new System.Drawing.Size(75, 21);
            this.btnStreamVideo.TabIndex = 10;
            this.btnStreamVideo.Text = "Stream";
            this.btnStreamVideo.UseVisualStyleBackColor = true;
            this.btnStreamVideo.Click += new System.EventHandler(this.btnStreamVideo_Click);
            // 
            // txtVideoFile
            // 
            this.txtVideoFile.Location = new System.Drawing.Point(7, 19);
            this.txtVideoFile.Name = "txtVideoFile";
            this.txtVideoFile.Size = new System.Drawing.Size(186, 20);
            this.txtVideoFile.TabIndex = 13;
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Checked = true;
            this.chkLoop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoop.Location = new System.Drawing.Point(255, 46);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(46, 17);
            this.chkLoop.TabIndex = 11;
            this.chkLoop.Text = "loop";
            this.chkLoop.UseVisualStyleBackColor = true;
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
            this.nmbWidth.TabIndex = 17;
            this.nmbWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
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
            this.nmbHeight.TabIndex = 19;
            this.nmbHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.cameraOutputGroupBox);
            this.Name = "MainWindow";
            this.Text = "video-streamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.cameraOutputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraOriginal)).EndInit();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingActiveIconPictureBox)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cameraOutputGroupBox;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Button connectToCameraButton;
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
        private System.Windows.Forms.Button btnStreamVideo;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.TextBox txtVideoFile;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.NumericUpDown nmrFps;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nmbWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nmbHeight;
    }
}

