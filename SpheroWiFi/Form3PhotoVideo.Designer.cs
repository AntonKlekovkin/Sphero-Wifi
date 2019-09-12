namespace SpheroWiFi
{
    partial class Form3PhotoVideo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnStopVideo = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(5, 776);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(480, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUrl.Location = new System.Drawing.Point(5, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(480, 20);
            this.tbUrl.TabIndex = 9;
            // 
            // btnStopVideo
            // 
            this.btnStopVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStopVideo.Location = new System.Drawing.Point(5, 99);
            this.btnStopVideo.Name = "btnStopVideo";
            this.btnStopVideo.Size = new System.Drawing.Size(480, 37);
            this.btnStopVideo.TabIndex = 12;
            this.btnStopVideo.Text = "Stop Video";
            this.btnStopVideo.UseVisualStyleBackColor = true;
            this.btnStopVideo.Click += new System.EventHandler(this.btnStopVideo_Click);
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartVideo.Location = new System.Drawing.Point(5, 62);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(480, 37);
            this.btnStartVideo.TabIndex = 11;
            this.btnStartVideo.Text = "Start Video";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            this.btnStartVideo.Click += new System.EventHandler(this.btnStartVideo_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhoto.Location = new System.Drawing.Point(5, 25);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(480, 37);
            this.btnPhoto.TabIndex = 10;
            this.btnPhoto.Text = "Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPhoto.Location = new System.Drawing.Point(5, 136);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(480, 640);
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // Form3PhotoVideo
            // 
            this.ClientSize = new System.Drawing.Size(490, 818);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnStopVideo);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnClose);
            this.Name = "Form3PhotoVideo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Photo/Video";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnStopVideo;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}