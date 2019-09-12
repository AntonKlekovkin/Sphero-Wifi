namespace SpheroWiFi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_Off = new System.Windows.Forms.RadioButton();
            this.rb_Dec = new System.Windows.Forms.RadioButton();
            this.rb_Ascii = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.rb_Hex = new System.Windows.Forms.RadioButton();
            this.tb_Receive = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSpeedRotate = new System.Windows.Forms.TextBox();
            this.btnGetAngles = new System.Windows.Forms.Button();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.btnAngle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAng3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAng2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAng1 = new System.Windows.Forms.TextBox();
            this.tbSpeed2 = new System.Windows.Forms.TextBox();
            this.tbSpeed1 = new System.Windows.Forms.TextBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIpMax = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cb_IP = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoVidoeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTrajectory = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStartTr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSendTr = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbCycle = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSpeedRotorTr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTRotateTr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTStraightTr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSpeedMovingTr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBackTr = new System.Windows.Forms.Button();
            this.btnRightBackTr = new System.Windows.Forms.Button();
            this.btnLeftBackTr = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnForwardTr = new System.Windows.Forms.Button();
            this.btnRightForwardTr = new System.Windows.Forms.Button();
            this.btnLeftForwardTr = new System.Windows.Forms.Button();
            this.btnClearTr = new System.Windows.Forms.Button();
            this.tbTrajectory = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbTrajectory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(10, 635);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(549, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.tb_Receive);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(10, 473);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(549, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_Off);
            this.groupBox5.Controls.Add(this.rb_Dec);
            this.groupBox5.Controls.Add(this.rb_Ascii);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.rb_Hex);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(5, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(539, 49);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receive Control";
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
            this.button4.Location = new System.Drawing.Point(217, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(317, 26);
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
            // tb_Receive
            // 
            this.tb_Receive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_Receive.Location = new System.Drawing.Point(5, 72);
            this.tb_Receive.Multiline = true;
            this.tb_Receive.Name = "tb_Receive";
            this.tb_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Receive.Size = new System.Drawing.Size(539, 85);
            this.tb_Receive.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSpeedRotate);
            this.groupBox3.Controls.Add(this.btnGetAngles);
            this.groupBox3.Controls.Add(this.tbAngle);
            this.groupBox3.Controls.Add(this.btnAngle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbAng3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbAng2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbAng1);
            this.groupBox3.Controls.Add(this.tbSpeed2);
            this.groupBox3.Controls.Add(this.tbSpeed1);
            this.groupBox3.Controls.Add(this.btnBack2);
            this.groupBox3.Controls.Add(this.btnStop2);
            this.groupBox3.Controls.Add(this.btnForward2);
            this.groupBox3.Controls.Add(this.btnBack1);
            this.groupBox3.Controls.Add(this.btnStop1);
            this.groupBox3.Controls.Add(this.btnForward1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(203, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 135);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Motors";
            // 
            // tbSpeedRotate
            // 
            this.tbSpeedRotate.Location = new System.Drawing.Point(133, 103);
            this.tbSpeedRotate.Name = "tbSpeedRotate";
            this.tbSpeedRotate.Size = new System.Drawing.Size(33, 20);
            this.tbSpeedRotate.TabIndex = 20;
            this.tbSpeedRotate.Text = "50";
            // 
            // btnGetAngles
            // 
            this.btnGetAngles.Location = new System.Drawing.Point(257, 101);
            this.btnGetAngles.Name = "btnGetAngles";
            this.btnGetAngles.Size = new System.Drawing.Size(75, 23);
            this.btnGetAngles.TabIndex = 19;
            this.btnGetAngles.Text = "Get Angles";
            this.btnGetAngles.UseVisualStyleBackColor = true;
            this.btnGetAngles.Click += new System.EventHandler(this.btnGetAngles_Click);
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(93, 104);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(34, 20);
            this.tbAngle.TabIndex = 18;
            this.tbAngle.Text = "10";
            // 
            // btnAngle
            // 
            this.btnAngle.Location = new System.Drawing.Point(9, 101);
            this.btnAngle.Name = "btnAngle";
            this.btnAngle.Size = new System.Drawing.Size(75, 23);
            this.btnAngle.TabIndex = 17;
            this.btnAngle.Text = "Rotate";
            this.btnAngle.UseVisualStyleBackColor = true;
            this.btnAngle.Click += new System.EventHandler(this.btnAngle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ang3";
            // 
            // tbAng3
            // 
            this.tbAng3.Location = new System.Drawing.Point(267, 75);
            this.tbAng3.Name = "tbAng3";
            this.tbAng3.Size = new System.Drawing.Size(61, 20);
            this.tbAng3.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ang2";
            // 
            // tbAng2
            // 
            this.tbAng2.Location = new System.Drawing.Point(158, 75);
            this.tbAng2.Name = "tbAng2";
            this.tbAng2.Size = new System.Drawing.Size(61, 20);
            this.tbAng2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ang1";
            // 
            // tbAng1
            // 
            this.tbAng1.Location = new System.Drawing.Point(49, 75);
            this.tbAng1.Name = "tbAng1";
            this.tbAng1.Size = new System.Drawing.Size(61, 20);
            this.tbAng1.TabIndex = 10;
            // 
            // tbSpeed2
            // 
            this.tbSpeed2.Location = new System.Drawing.Point(293, 48);
            this.tbSpeed2.Name = "tbSpeed2";
            this.tbSpeed2.Size = new System.Drawing.Size(43, 20);
            this.tbSpeed2.TabIndex = 9;
            this.tbSpeed2.Text = "100";
            // 
            // tbSpeed1
            // 
            this.tbSpeed1.Location = new System.Drawing.Point(293, 18);
            this.tbSpeed1.Name = "tbSpeed1";
            this.tbSpeed1.Size = new System.Drawing.Size(43, 20);
            this.tbSpeed1.TabIndex = 9;
            this.tbSpeed1.Text = "100";
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(213, 45);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(75, 23);
            this.btnBack2.TabIndex = 7;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(131, 46);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 23);
            this.btnStop2.TabIndex = 6;
            this.btnStop2.Text = "Stop";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Location = new System.Drawing.Point(49, 46);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(75, 23);
            this.btnForward2.TabIndex = 5;
            this.btnForward2.Text = "Forward";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward2_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(211, 17);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(75, 23);
            this.btnBack1.TabIndex = 4;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(130, 17);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(75, 23);
            this.btnStop1.TabIndex = 3;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.Location = new System.Drawing.Point(49, 17);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(75, 23);
            this.btnForward1.TabIndex = 2;
            this.btnForward1.Text = "Forward";
            this.btnForward1.UseVisualStyleBackColor = true;
            this.btnForward1.Click += new System.EventHandler(this.btnForward1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Motor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Motor 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbIpMax);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.tbStatus);
            this.groupBox4.Controls.Add(this.btnCheck);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.cb_IP);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(5, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 135);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max Scan";
            // 
            // tbIpMax
            // 
            this.tbIpMax.Location = new System.Drawing.Point(151, 48);
            this.tbIpMax.Name = "tbIpMax";
            this.tbIpMax.Size = new System.Drawing.Size(35, 20);
            this.tbIpMax.TabIndex = 8;
            this.tbIpMax.Text = "50";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 107);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset STM";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(6, 78);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(180, 20);
            this.tbStatus.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(6, 46);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(111, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cb_IP
            // 
            this.cb_IP.FormattingEnabled = true;
            this.cb_IP.Items.AddRange(new object[] {
            "192.168.1.19",
            "192.168.1.17"});
            this.cb_IP.Location = new System.Drawing.Point(6, 19);
            this.cb_IP.Name = "cb_IP";
            this.cb_IP.Size = new System.Drawing.Size(99, 21);
            this.cb_IP.TabIndex = 0;
            this.cb_IP.Text = "192.168.1.19";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(549, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photoVidoeToolStripMenuItem,
            this.testRequestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // photoVidoeToolStripMenuItem
            // 
            this.photoVidoeToolStripMenuItem.Name = "photoVidoeToolStripMenuItem";
            this.photoVidoeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.photoVidoeToolStripMenuItem.Text = "Photo/Video";
            this.photoVidoeToolStripMenuItem.Click += new System.EventHandler(this.photoVidoeToolStripMenuItem_Click);
            // 
            // testRequestToolStripMenuItem
            // 
            this.testRequestToolStripMenuItem.Name = "testRequestToolStripMenuItem";
            this.testRequestToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testRequestToolStripMenuItem.Text = "Test Request";
            this.testRequestToolStripMenuItem.Click += new System.EventHandler(this.testRequestToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbTrajectory
            // 
            this.gbTrajectory.Controls.Add(this.panel4);
            this.gbTrajectory.Controls.Add(this.panel1);
            this.gbTrajectory.Controls.Add(this.btnClearTr);
            this.gbTrajectory.Controls.Add(this.tbTrajectory);
            this.gbTrajectory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbTrajectory.Location = new System.Drawing.Point(10, 194);
            this.gbTrajectory.Name = "gbTrajectory";
            this.gbTrajectory.Padding = new System.Windows.Forms.Padding(7);
            this.gbTrajectory.Size = new System.Drawing.Size(549, 279);
            this.gbTrajectory.TabIndex = 24;
            this.gbTrajectory.TabStop = false;
            this.gbTrajectory.Text = "Trajectory";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(7, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 115);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnStartTr);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnSendTr);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 30);
            this.panel5.TabIndex = 22;
            // 
            // btnStartTr
            // 
            this.btnStartTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartTr.Location = new System.Drawing.Point(115, 0);
            this.btnStartTr.Name = "btnStartTr";
            this.btnStartTr.Size = new System.Drawing.Size(305, 30);
            this.btnStartTr.TabIndex = 20;
            this.btnStartTr.Text = "Start Trajectory";
            this.btnStartTr.UseVisualStyleBackColor = true;
            this.btnStartTr.Click += new System.EventHandler(this.btnStartTr_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(420, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Stop Trajectory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStopTr_Click);
            // 
            // btnSendTr
            // 
            this.btnSendTr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSendTr.Location = new System.Drawing.Point(0, 0);
            this.btnSendTr.Name = "btnSendTr";
            this.btnSendTr.Size = new System.Drawing.Size(115, 30);
            this.btnSendTr.TabIndex = 21;
            this.btnSendTr.Text = "Send Trajectory";
            this.btnSendTr.UseVisualStyleBackColor = true;
            this.btnSendTr.Click += new System.EventHandler(this.btnSendTr_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbCycle);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.tbSpeedRotorTr);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.tbTRotateTr);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.tbTStraightTr);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.tbSpeedMovingTr);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 77);
            this.panel6.TabIndex = 21;
            // 
            // cbCycle
            // 
            this.cbCycle.AutoSize = true;
            this.cbCycle.Location = new System.Drawing.Point(235, 47);
            this.cbCycle.Name = "cbCycle";
            this.cbCycle.Size = new System.Drawing.Size(103, 17);
            this.cbCycle.TabIndex = 28;
            this.cbCycle.Text = "While Trajectory";
            this.cbCycle.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Speed Rotor";
            // 
            // tbSpeedRotorTr
            // 
            this.tbSpeedRotorTr.Location = new System.Drawing.Point(89, 44);
            this.tbSpeedRotorTr.Name = "tbSpeedRotorTr";
            this.tbSpeedRotorTr.Size = new System.Drawing.Size(39, 20);
            this.tbSpeedRotorTr.TabIndex = 20;
            this.tbSpeedRotorTr.Text = "50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "T rotate";
            // 
            // tbTRotateTr
            // 
            this.tbTRotateTr.Location = new System.Drawing.Point(188, 44);
            this.tbTRotateTr.Name = "tbTRotateTr";
            this.tbTRotateTr.Size = new System.Drawing.Size(39, 20);
            this.tbTRotateTr.TabIndex = 21;
            this.tbTRotateTr.Text = "500";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "T straight";
            // 
            // tbTStraightTr
            // 
            this.tbTStraightTr.Location = new System.Drawing.Point(188, 13);
            this.tbTStraightTr.Name = "tbTStraightTr";
            this.tbTStraightTr.Size = new System.Drawing.Size(39, 20);
            this.tbTStraightTr.TabIndex = 22;
            this.tbTStraightTr.Text = "2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Speed Moving";
            // 
            // tbSpeedMovingTr
            // 
            this.tbSpeedMovingTr.Location = new System.Drawing.Point(89, 13);
            this.tbSpeedMovingTr.Name = "tbSpeedMovingTr";
            this.tbSpeedMovingTr.Size = new System.Drawing.Size(39, 20);
            this.tbSpeedMovingTr.TabIndex = 23;
            this.tbSpeedMovingTr.Text = "100";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 64);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBackTr);
            this.panel2.Controls.Add(this.btnRightBackTr);
            this.panel2.Controls.Add(this.btnLeftBackTr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 30);
            this.panel2.TabIndex = 12;
            // 
            // btnBackTr
            // 
            this.btnBackTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackTr.Location = new System.Drawing.Point(115, 0);
            this.btnBackTr.Name = "btnBackTr";
            this.btnBackTr.Size = new System.Drawing.Size(306, 30);
            this.btnBackTr.TabIndex = 1;
            this.btnBackTr.Text = "Back";
            this.btnBackTr.UseVisualStyleBackColor = true;
            this.btnBackTr.Click += new System.EventHandler(this.btnBackTr_Click);
            // 
            // btnRightBackTr
            // 
            this.btnRightBackTr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRightBackTr.Location = new System.Drawing.Point(421, 0);
            this.btnRightBackTr.Name = "btnRightBackTr";
            this.btnRightBackTr.Size = new System.Drawing.Size(114, 30);
            this.btnRightBackTr.TabIndex = 0;
            this.btnRightBackTr.Text = "Right Back";
            this.btnRightBackTr.UseVisualStyleBackColor = true;
            this.btnRightBackTr.Click += new System.EventHandler(this.btnRightBackTr_Click);
            // 
            // btnLeftBackTr
            // 
            this.btnLeftBackTr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeftBackTr.Location = new System.Drawing.Point(0, 0);
            this.btnLeftBackTr.Name = "btnLeftBackTr";
            this.btnLeftBackTr.Size = new System.Drawing.Size(115, 30);
            this.btnLeftBackTr.TabIndex = 0;
            this.btnLeftBackTr.Text = "Left Back";
            this.btnLeftBackTr.UseVisualStyleBackColor = true;
            this.btnLeftBackTr.Click += new System.EventHandler(this.btnLeftBackTr_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnForwardTr);
            this.panel3.Controls.Add(this.btnRightForwardTr);
            this.panel3.Controls.Add(this.btnLeftForwardTr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 30);
            this.panel3.TabIndex = 11;
            // 
            // btnForwardTr
            // 
            this.btnForwardTr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForwardTr.Location = new System.Drawing.Point(115, 0);
            this.btnForwardTr.Name = "btnForwardTr";
            this.btnForwardTr.Size = new System.Drawing.Size(306, 30);
            this.btnForwardTr.TabIndex = 1;
            this.btnForwardTr.Text = "Forward";
            this.btnForwardTr.UseVisualStyleBackColor = true;
            this.btnForwardTr.Click += new System.EventHandler(this.btnForwardTr_Click);
            // 
            // btnRightForwardTr
            // 
            this.btnRightForwardTr.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRightForwardTr.Location = new System.Drawing.Point(421, 0);
            this.btnRightForwardTr.Name = "btnRightForwardTr";
            this.btnRightForwardTr.Size = new System.Drawing.Size(114, 30);
            this.btnRightForwardTr.TabIndex = 2;
            this.btnRightForwardTr.Text = "Right Fwd";
            this.btnRightForwardTr.UseVisualStyleBackColor = true;
            this.btnRightForwardTr.Click += new System.EventHandler(this.btnRightForwardTr_Click);
            // 
            // btnLeftForwardTr
            // 
            this.btnLeftForwardTr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeftForwardTr.Location = new System.Drawing.Point(0, 0);
            this.btnLeftForwardTr.Name = "btnLeftForwardTr";
            this.btnLeftForwardTr.Size = new System.Drawing.Size(115, 30);
            this.btnLeftForwardTr.TabIndex = 0;
            this.btnLeftForwardTr.Text = "Left Fwd";
            this.btnLeftForwardTr.UseVisualStyleBackColor = true;
            this.btnLeftForwardTr.Click += new System.EventHandler(this.btnLeftForwardTr_Click);
            // 
            // btnClearTr
            // 
            this.btnClearTr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearTr.Location = new System.Drawing.Point(7, 70);
            this.btnClearTr.Name = "btnClearTr";
            this.btnClearTr.Size = new System.Drawing.Size(535, 23);
            this.btnClearTr.TabIndex = 3;
            this.btnClearTr.Text = "Clear";
            this.btnClearTr.UseVisualStyleBackColor = true;
            this.btnClearTr.Click += new System.EventHandler(this.btnClearTr_Click);
            // 
            // tbTrajectory
            // 
            this.tbTrajectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrajectory.Location = new System.Drawing.Point(7, 20);
            this.tbTrajectory.Multiline = true;
            this.tbTrajectory.Name = "tbTrajectory";
            this.tbTrajectory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTrajectory.Size = new System.Drawing.Size(535, 50);
            this.tbTrajectory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 677);
            this.Controls.Add(this.gbTrajectory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sphero Control";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTrajectory.ResumeLayout(false);
            this.gbTrajectory.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Receive;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_Dec;
        private System.Windows.Forms.RadioButton rb_Ascii;
        private System.Windows.Forms.RadioButton rb_Hex;
        private System.Windows.Forms.RadioButton rb_Off;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSpeedRotate;
        private System.Windows.Forms.Button btnGetAngles;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Button btnAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAng3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAng2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAng1;
        private System.Windows.Forms.TextBox tbSpeed2;
        private System.Windows.Forms.TextBox tbSpeed1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIpMax;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cb_IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoVidoeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTrajectory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnStartTr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSendTr;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbCycle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSpeedRotorTr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTRotateTr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTStraightTr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSpeedMovingTr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackTr;
        private System.Windows.Forms.Button btnRightBackTr;
        private System.Windows.Forms.Button btnLeftBackTr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnForwardTr;
        private System.Windows.Forms.Button btnRightForwardTr;
        private System.Windows.Forms.Button btnLeftForwardTr;
        private System.Windows.Forms.Button btnClearTr;
        private System.Windows.Forms.TextBox tbTrajectory;
    }
}

