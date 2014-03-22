namespace PredictiveCoder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadImgButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.codeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableRadio = new System.Windows.Forms.RadioButton();
            this.fixedRadio = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.predErrQRadio = new System.Windows.Forms.RadioButton();
            this.predErrRadio = new System.Windows.Forms.RadioButton();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.codedBox = new System.Windows.Forms.PictureBox();
            this.contrastBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveNLButton = new System.Windows.Forms.Button();
            this.loadNLButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computeErrorButton = new System.Windows.Forms.Button();
            this.decodedBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.histRefreshButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.histScaleTextBox = new System.Windows.Forms.TextBox();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.histPictureBox = new System.Windows.Forms.PictureBox();
            this.openImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codedBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decodedBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadImgButton
            // 
            this.loadImgButton.Location = new System.Drawing.Point(37, 12);
            this.loadImgButton.Name = "loadImgButton";
            this.loadImgButton.Size = new System.Drawing.Size(75, 23);
            this.loadImgButton.TabIndex = 1;
            this.loadImgButton.Text = "Load Image";
            this.loadImgButton.UseVisualStyleBackColor = true;
            this.loadImgButton.Click += new System.EventHandler(this.loadImgButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton0);
            this.groupBox2.Location = new System.Drawing.Point(22, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prediction method";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(15, 203);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 17);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "JPEG_LS";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(15, 180);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(62, 17);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "(A+B)/2";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 157);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(72, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "B+(A-C)/2";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 134);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "A+(B-C)/2";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 111);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A+B-C";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Location = new System.Drawing.Point(16, 19);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(43, 17);
            this.radioButton0.TabIndex = 2;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "128";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(37, 54);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 2;
            this.codeButton.Text = "Code";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableRadio);
            this.groupBox3.Controls.Add(this.fixedRadio);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 102);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saving";
            // 
            // tableRadio
            // 
            this.tableRadio.AutoSize = true;
            this.tableRadio.Location = new System.Drawing.Point(15, 42);
            this.tableRadio.Name = "tableRadio";
            this.tableRadio.Size = new System.Drawing.Size(52, 17);
            this.tableRadio.TabIndex = 4;
            this.tableRadio.TabStop = true;
            this.tableRadio.Text = "Table";
            this.tableRadio.UseVisualStyleBackColor = true;
            // 
            // fixedRadio
            // 
            this.fixedRadio.AutoSize = true;
            this.fixedRadio.Checked = true;
            this.fixedRadio.Location = new System.Drawing.Point(15, 19);
            this.fixedRadio.Name = "fixedRadio";
            this.fixedRadio.Size = new System.Drawing.Size(93, 17);
            this.fixedRadio.TabIndex = 4;
            this.fixedRadio.TabStop = true;
            this.fixedRadio.Text = "Fixed 9/16/32";
            this.fixedRadio.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 65);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.predErrQRadio);
            this.groupBox4.Controls.Add(this.predErrRadio);
            this.groupBox4.Controls.Add(this.refreshButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.codedBox);
            this.groupBox4.Controls.Add(this.contrastBox);
            this.groupBox4.Location = new System.Drawing.Point(485, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 288);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coded Image";
            // 
            // predErrQRadio
            // 
            this.predErrQRadio.AutoSize = true;
            this.predErrQRadio.Location = new System.Drawing.Point(284, 150);
            this.predErrQRadio.Name = "predErrQRadio";
            this.predErrQRadio.Size = new System.Drawing.Size(82, 17);
            this.predErrQRadio.TabIndex = 14;
            this.predErrQRadio.Text = "Pred error Q";
            this.predErrQRadio.UseVisualStyleBackColor = true;
            // 
            // predErrRadio
            // 
            this.predErrRadio.AutoSize = true;
            this.predErrRadio.Checked = true;
            this.predErrRadio.Location = new System.Drawing.Point(284, 126);
            this.predErrRadio.Name = "predErrRadio";
            this.predErrRadio.Size = new System.Drawing.Size(72, 17);
            this.predErrRadio.TabIndex = 13;
            this.predErrRadio.TabStop = true;
            this.predErrRadio.Text = "Pred Error";
            this.predErrRadio.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(291, 225);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contrast";
            // 
            // codedBox
            // 
            this.codedBox.Location = new System.Drawing.Point(19, 19);
            this.codedBox.Name = "codedBox";
            this.codedBox.Size = new System.Drawing.Size(256, 256);
            this.codedBox.TabIndex = 0;
            this.codedBox.TabStop = false;
            // 
            // contrastBox
            // 
            this.contrastBox.Location = new System.Drawing.Point(326, 192);
            this.contrastBox.Name = "contrastBox";
            this.contrastBox.Size = new System.Drawing.Size(48, 20);
            this.contrastBox.TabIndex = 9;
            this.contrastBox.Text = "1,3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.saveNLButton);
            this.groupBox5.Controls.Add(this.loadNLButton);
            this.groupBox5.Controls.Add(this.decodeButton);
            this.groupBox5.Controls.Add(this.maxBox);
            this.groupBox5.Controls.Add(this.minBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.computeErrorButton);
            this.groupBox5.Controls.Add(this.decodedBox);
            this.groupBox5.Location = new System.Drawing.Point(893, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 288);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decoded Image";
            // 
            // saveNLButton
            // 
            this.saveNLButton.Location = new System.Drawing.Point(289, 99);
            this.saveNLButton.Name = "saveNLButton";
            this.saveNLButton.Size = new System.Drawing.Size(75, 23);
            this.saveNLButton.TabIndex = 11;
            this.saveNLButton.Text = "Save";
            this.saveNLButton.UseVisualStyleBackColor = true;
            this.saveNLButton.Click += new System.EventHandler(this.saveNLButton_Click);
            // 
            // loadNLButton
            // 
            this.loadNLButton.Location = new System.Drawing.Point(289, 20);
            this.loadNLButton.Name = "loadNLButton";
            this.loadNLButton.Size = new System.Drawing.Size(75, 23);
            this.loadNLButton.TabIndex = 10;
            this.loadNLButton.Text = "Load";
            this.loadNLButton.UseVisualStyleBackColor = true;
            this.loadNLButton.Click += new System.EventHandler(this.loadNLButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(289, 59);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 9;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(305, 257);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(59, 20);
            this.maxBox.TabIndex = 5;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(305, 225);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(59, 20);
            this.minBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min";
            // 
            // computeErrorButton
            // 
            this.computeErrorButton.Location = new System.Drawing.Point(268, 186);
            this.computeErrorButton.Name = "computeErrorButton";
            this.computeErrorButton.Size = new System.Drawing.Size(96, 23);
            this.computeErrorButton.TabIndex = 1;
            this.computeErrorButton.Text = "Compute error";
            this.computeErrorButton.UseVisualStyleBackColor = true;
            this.computeErrorButton.Click += new System.EventHandler(this.computeErrorButton_Click);
            // 
            // decodedBox
            // 
            this.decodedBox.Location = new System.Drawing.Point(6, 19);
            this.decodedBox.Name = "decodedBox";
            this.decodedBox.Size = new System.Drawing.Size(256, 256);
            this.decodedBox.TabIndex = 0;
            this.decodedBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "K=";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(50, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.histRefreshButton);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.histScaleTextBox);
            this.groupBox6.Controls.Add(this.radioButton16);
            this.groupBox6.Controls.Add(this.radioButton13);
            this.groupBox6.Controls.Add(this.radioButton15);
            this.groupBox6.Controls.Add(this.radioButton14);
            this.groupBox6.Controls.Add(this.histPictureBox);
            this.groupBox6.Location = new System.Drawing.Point(188, 309);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(677, 341);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Histogram";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "-255";
            // 
            // histRefreshButton
            // 
            this.histRefreshButton.Location = new System.Drawing.Point(557, 187);
            this.histRefreshButton.Name = "histRefreshButton";
            this.histRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.histRefreshButton.TabIndex = 21;
            this.histRefreshButton.Text = "Refresh";
            this.histRefreshButton.UseVisualStyleBackColor = true;
            this.histRefreshButton.Click += new System.EventHandler(this.histRefreshButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Scale";
            // 
            // histScaleTextBox
            // 
            this.histScaleTextBox.Location = new System.Drawing.Point(581, 154);
            this.histScaleTextBox.Name = "histScaleTextBox";
            this.histScaleTextBox.Size = new System.Drawing.Size(59, 20);
            this.histScaleTextBox.TabIndex = 19;
            this.histScaleTextBox.Text = "0,3";
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(549, 111);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(100, 17);
            this.radioButton16.TabIndex = 18;
            this.radioButton16.Text = "Decoded image";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Location = new System.Drawing.Point(549, 42);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(91, 17);
            this.radioButton13.TabIndex = 17;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Original image";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(549, 88);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(108, 17);
            this.radioButton15.TabIndex = 16;
            this.radioButton15.Text = "Prediction Error Q";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(549, 65);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(97, 17);
            this.radioButton14.TabIndex = 15;
            this.radioButton14.Text = "Prediction Error";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // histPictureBox
            // 
            this.histPictureBox.Location = new System.Drawing.Point(20, 19);
            this.histPictureBox.Name = "histPictureBox";
            this.histPictureBox.Size = new System.Drawing.Size(512, 296);
            this.histPictureBox.TabIndex = 0;
            this.histPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 662);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.loadImgButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Near-lossless predictive coder";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codedBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decodedBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadImgButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton tableRadio;
        private System.Windows.Forms.RadioButton fixedRadio;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox contrastBox;
        private System.Windows.Forms.PictureBox codedBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button computeErrorButton;
        private System.Windows.Forms.PictureBox decodedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.OpenFileDialog openImgDialog;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton predErrQRadio;
        private System.Windows.Forms.RadioButton predErrRadio;
        private System.Windows.Forms.SaveFileDialog saveImgDialog;
        private System.Windows.Forms.Button saveNLButton;
        private System.Windows.Forms.Button loadNLButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button histRefreshButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox histScaleTextBox;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.PictureBox histPictureBox;
    }
}

