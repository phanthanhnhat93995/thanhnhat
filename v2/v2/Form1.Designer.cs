namespace v2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ex = new System.Windows.Forms.Button();
            this.txtAllData = new System.Windows.Forms.TextBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.bcon = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.s2 = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.i1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtthoigian = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.i2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.thoigian = new System.Windows.Forms.Timer(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(19, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 36);
            this.label10.TabIndex = 87;
            this.label10.Text = "Dữ liệu đã nhận:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(130, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 36);
            this.label7.TabIndex = 84;
            this.label7.Text = "Baud Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(128, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 36);
            this.label6.TabIndex = 83;
            this.label6.Text = "COM Port:";
            // 
            // ex
            // 
            this.ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ex.Location = new System.Drawing.Point(411, 76);
            this.ex.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(229, 59);
            this.ex.TabIndex = 82;
            this.ex.Text = "THOÁT";
            this.ex.UseVisualStyleBackColor = false;
            this.ex.Click += new System.EventHandler(this.ex_Click);
            // 
            // txtAllData
            // 
            this.txtAllData.Location = new System.Drawing.Point(282, 328);
            this.txtAllData.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtAllData.Name = "txtAllData";
            this.txtAllData.Size = new System.Drawing.Size(376, 44);
            this.txtAllData.TabIndex = 81;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(326, 254);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(168, 44);
            this.cbBaudRate.TabIndex = 80;
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(326, 183);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(168, 44);
            this.cbComPort.TabIndex = 79;
            // 
            // bcon
            // 
            this.bcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bcon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcon.Location = new System.Drawing.Point(40, 76);
            this.bcon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bcon.Name = "bcon";
            this.bcon.Size = new System.Drawing.Size(332, 59);
            this.bcon.TabIndex = 78;
            this.bcon.Text = "KẾT NỐI";
            this.bcon.UseVisualStyleBackColor = false;
            this.bcon.Click += new System.EventHandler(this.bcon_Click);
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.t2.Location = new System.Drawing.Point(313, 76);
            this.t2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(136, 59);
            this.t2.TabIndex = 76;
            this.t2.Text = "TẮT";
            this.t2.UseVisualStyleBackColor = false;
            this.t2.Click += new System.EventHandler(this.t2_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b2.Location = new System.Drawing.Point(76, 76);
            this.b2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(131, 59);
            this.b2.TabIndex = 75;
            this.b2.Text = "BẬT";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(233, 438);
            this.s2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(226, 44);
            this.s2.TabIndex = 74;
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(233, 301);
            this.v2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(226, 44);
            this.v2.TabIndex = 73;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(233, 368);
            this.c2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(226, 44);
            this.c2.TabIndex = 72;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(233, 233);
            this.n2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(226, 44);
            this.n2.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Linen;
            this.label12.Location = new System.Drawing.Point(58, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 36);
            this.label12.TabIndex = 70;
            this.label12.Text = "Trạng thái:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Linen;
            this.label16.Location = new System.Drawing.Point(58, 371);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 36);
            this.label16.TabIndex = 69;
            this.label16.Text = "Dòng điện:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Linen;
            this.label17.Location = new System.Drawing.Point(58, 304);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 36);
            this.label17.TabIndex = 68;
            this.label17.Text = "Điện áp:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Linen;
            this.label18.Location = new System.Drawing.Point(58, 236);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 36);
            this.label18.TabIndex = 67;
            this.label18.Text = "Nhiệt độ:";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b1.Location = new System.Drawing.Point(82, 76);
            this.b1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(131, 59);
            this.b1.TabIndex = 65;
            this.b1.Text = "BẬT";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.t1.Location = new System.Drawing.Point(307, 76);
            this.t1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(128, 59);
            this.t1.TabIndex = 64;
            this.t1.Text = "TẮT";
            this.t1.UseVisualStyleBackColor = false;
            this.t1.Click += new System.EventHandler(this.t1_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(239, 377);
            this.c1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(215, 44);
            this.c1.TabIndex = 63;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(239, 234);
            this.n1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(215, 44);
            this.n1.TabIndex = 62;
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(239, 302);
            this.v1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(215, 44);
            this.v1.TabIndex = 61;
            // 
            // i1
            // 
            this.i1.Location = new System.Drawing.Point(239, 163);
            this.i1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.i1.Name = "i1";
            this.i1.Size = new System.Drawing.Size(215, 44);
            this.i1.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(63, 381);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 36);
            this.label5.TabIndex = 59;
            this.label5.Text = "Dòng điện:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(63, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 36);
            this.label4.TabIndex = 58;
            this.label4.Text = "Điện áp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(63, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nhiệt độ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(63, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 36);
            this.label2.TabIndex = 56;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(555, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1321, 61);
            this.label1.TabIndex = 54;
            this.label1.Text = "ĐIIỀU KHIỂN VÀ GIÁM SÁT ĐỘNG CƠ ĐIỆN TỪ XA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serCom
            // 
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.s1);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.i1);
            this.groupBox1.Controls.Add(this.v1);
            this.groupBox1.Controls.Add(this.n1);
            this.groupBox1.Controls.Add(this.c1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(343, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 601);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐỘNG CƠ 1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Linen;
            this.label23.Location = new System.Drawing.Point(63, 446);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 36);
            this.label23.TabIndex = 69;
            this.label23.Text = "Tốc độ:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Linen;
            this.label22.Location = new System.Drawing.Point(63, 510);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 36);
            this.label22.TabIndex = 68;
            this.label22.Text = "Công suất:";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(239, 502);
            this.p1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(215, 44);
            this.p1.TabIndex = 67;
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(239, 443);
            this.s1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(215, 44);
            this.s1.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtthoigian);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bcon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbComPort);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.txtAllData);
            this.groupBox2.Controls.Add(this.ex);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(925, 559);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 574);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KẾT NỐI";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Linen;
            this.label20.Location = new System.Drawing.Point(19, 405);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(259, 36);
            this.label20.TabIndex = 90;
            this.label20.Text = "Thời gian hiện tại";
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(282, 401);
            this.txtthoigian.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.Size = new System.Drawing.Size(376, 44);
            this.txtthoigian.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 69);
            this.button1.TabIndex = 88;
            this.button1.Text = "LÀM MỚI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.p2);
            this.groupBox3.Controls.Add(this.i2);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.t2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.b2);
            this.groupBox3.Controls.Add(this.n2);
            this.groupBox3.Controls.Add(this.s2);
            this.groupBox3.Controls.Add(this.c2);
            this.groupBox3.Controls.Add(this.v2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1654, 559);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 598);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ĐỘNG CƠ 2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Linen;
            this.label25.Location = new System.Drawing.Point(58, 505);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(164, 36);
            this.label25.TabIndex = 116;
            this.label25.Text = "Công suất:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Linen;
            this.label24.Location = new System.Drawing.Point(58, 441);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 36);
            this.label24.TabIndex = 70;
            this.label24.Text = "Tốc độ:";
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(233, 502);
            this.p2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(226, 44);
            this.p2.TabIndex = 114;
            // 
            // i2
            // 
            this.i2.Location = new System.Drawing.Point(233, 170);
            this.i2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.i2.Name = "i2";
            this.i2.Size = new System.Drawing.Size(226, 44);
            this.i2.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 36);
            this.label8.TabIndex = 94;
            this.label8.Text = "Khoa Cơ Khí";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(319, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(381, 36);
            this.label11.TabIndex = 92;
            this.label11.Text = "Trường đại học Nha Trang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1864, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 36);
            this.label9.TabIndex = 99;
            this.label9.Text = "Lớp:61CDT - MSSV:61132624";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1864, 210);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(404, 36);
            this.label13.TabIndex = 98;
            this.label13.Text = "Sinh Viên: Phan Thanh Nhật";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1864, 174);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(435, 36);
            this.label14.TabIndex = 97;
            this.label14.Text = "GVHD: ThS. Nguyễn Văn Định";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1864, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(376, 36);
            this.label19.TabIndex = 95;
            this.label19.Text = "Ngành: Kỹ thuật cơ điện tử";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::v2.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(362, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(927, 236);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(603, 67);
            this.label15.TabIndex = 112;
            this.label15.Text = "ĐỒ ÁN TỐT NGHIỆP";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // thoigian
            // 
            this.thoigian.Enabled = true;
            this.thoigian.Tick += new System.EventHandler(this.thoigian_Tick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2006, 246);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(278, 36);
            this.label21.TabIndex = 113;
            this.label21.Text = "Nguyễn Phú Thành";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(2144, 318);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 36);
            this.label26.TabIndex = 114;
            this.label26.Text = "61132594";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.TextBox txtAllData;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Button bcon;
        private System.Windows.Forms.Button t2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button t1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.TextBox i1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer thoigian;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtthoigian;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.TextBox i2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
    }
}

