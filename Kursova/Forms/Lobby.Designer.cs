namespace Kursova
{
    partial class Lobby
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            groupBox9 = new GroupBox();
            ierarhField = new ComboBox();
            label12 = new Label();
            label4 = new Label();
            checkDataUvyaz = new CheckBox();
            label5 = new Label();
            DataUvyazTimePicker = new DateTimePicker();
            checkKamNum = new CheckBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            checkNemaRod = new CheckBox();
            label9 = new Label();
            checkMama = new CheckBox();
            checkDad = new CheckBox();
            checkKid = new CheckBox();
            checkBro = new CheckBox();
            checkHusb = new CheckBox();
            KamNum = new NumericUpDown();
            groupBox8 = new GroupBox();
            statField = new ComboBox();
            label11 = new Label();
            checkDataNar = new CheckBox();
            zbrosButton = new Button();
            groupBox10 = new GroupBox();
            haractField = new ComboBox();
            label13 = new Label();
            label2 = new Label();
            statyaField = new ComboBox();
            groupBox7 = new GroupBox();
            labelSum = new Label();
            groupBox11 = new GroupBox();
            checkTerm = new CheckBox();
            label1 = new Label();
            termBar1 = new TrackBar();
            label10 = new Label();
            groupBox1 = new GroupBox();
            DataNarTimePicker = new DateTimePicker();
            groupBox6 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            PBTextBox = new TextBox();
            label7 = new Label();
            PrizvTextBox = new TextBox();
            ImyaTextBox = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            findButton = new Button();
            splitContainer1 = new SplitContainer();
            exceptionPanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            splitter1 = new Splitter();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            DobPerson = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            groupBox9.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KamNum).BeginInit();
            groupBox8.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)termBar1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            exceptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Anchor = AnchorStyles.None;
            groupBox9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox9.Controls.Add(ierarhField);
            groupBox9.Controls.Add(label12);
            groupBox9.Location = new Point(222, 229);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(201, 47);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Місце у ієрархії";
            // 
            // ierarhField
            // 
            ierarhField.DropDownStyle = ComboBoxStyle.DropDownList;
            ierarhField.FormattingEnabled = true;
            ierarhField.Items.AddRange(new object[] { "-", "Блатні", "Мужики", "Козли", "Заполоскані", "Опущені" });
            ierarhField.Location = new Point(6, 18);
            ierarhField.Name = "ierarhField";
            ierarhField.Size = new Size(143, 23);
            ierarhField.TabIndex = 15;
            ierarhField.SelectedIndexChanged += IerarhField_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlDark;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(156, 23);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 4;
            label12.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(80, 27);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // checkDataUvyaz
            // 
            checkDataUvyaz.AutoSize = true;
            checkDataUvyaz.Checked = true;
            checkDataUvyaz.CheckState = CheckState.Checked;
            checkDataUvyaz.Location = new Point(6, 53);
            checkDataUvyaz.Name = "checkDataUvyaz";
            checkDataUvyaz.Size = new Size(72, 19);
            checkDataUvyaz.TabIndex = 1;
            checkDataUvyaz.Text = "Будь яке";
            checkDataUvyaz.UseVisualStyleBackColor = true;
            checkDataUvyaz.CheckedChanged += CheckDataUvyaz_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(155, 28);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 3;
            label5.Text = "0";
            // 
            // DataUvyazTimePicker
            // 
            DataUvyazTimePicker.Location = new Point(6, 24);
            DataUvyazTimePicker.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            DataUvyazTimePicker.Name = "DataUvyazTimePicker";
            DataUvyazTimePicker.Size = new Size(143, 23);
            DataUvyazTimePicker.TabIndex = 2;
            DataUvyazTimePicker.Value = new DateTime(2023, 4, 4, 0, 0, 0, 0);
            DataUvyazTimePicker.ValueChanged += DataUvyazTimePicker_ValueChanged;
            // 
            // checkKamNum
            // 
            checkKamNum.AutoSize = true;
            checkKamNum.Checked = true;
            checkKamNum.CheckState = CheckState.Checked;
            checkKamNum.Location = new Point(123, 21);
            checkKamNum.Name = "checkKamNum";
            checkKamNum.Size = new Size(42, 19);
            checkKamNum.TabIndex = 1;
            checkKamNum.Text = "Усі";
            checkKamNum.UseVisualStyleBackColor = true;
            checkKamNum.CheckedChanged += CheckKamNum_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(171, 22);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(checkNemaRod);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(checkMama);
            groupBox4.Controls.Add(checkDad);
            groupBox4.Controls.Add(checkKid);
            groupBox4.Controls.Add(checkBro);
            groupBox4.Controls.Add(checkHusb);
            groupBox4.Location = new Point(222, 155);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(201, 75);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Живі родичі";
            // 
            // checkNemaRod
            // 
            checkNemaRod.AutoSize = true;
            checkNemaRod.FlatStyle = FlatStyle.System;
            checkNemaRod.Location = new Point(50, 49);
            checkNemaRod.Name = "checkNemaRod";
            checkNemaRod.Size = new Size(108, 20);
            checkNemaRod.TabIndex = 13;
            checkNemaRod.Text = "Нема родичів";
            checkNemaRod.UseVisualStyleBackColor = true;
            checkNemaRod.CheckedChanged += CheckNemaRod_CheckedChanged;
            // 
            // label9
            // 
            label9.FlatStyle = FlatStyle.System;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(174, -6);
            label9.Name = "label9";
            label9.Size = new Size(19, 21);
            label9.TabIndex = 11;
            label9.Text = "x";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += Label9_Click;
            // 
            // checkMama
            // 
            checkMama.AutoSize = true;
            checkMama.Location = new Point(6, 17);
            checkMama.Name = "checkMama";
            checkMama.Size = new Size(55, 19);
            checkMama.TabIndex = 8;
            checkMama.Text = "Мати";
            checkMama.UseVisualStyleBackColor = true;
            checkMama.CheckedChanged += CheckMama_CheckedChanged;
            // 
            // checkDad
            // 
            checkDad.AutoSize = true;
            checkDad.Location = new Point(61, 17);
            checkDad.Name = "checkDad";
            checkDad.Size = new Size(63, 19);
            checkDad.TabIndex = 9;
            checkDad.Text = "Батько";
            checkDad.UseVisualStyleBackColor = true;
            checkDad.CheckedChanged += CheckDad_CheckedChanged;
            // 
            // checkKid
            // 
            checkKid.AutoSize = true;
            checkKid.Location = new Point(124, 17);
            checkKid.Name = "checkKid";
            checkKid.Size = new Size(49, 19);
            checkKid.TabIndex = 10;
            checkKid.Text = "Діти";
            checkKid.UseVisualStyleBackColor = true;
            checkKid.CheckedChanged += CheckKid_CheckedChanged;
            // 
            // checkBro
            // 
            checkBro.AutoSize = true;
            checkBro.FlatStyle = FlatStyle.System;
            checkBro.Location = new Point(110, 33);
            checkBro.Name = "checkBro";
            checkBro.Size = new Size(100, 20);
            checkBro.TabIndex = 12;
            checkBro.Text = "Брат/Сестра";
            checkBro.UseVisualStyleBackColor = true;
            checkBro.CheckedChanged += CheckBro_CheckedChanged;
            // 
            // checkHusb
            // 
            checkHusb.AutoSize = true;
            checkHusb.Location = new Point(6, 34);
            checkHusb.Name = "checkHusb";
            checkHusb.Size = new Size(108, 19);
            checkHusb.TabIndex = 11;
            checkHusb.Text = "Чоловік/Жінка";
            checkHusb.UseVisualStyleBackColor = true;
            checkHusb.CheckedChanged += CheckHusb_CheckedChanged;
            // 
            // KamNum
            // 
            KamNum.Location = new Point(6, 20);
            KamNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            KamNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            KamNum.Name = "KamNum";
            KamNum.ReadOnly = true;
            KamNum.Size = new Size(104, 23);
            KamNum.TabIndex = 2;
            KamNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            KamNum.ValueChanged += KamNum_ValueChanged;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.None;
            groupBox8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox8.Controls.Add(statField);
            groupBox8.Controls.Add(label11);
            groupBox8.Location = new Point(14, 75);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(88, 58);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Стать";
            // 
            // statField
            // 
            statField.DropDownStyle = ComboBoxStyle.DropDownList;
            statField.FormattingEnabled = true;
            statField.Items.AddRange(new object[] { "Усі", "М", "Ж" });
            statField.Location = new Point(5, 22);
            statField.Name = "statField";
            statField.Size = new Size(51, 23);
            statField.TabIndex = 4;
            statField.SelectedIndexChanged += StatField_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlDark;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(59, 27);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 3;
            label11.Text = "0";
            // 
            // checkDataNar
            // 
            checkDataNar.AutoSize = true;
            checkDataNar.Checked = true;
            checkDataNar.CheckState = CheckState.Checked;
            checkDataNar.Location = new Point(6, 50);
            checkDataNar.Name = "checkDataNar";
            checkDataNar.Size = new Size(72, 19);
            checkDataNar.TabIndex = 2;
            checkDataNar.Text = "Будь яке";
            checkDataNar.UseVisualStyleBackColor = true;
            checkDataNar.CheckedChanged += CheckDataNar_CheckedChanged;
            // 
            // zbrosButton
            // 
            zbrosButton.Anchor = AnchorStyles.None;
            zbrosButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zbrosButton.BackColor = SystemColors.ControlDark;
            zbrosButton.FlatStyle = FlatStyle.Flat;
            zbrosButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            zbrosButton.Location = new Point(305, 341);
            zbrosButton.Name = "zbrosButton";
            zbrosButton.Size = new Size(118, 49);
            zbrosButton.TabIndex = 19;
            zbrosButton.Text = "Перезапустити";
            zbrosButton.UseVisualStyleBackColor = false;
            zbrosButton.Click += ZbrosButton_Click;
            // 
            // groupBox10
            // 
            groupBox10.Anchor = AnchorStyles.None;
            groupBox10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox10.Controls.Add(haractField);
            groupBox10.Controls.Add(label13);
            groupBox10.Location = new Point(222, 277);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(201, 59);
            groupBox10.TabIndex = 10;
            groupBox10.TabStop = false;
            groupBox10.Text = "Особливості характеру";
            // 
            // haractField
            // 
            haractField.DropDownStyle = ComboBoxStyle.DropDownList;
            haractField.FormattingEnabled = true;
            haractField.Items.AddRange(new object[] { "-", "Агресивний", "Спокійний", "Нестійкий", "Шістка" });
            haractField.Location = new Point(7, 22);
            haractField.Name = "haractField";
            haractField.Size = new Size(143, 23);
            haractField.TabIndex = 17;
            haractField.SelectedIndexChanged += HaractField_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlDark;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(156, 25);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 4;
            label13.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(171, 30);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // statyaField
            // 
            statyaField.DropDownStyle = ComboBoxStyle.DropDownList;
            statyaField.FormattingEnabled = true;
            statyaField.Items.AddRange(new object[] { "-", "ст. 115", "ст. 125", "ст. 122", "ст. 121", "ст. 156", "ст. 185", "ст. 152", "ст. 151", "ст. 126" });
            statyaField.Location = new Point(6, 23);
            statyaField.Name = "statyaField";
            statyaField.Size = new Size(71, 23);
            statyaField.TabIndex = 5;
            statyaField.SelectedIndexChanged += StatyaField_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.None;
            groupBox7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox7.Controls.Add(labelSum);
            groupBox7.Location = new Point(222, 334);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(77, 56);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Усього";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.BackColor = SystemColors.ControlDark;
            labelSum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSum.ForeColor = Color.DarkGreen;
            labelSum.Location = new Point(24, 20);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(19, 21);
            labelSum.TabIndex = 6;
            labelSum.Text = "0";
            // 
            // groupBox11
            // 
            groupBox11.Anchor = AnchorStyles.None;
            groupBox11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox11.Controls.Add(checkTerm);
            groupBox11.Controls.Add(label1);
            groupBox11.Controls.Add(termBar1);
            groupBox11.Controls.Add(label10);
            groupBox11.Location = new Point(14, 205);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(200, 71);
            groupBox11.TabIndex = 7;
            groupBox11.TabStop = false;
            groupBox11.Text = "Термін";
            // 
            // checkTerm
            // 
            checkTerm.AutoSize = true;
            checkTerm.Checked = true;
            checkTerm.CheckState = CheckState.Checked;
            checkTerm.Location = new Point(123, 25);
            checkTerm.Name = "checkTerm";
            checkTerm.Size = new Size(45, 19);
            checkTerm.TabIndex = 1;
            checkTerm.Text = "Усе";
            checkTerm.UseVisualStyleBackColor = true;
            checkTerm.CheckedChanged += CheckTerm_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "1 рік";
            // 
            // termBar1
            // 
            termBar1.Location = new Point(6, 22);
            termBar1.Maximum = 6;
            termBar1.Minimum = 1;
            termBar1.Name = "termBar1";
            termBar1.Size = new Size(104, 45);
            termBar1.SmallChange = 2;
            termBar1.TabIndex = 2;
            termBar1.Value = 1;
            termBar1.Scroll += TermBar1_Scroll;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDark;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(171, 29);
            label10.Name = "label10";
            label10.Size = new Size(14, 15);
            label10.TabIndex = 1;
            label10.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(checkDataNar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(DataNarTimePicker);
            groupBox1.Location = new Point(14, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 77);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дата народження";
            // 
            // DataNarTimePicker
            // 
            DataNarTimePicker.Location = new Point(6, 24);
            DataNarTimePicker.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            DataNarTimePicker.Name = "DataNarTimePicker";
            DataNarTimePicker.Size = new Size(154, 23);
            DataNarTimePicker.TabIndex = 3;
            DataNarTimePicker.Value = new DateTime(2023, 4, 4, 0, 0, 0, 0);
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.None;
            groupBox6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(PBTextBox);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(PrizvTextBox);
            groupBox6.Controls.Add(ImyaTextBox);
            groupBox6.Location = new Point(14, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(409, 66);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "ПІБ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 19);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 6;
            label8.Text = "Побатькові";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 4;
            label6.Text = "Прізвище";
            // 
            // PBTextBox
            // 
            PBTextBox.Location = new Point(272, 37);
            PBTextBox.MaxLength = 100;
            PBTextBox.Name = "PBTextBox";
            PBTextBox.PlaceholderText = "Побатькові";
            PBTextBox.Size = new Size(131, 23);
            PBTextBox.TabIndex = 3;
            PBTextBox.TextChanged += PBTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 19);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 5;
            label7.Text = "Ім'я";
            // 
            // PrizvTextBox
            // 
            PrizvTextBox.AcceptsTab = true;
            PrizvTextBox.Location = new Point(6, 37);
            PrizvTextBox.MaxLength = 100;
            PrizvTextBox.Name = "PrizvTextBox";
            PrizvTextBox.PlaceholderText = "Прізвище";
            PrizvTextBox.Size = new Size(120, 23);
            PrizvTextBox.TabIndex = 1;
            PrizvTextBox.TextChanged += PrizvTextBox_TextChanged;
            // 
            // ImyaTextBox
            // 
            ImyaTextBox.Location = new Point(134, 37);
            ImyaTextBox.MaxLength = 100;
            ImyaTextBox.Name = "ImyaTextBox";
            ImyaTextBox.PlaceholderText = "Ім'я";
            ImyaTextBox.Size = new Size(130, 23);
            ImyaTextBox.TabIndex = 2;
            ImyaTextBox.TextChanged += ImyaTextBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(checkKamNum);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(KamNum);
            groupBox2.Location = new Point(14, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 59);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "№ Камери";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(checkDataUvyaz);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(DataUvyazTimePicker);
            groupBox3.Location = new Point(221, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 74);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Дата ув'язнення";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.None;
            groupBox5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox5.Controls.Add(statyaField);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(105, 75);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(108, 58);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Стаття";
            // 
            // findButton
            // 
            findButton.Anchor = AnchorStyles.None;
            findButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            findButton.BackColor = SystemColors.ButtonFace;
            findButton.FlatStyle = FlatStyle.Flat;
            findButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            findButton.Location = new Point(14, 342);
            findButton.Name = "findButton";
            findButton.Size = new Size(200, 48);
            findButton.TabIndex = 18;
            findButton.Text = "Пошук";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += findButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(exceptionPanel);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(splitter1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AllowDrop = true;
            splitContainer1.Panel2.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel2.Controls.Add(zbrosButton);
            splitContainer1.Panel2.Controls.Add(groupBox10);
            splitContainer1.Panel2.Controls.Add(groupBox9);
            splitContainer1.Panel2.Controls.Add(groupBox8);
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Panel2.Controls.Add(groupBox7);
            splitContainer1.Panel2.Controls.Add(groupBox5);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(groupBox11);
            splitContainer1.Panel2.Controls.Add(groupBox6);
            splitContainer1.Panel2.Controls.Add(findButton);
            splitContainer1.Size = new Size(988, 399);
            splitContainer1.SplitterDistance = 550;
            splitContainer1.TabIndex = 1;
            // 
            // exceptionPanel
            // 
            exceptionPanel.Anchor = AnchorStyles.None;
            exceptionPanel.Controls.Add(label15);
            exceptionPanel.Controls.Add(label14);
            exceptionPanel.Location = new Point(113, 142);
            exceptionPanel.Name = "exceptionPanel";
            exceptionPanel.Size = new Size(300, 97);
            exceptionPanel.TabIndex = 13;
            exceptionPanel.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 26);
            label15.Name = "label15";
            label15.Size = new Size(22, 32);
            label15.TabIndex = 13;
            label15.Text = "!";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(31, 26);
            label14.Name = "label14";
            label14.Size = new Size(269, 40);
            label14.TabIndex = 0;
            label14.Text = "У базі даних в'язниці нема людини \r\nзі схожими ознаками";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(547, 399);
            dataGridView1.TabIndex = 1;
            dataGridView1.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 399);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(23, 23);
            // 
            // DobPerson
            // 
            DobPerson.Name = "DobPerson";
            DobPerson.Size = new Size(23, 23);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(23, 23);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(23, 23);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(988, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(86, 22);
            toolStripButton1.Text = "Додати в'язня";
            toolStripButton1.Click += AddPrisoner_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(99, 22);
            toolStripButton2.Text = "Видалити в'язня";
            toolStripButton2.Click += RemovePrisoner_Click;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 424);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(878, 406);
            Name = "Lobby";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник начальника в'язниці";
            FormClosed += Lobby_FormClosed;
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KamNum).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)termBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            exceptionPanel.ResumeLayout(false);
            exceptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private GroupBox groupBox9;
        public ComboBox ierarhField;
        public Label label12;
        public Label label4;
        private CheckBox checkDataUvyaz;
        public Label label5;
        public DateTimePicker DataUvyazTimePicker;
        private CheckBox checkKamNum;
        public Label label3;
        private GroupBox groupBox4;
        private CheckBox checkNemaRod;
        private Label label9;
        private CheckBox checkMama;
        private CheckBox checkDad;
        private CheckBox checkKid;
        private CheckBox checkBro;
        private CheckBox checkHusb;
        public NumericUpDown KamNum;
        private GroupBox groupBox8;
        public ComboBox statField;
        public Label label11;
        private CheckBox checkDataNar;
        private Button zbrosButton;
        private GroupBox groupBox10;
        public ComboBox haractField;
        public Label label13;
        public Label label2;
        public ComboBox statyaField;
        private GroupBox groupBox7;
        private Label labelSum;
        private GroupBox groupBox11;
        private CheckBox checkTerm;
        private Label label1;
        public TrackBar termBar1;
        public Label label10;
        private GroupBox groupBox1;
        public DateTimePicker DataNarTimePicker;
        private GroupBox groupBox6;
        private Label label8;
        private Label label6;
        public TextBox PBTextBox;
        private Label label7;
        public TextBox PrizvTextBox;
        public TextBox ImyaTextBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Button findButton;
        private SplitContainer splitContainer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel DobPerson;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Panel exceptionPanel;
        private Label label15;
        private Label label14;
        private Splitter splitter1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        public DataGridView dataGridView1;
    }
}