namespace SpheroWiFi
{
    partial class Form2TestRequest
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_Off = new System.Windows.Forms.RadioButton();
            this.rb_Dec = new System.Windows.Forms.RadioButton();
            this.rb_Ascii = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.rb_Hex = new System.Windows.Forms.RadioButton();
            this.tbReceiveTest = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(386, 20);
            this.tbUrl.TabIndex = 0;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(12, 38);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(386, 23);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Test Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbReceiveTest);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(387, 261);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_Off);
            this.groupBox5.Controls.Add(this.rb_Dec);
            this.groupBox5.Controls.Add(this.rb_Ascii);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.rb_Hex);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(373, 49);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receive";
            // 
            // rb_Off
            // 
            this.rb_Off.AutoSize = true;
            this.rb_Off.Checked = true;
            this.rb_Off.Location = new System.Drawing.Point(8, 21);
            this.rb_Off.Name = "rb_Off";
            this.rb_Off.Size = new System.Drawing.Size(39, 17);
            this.rb_Off.TabIndex = 5;
            this.rb_Off.TabStop = true;
            this.rb_Off.Text = "Off";
            this.rb_Off.UseVisualStyleBackColor = true;
            // 
            // rb_Dec
            // 
            this.rb_Dec.AutoSize = true;
            this.rb_Dec.Location = new System.Drawing.Point(164, 21);
            this.rb_Dec.Name = "rb_Dec";
            this.rb_Dec.Size = new System.Drawing.Size(47, 17);
            this.rb_Dec.TabIndex = 4;
            this.rb_Dec.Text = "DEC";
            this.rb_Dec.UseVisualStyleBackColor = true;
            // 
            // rb_Ascii
            // 
            this.rb_Ascii.AutoSize = true;
            this.rb_Ascii.Location = new System.Drawing.Point(53, 21);
            this.rb_Ascii.Name = "rb_Ascii";
            this.rb_Ascii.Size = new System.Drawing.Size(52, 17);
            this.rb_Ascii.TabIndex = 2;
            this.rb_Ascii.Text = "ASCII";
            this.rb_Ascii.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(266, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 26);
            this.button4.TabIndex = 0;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rb_Hex
            // 
            this.rb_Hex.AutoSize = true;
            this.rb_Hex.Location = new System.Drawing.Point(111, 21);
            this.rb_Hex.Name = "rb_Hex";
            this.rb_Hex.Size = new System.Drawing.Size(47, 17);
            this.rb_Hex.TabIndex = 3;
            this.rb_Hex.Text = "HEX";
            this.rb_Hex.UseVisualStyleBackColor = true;
            // 
            // tbReceiveTest
            // 
            this.tbReceiveTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReceiveTest.Location = new System.Drawing.Point(7, 56);
            this.tbReceiveTest.Multiline = true;
            this.tbReceiveTest.Name = "tbReceiveTest";
            this.tbReceiveTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReceiveTest.Size = new System.Drawing.Size(373, 198);
            this.tbReceiveTest.TabIndex = 6;
            // 
            // Form2TestRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form2TestRequest";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Form2TestRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_Off;
        private System.Windows.Forms.RadioButton rb_Dec;
        private System.Windows.Forms.RadioButton rb_Ascii;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rb_Hex;
        private System.Windows.Forms.TextBox tbReceiveTest;
    }
}