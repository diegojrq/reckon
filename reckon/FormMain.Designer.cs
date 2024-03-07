namespace reckon
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BT_LoadSourceImage = new Button();
            BT_LoadFragmentImage = new Button();
            BT_CheckImages = new Button();
            PB_SourceImage = new PictureBox();
            PB_FragmentImage = new PictureBox();
            PB_CheckedImage = new PictureBox();
            BT_ScreenCapture = new Button();
            PB_SreenCapturedImage = new PictureBox();
            BT_ScreenCaptureTimer = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_SourceImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_FragmentImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_CheckedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_SreenCapturedImage).BeginInit();
            SuspendLayout();
            // 
            // BT_LoadSourceImage
            // 
            BT_LoadSourceImage.Location = new Point(691, 12);
            BT_LoadSourceImage.Name = "BT_LoadSourceImage";
            BT_LoadSourceImage.Size = new Size(97, 23);
            BT_LoadSourceImage.TabIndex = 0;
            BT_LoadSourceImage.Text = "Source";
            BT_LoadSourceImage.UseVisualStyleBackColor = true;
            BT_LoadSourceImage.Click += BT_LoadSourceImage_Click;
            // 
            // BT_LoadFragmentImage
            // 
            BT_LoadFragmentImage.Location = new Point(691, 41);
            BT_LoadFragmentImage.Name = "BT_LoadFragmentImage";
            BT_LoadFragmentImage.Size = new Size(97, 23);
            BT_LoadFragmentImage.TabIndex = 1;
            BT_LoadFragmentImage.Text = "Fragment";
            BT_LoadFragmentImage.UseVisualStyleBackColor = true;
            BT_LoadFragmentImage.Click += BT_LoadFragmentImage_Click;
            // 
            // BT_CheckImages
            // 
            BT_CheckImages.Location = new Point(691, 415);
            BT_CheckImages.Name = "BT_CheckImages";
            BT_CheckImages.Size = new Size(97, 23);
            BT_CheckImages.TabIndex = 2;
            BT_CheckImages.Text = "Checar";
            BT_CheckImages.UseVisualStyleBackColor = true;
            BT_CheckImages.Click += BT_CheckImages_Click;
            // 
            // PB_SourceImage
            // 
            PB_SourceImage.Location = new Point(12, 12);
            PB_SourceImage.Name = "PB_SourceImage";
            PB_SourceImage.Size = new Size(136, 128);
            PB_SourceImage.TabIndex = 3;
            PB_SourceImage.TabStop = false;
            // 
            // PB_FragmentImage
            // 
            PB_FragmentImage.Location = new Point(154, 12);
            PB_FragmentImage.Name = "PB_FragmentImage";
            PB_FragmentImage.Size = new Size(136, 128);
            PB_FragmentImage.TabIndex = 4;
            PB_FragmentImage.TabStop = false;
            // 
            // PB_CheckedImage
            // 
            PB_CheckedImage.Location = new Point(296, 12);
            PB_CheckedImage.Name = "PB_CheckedImage";
            PB_CheckedImage.Size = new Size(277, 243);
            PB_CheckedImage.TabIndex = 5;
            PB_CheckedImage.TabStop = false;
            // 
            // BT_ScreenCapture
            // 
            BT_ScreenCapture.Location = new Point(12, 415);
            BT_ScreenCapture.Name = "BT_ScreenCapture";
            BT_ScreenCapture.Size = new Size(97, 23);
            BT_ScreenCapture.TabIndex = 6;
            BT_ScreenCapture.Text = "Capture";
            BT_ScreenCapture.UseVisualStyleBackColor = true;
            BT_ScreenCapture.Click += BT_ScreenCapture_Click;
            // 
            // PB_SreenCapturedImage
            // 
            PB_SreenCapturedImage.Location = new Point(12, 146);
            PB_SreenCapturedImage.Name = "PB_SreenCapturedImage";
            PB_SreenCapturedImage.Size = new Size(278, 263);
            PB_SreenCapturedImage.TabIndex = 7;
            PB_SreenCapturedImage.TabStop = false;
            // 
            // BT_ScreenCaptureTimer
            // 
            BT_ScreenCaptureTimer.Location = new Point(115, 415);
            BT_ScreenCaptureTimer.Name = "BT_ScreenCaptureTimer";
            BT_ScreenCaptureTimer.Size = new Size(97, 23);
            BT_ScreenCaptureTimer.TabIndex = 8;
            BT_ScreenCaptureTimer.Text = "Capture Timer";
            BT_ScreenCaptureTimer.UseVisualStyleBackColor = true;
            BT_ScreenCaptureTimer.Click += BT_ScreenCaptureTimer_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BT_ScreenCaptureTimer);
            Controls.Add(PB_SreenCapturedImage);
            Controls.Add(BT_ScreenCapture);
            Controls.Add(PB_CheckedImage);
            Controls.Add(PB_FragmentImage);
            Controls.Add(PB_SourceImage);
            Controls.Add(BT_CheckImages);
            Controls.Add(BT_LoadFragmentImage);
            Controls.Add(BT_LoadSourceImage);
            Name = "FormMain";
            Text = "Reckon";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PB_SourceImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_FragmentImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_CheckedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_SreenCapturedImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BT_LoadSourceImage;
        private Button BT_LoadFragmentImage;
        private Button BT_CheckImages;
        private PictureBox PB_SourceImage;
        private PictureBox PB_FragmentImage;
        private PictureBox PB_CheckedImage;
        private Button BT_ScreenCapture;
        private PictureBox PB_SreenCapturedImage;
        private Button BT_ScreenCaptureTimer;
    }
}
