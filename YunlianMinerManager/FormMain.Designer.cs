namespace YunlianMinerManager
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxIP = new System.Windows.Forms.GroupBox();
            this.checkedListBoxIPRanges = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddIPRange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEndIP4 = new System.Windows.Forms.TextBox();
            this.textBoxEndIP3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartIP2 = new System.Windows.Forms.TextBox();
            this.textBoxStartIP4 = new System.Windows.Forms.TextBox();
            this.textBoxStartIP1 = new System.Windows.Forms.TextBox();
            this.textBoxStartIP3 = new System.Windows.Forms.TextBox();
            this.groupBoxMinerPools = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonScanMiners = new System.Windows.Forms.Button();
            this.buttonAutoScan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxIP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMinerPools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIP
            // 
            this.groupBoxIP.Controls.Add(this.checkedListBoxIPRanges);
            this.groupBoxIP.Controls.Add(this.buttonAutoScan);
            this.groupBoxIP.Controls.Add(this.textBox3);
            this.groupBoxIP.Controls.Add(this.panel1);
            this.groupBoxIP.Controls.Add(this.label9);
            this.groupBoxIP.Controls.Add(this.buttonScanMiners);
            this.groupBoxIP.Location = new System.Drawing.Point(8, 5);
            this.groupBoxIP.Name = "groupBoxIP";
            this.groupBoxIP.Size = new System.Drawing.Size(285, 121);
            this.groupBoxIP.TabIndex = 0;
            this.groupBoxIP.TabStop = false;
            this.groupBoxIP.Text = "IP段";
            // 
            // checkedListBoxIPRanges
            // 
            this.checkedListBoxIPRanges.FormattingEnabled = true;
            this.checkedListBoxIPRanges.Items.AddRange(new object[] {
            "192.168.1.1-255",
            "192.168.2.1-255",
            "192.168.3.1-255"});
            this.checkedListBoxIPRanges.Location = new System.Drawing.Point(5, 49);
            this.checkedListBoxIPRanges.Name = "checkedListBoxIPRanges";
            this.checkedListBoxIPRanges.Size = new System.Drawing.Size(139, 68);
            this.checkedListBoxIPRanges.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddIPRange);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxEndIP4);
            this.panel1.Controls.Add(this.textBoxEndIP3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxStartIP2);
            this.panel1.Controls.Add(this.textBoxStartIP4);
            this.panel1.Controls.Add(this.textBoxStartIP1);
            this.panel1.Controls.Add(this.textBoxStartIP3);
            this.panel1.Location = new System.Drawing.Point(5, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 30);
            this.panel1.TabIndex = 4;
            // 
            // buttonAddIPRange
            // 
            this.buttonAddIPRange.Location = new System.Drawing.Point(249, 3);
            this.buttonAddIPRange.Name = "buttonAddIPRange";
            this.buttonAddIPRange.Size = new System.Drawing.Size(24, 23);
            this.buttonAddIPRange.TabIndex = 15;
            this.buttonAddIPRange.Text = "+";
            this.buttonAddIPRange.UseVisualStyleBackColor = true;
            this.buttonAddIPRange.Click += new System.EventHandler(this.buttonAddIPRange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // textBoxEndIP4
            // 
            this.textBoxEndIP4.Location = new System.Drawing.Point(217, 4);
            this.textBoxEndIP4.Name = "textBoxEndIP4";
            this.textBoxEndIP4.Size = new System.Drawing.Size(32, 21);
            this.textBoxEndIP4.TabIndex = 11;
            this.textBoxEndIP4.Text = "255";
            // 
            // textBoxEndIP3
            // 
            this.textBoxEndIP3.Location = new System.Drawing.Point(174, 4);
            this.textBoxEndIP3.Name = "textBoxEndIP3";
            this.textBoxEndIP3.Size = new System.Drawing.Size(32, 21);
            this.textBoxEndIP3.TabIndex = 10;
            this.textBoxEndIP3.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // textBoxStartIP2
            // 
            this.textBoxStartIP2.Location = new System.Drawing.Point(45, 4);
            this.textBoxStartIP2.Name = "textBoxStartIP2";
            this.textBoxStartIP2.Size = new System.Drawing.Size(32, 21);
            this.textBoxStartIP2.TabIndex = 1;
            this.textBoxStartIP2.Text = "168";
            // 
            // textBoxStartIP4
            // 
            this.textBoxStartIP4.Location = new System.Drawing.Point(131, 4);
            this.textBoxStartIP4.Name = "textBoxStartIP4";
            this.textBoxStartIP4.Size = new System.Drawing.Size(32, 21);
            this.textBoxStartIP4.TabIndex = 3;
            this.textBoxStartIP4.Text = "1";
            // 
            // textBoxStartIP1
            // 
            this.textBoxStartIP1.Location = new System.Drawing.Point(2, 4);
            this.textBoxStartIP1.Name = "textBoxStartIP1";
            this.textBoxStartIP1.Size = new System.Drawing.Size(32, 21);
            this.textBoxStartIP1.TabIndex = 0;
            this.textBoxStartIP1.Text = "192";
            // 
            // textBoxStartIP3
            // 
            this.textBoxStartIP3.Location = new System.Drawing.Point(88, 4);
            this.textBoxStartIP3.Name = "textBoxStartIP3";
            this.textBoxStartIP3.Size = new System.Drawing.Size(32, 21);
            this.textBoxStartIP3.TabIndex = 2;
            this.textBoxStartIP3.Text = "1";
            // 
            // groupBoxMinerPools
            // 
            this.groupBoxMinerPools.Controls.Add(this.button12);
            this.groupBoxMinerPools.Controls.Add(this.button11);
            this.groupBoxMinerPools.Controls.Add(this.button2);
            this.groupBoxMinerPools.Controls.Add(this.comboBox4);
            this.groupBoxMinerPools.Controls.Add(this.button1);
            this.groupBoxMinerPools.Controls.Add(this.label20);
            this.groupBoxMinerPools.Controls.Add(this.checkBox3);
            this.groupBoxMinerPools.Controls.Add(this.textBox11);
            this.groupBoxMinerPools.Controls.Add(this.label16);
            this.groupBoxMinerPools.Controls.Add(this.comboBox3);
            this.groupBoxMinerPools.Controls.Add(this.label17);
            this.groupBoxMinerPools.Controls.Add(this.textBox12);
            this.groupBoxMinerPools.Controls.Add(this.label18);
            this.groupBoxMinerPools.Controls.Add(this.textBox13);
            this.groupBoxMinerPools.Controls.Add(this.label19);
            this.groupBoxMinerPools.Controls.Add(this.textBox14);
            this.groupBoxMinerPools.Controls.Add(this.checkBox2);
            this.groupBoxMinerPools.Controls.Add(this.textBox7);
            this.groupBoxMinerPools.Controls.Add(this.label4);
            this.groupBoxMinerPools.Controls.Add(this.comboBox2);
            this.groupBoxMinerPools.Controls.Add(this.label13);
            this.groupBoxMinerPools.Controls.Add(this.textBox8);
            this.groupBoxMinerPools.Controls.Add(this.label14);
            this.groupBoxMinerPools.Controls.Add(this.textBox9);
            this.groupBoxMinerPools.Controls.Add(this.label15);
            this.groupBoxMinerPools.Controls.Add(this.textBox10);
            this.groupBoxMinerPools.Controls.Add(this.checkBox1);
            this.groupBoxMinerPools.Controls.Add(this.textBox6);
            this.groupBoxMinerPools.Controls.Add(this.label12);
            this.groupBoxMinerPools.Controls.Add(this.comboBox1);
            this.groupBoxMinerPools.Controls.Add(this.label11);
            this.groupBoxMinerPools.Controls.Add(this.textBox5);
            this.groupBoxMinerPools.Controls.Add(this.label10);
            this.groupBoxMinerPools.Controls.Add(this.textBox2);
            this.groupBoxMinerPools.Controls.Add(this.label8);
            this.groupBoxMinerPools.Controls.Add(this.textBox1);
            this.groupBoxMinerPools.Location = new System.Drawing.Point(297, 5);
            this.groupBoxMinerPools.Name = "groupBoxMinerPools";
            this.groupBoxMinerPools.Size = new System.Drawing.Size(714, 116);
            this.groupBoxMinerPools.TabIndex = 2;
            this.groupBoxMinerPools.TabStop = false;
            this.groupBoxMinerPools.Text = "矿池";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "ljy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "矿工名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "bitcoin.viabtc.com:3333";
            // 
            // buttonScanMiners
            // 
            this.buttonScanMiners.Location = new System.Drawing.Point(147, 49);
            this.buttonScanMiners.Name = "buttonScanMiners";
            this.buttonScanMiners.Size = new System.Drawing.Size(39, 23);
            this.buttonScanMiners.TabIndex = 1;
            this.buttonScanMiners.Text = "扫描";
            this.buttonScanMiners.UseVisualStyleBackColor = true;
            // 
            // buttonAutoScan
            // 
            this.buttonAutoScan.Location = new System.Drawing.Point(227, 74);
            this.buttonAutoScan.Name = "buttonAutoScan";
            this.buttonAutoScan.Size = new System.Drawing.Size(45, 23);
            this.buttonAutoScan.TabIndex = 2;
            this.buttonAutoScan.Text = "监控";
            this.buttonAutoScan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "间隔秒";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(189, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "120";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 169);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(813, 47);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(472, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(59, 21);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "密码";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "后缀";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IP",
            "不变",
            "无"});
            this.comboBox1.Location = new System.Drawing.Point(560, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "IP替代符";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(675, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 21);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "x";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "矿池1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 16);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "矿池1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(675, 66);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 21);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "IP替代符";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "IP",
            "不变",
            "无"});
            this.comboBox2.Location = new System.Drawing.Point(560, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 20);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "IP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "后缀";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(472, 66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(59, 21);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "123";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "密码";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(343, 66);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 13;
            this.textBox9.Text = "ljy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "矿工名";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(61, 66);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(241, 21);
            this.textBox10.TabIndex = 11;
            this.textBox10.Text = "bitcoin.viabtc.com:3333";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 16);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "矿池1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(675, 90);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 21);
            this.textBox11.TabIndex = 29;
            this.textBox11.Text = "x";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(622, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "IP替代符";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "IP",
            "不变",
            "无"});
            this.comboBox3.Location = new System.Drawing.Point(560, 90);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(62, 20);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.Text = "IP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(531, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 26;
            this.label17.Text = "后缀";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(472, 90);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(59, 21);
            this.textBox12.TabIndex = 25;
            this.textBox12.Text = "123";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(443, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 24;
            this.label18.Text = "密码";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(343, 90);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 23;
            this.textBox13.Text = "ljy";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(302, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "矿工名";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(61, 90);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(241, 21);
            this.textBox14.TabIndex = 21;
            this.textBox14.Text = "bitcoin.viabtc.com:3333";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 31;
            this.label20.Text = "模板";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(37, 14);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(239, 20);
            this.comboBox4.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "配置矿池";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "重启矿机";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "机房";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(35, 13);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(43, 21);
            this.textBox15.TabIndex = 1;
            this.textBox15.Text = "YJ1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(98, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "机架";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(127, 13);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(33, 21);
            this.textBox16.TabIndex = 3;
            this.textBox16.Text = "A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(180, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 4;
            this.label23.Text = "层数";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(209, 13);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(42, 21);
            this.textBox17.TabIndex = 5;
            this.textBox17.Text = "01";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(271, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 6;
            this.label24.Text = "位置";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(300, 13);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(41, 21);
            this.textBox18.TabIndex = 7;
            this.textBox18.Text = "01";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(361, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 8;
            this.label25.Text = "矿工子名";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(414, 13);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 21);
            this.textBox19.TabIndex = 9;
            this.textBox19.Text = "YJ1-A-01-01";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(341, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(514, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "监听IP";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(572, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "点亮指示灯";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(657, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(77, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "熄灭指示灯";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(734, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "设置位置";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(444, 15);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "提升算力";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(525, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "还原";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Location = new System.Drawing.Point(10, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 39);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "上架";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 887);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBoxIP);
            this.Controls.Add(this.groupBoxMinerPools);
            this.Name = "FormMain";
            this.Text = "云链矿场管理系统";
            this.groupBoxIP.ResumeLayout(false);
            this.groupBoxIP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMinerPools.ResumeLayout(false);
            this.groupBoxMinerPools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIP;
        private System.Windows.Forms.CheckedListBox checkedListBoxIPRanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddIPRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEndIP4;
        private System.Windows.Forms.TextBox textBoxEndIP3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartIP2;
        private System.Windows.Forms.TextBox textBoxStartIP4;
        private System.Windows.Forms.TextBox textBoxStartIP1;
        private System.Windows.Forms.TextBox textBoxStartIP3;
        private System.Windows.Forms.GroupBox groupBoxMinerPools;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAutoScan;
        private System.Windows.Forms.Button buttonScanMiners;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

