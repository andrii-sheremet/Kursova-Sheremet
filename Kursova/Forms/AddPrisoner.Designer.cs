namespace Kursova
{
    partial class AddPrisoner
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
            groupBox10 = new GroupBox();
            haractField = new ComboBox();
            groupBox9 = new GroupBox();
            ierarhField = new ComboBox();
            groupBox8 = new GroupBox();
            statField = new ComboBox();
            groupBox4 = new GroupBox();
            checkNemaRod = new CheckBox();
            checkMama = new CheckBox();
            checkDad = new CheckBox();
            checkKid = new CheckBox();
            checkBro = new CheckBox();
            checkHusb = new CheckBox();
            groupBox5 = new GroupBox();
            statyaField = new ComboBox();
            groupBox3 = new GroupBox();
            DataUvyazTimePicker = new DateTimePicker();
            groupBox2 = new GroupBox();
            KamNum = new NumericUpDown();
            groupBox1 = new GroupBox();
            DataNarTimePicker = new DateTimePicker();
            groupBox11 = new GroupBox();
            label1 = new Label();
            termBar1 = new TrackBar();
            groupBox6 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            PBTextBox = new TextBox();
            label7 = new Label();
            PrizvTextBox = new TextBox();
            ImyaTextBox = new TextBox();
            DobButton = new Button();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KamNum).BeginInit();
            groupBox1.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)termBar1).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(haractField);
            groupBox10.Location = new Point(166, 144);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(126, 66);
            groupBox10.TabIndex = 28;
            groupBox10.TabStop = false;
            groupBox10.Text = "Особливості характеру";
            // 
            // haractField
            // 
            haractField.DropDownStyle = ComboBoxStyle.DropDownList;
            haractField.FormattingEnabled = true;
            haractField.Items.AddRange(new object[] { "Агресивний", "Спокійний", "Нестійкий", "Шістка" });
            haractField.Location = new Point(6, 34);
            haractField.Name = "haractField";
            haractField.Size = new Size(114, 23);
            haractField.TabIndex = 17;
            haractField.SelectedIndexChanged += HaractField_SelectedIndexChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(ierarhField);
            groupBox9.Location = new Point(298, 144);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(126, 66);
            groupBox9.TabIndex = 26;
            groupBox9.TabStop = false;
            groupBox9.Text = "Місце у ієрархії";
            // 
            // ierarhField
            // 
            ierarhField.DropDownStyle = ComboBoxStyle.DropDownList;
            ierarhField.FormattingEnabled = true;
            ierarhField.Items.AddRange(new object[] { "Блатні", "Мужики", "Козли", "Заполоскані", "Опущені" });
            ierarhField.Location = new Point(9, 34);
            ierarhField.Name = "ierarhField";
            ierarhField.Size = new Size(108, 23);
            ierarhField.TabIndex = 15;
            ierarhField.SelectedIndexChanged += IerarhField_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(statField);
            groupBox8.Location = new Point(12, 80);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(67, 57);
            groupBox8.TabIndex = 20;
            groupBox8.TabStop = false;
            groupBox8.Text = "Стать";
            // 
            // statField
            // 
            statField.DropDownStyle = ComboBoxStyle.DropDownList;
            statField.FormattingEnabled = true;
            statField.Items.AddRange(new object[] { "Ж", "М" });
            statField.Location = new Point(6, 22);
            statField.Name = "statField";
            statField.Size = new Size(51, 23);
            statField.TabIndex = 4;
            statField.SelectedIndexChanged += StatField_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkNemaRod);
            groupBox4.Controls.Add(checkMama);
            groupBox4.Controls.Add(checkDad);
            groupBox4.Controls.Add(checkKid);
            groupBox4.Controls.Add(checkBro);
            groupBox4.Controls.Add(checkHusb);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Location = new Point(166, 207);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(258, 62);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Живі родичі";
            // 
            // checkNemaRod
            // 
            checkNemaRod.AutoSize = true;
            checkNemaRod.FlatStyle = FlatStyle.System;
            checkNemaRod.Location = new Point(124, 33);
            checkNemaRod.Name = "checkNemaRod";
            checkNemaRod.Size = new Size(108, 20);
            checkNemaRod.TabIndex = 13;
            checkNemaRod.Text = "Нема родичів";
            checkNemaRod.UseVisualStyleBackColor = true;
            checkNemaRod.CheckedChanged += CheckNemaRod_CheckedChanged;
            // 
            // checkMama
            // 
            checkMama.AutoSize = true;
            checkMama.Location = new Point(6, 18);
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
            checkBro.Location = new Point(170, 17);
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
            // groupBox5
            // 
            groupBox5.Controls.Add(statyaField);
            groupBox5.Location = new Point(85, 80);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(75, 58);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Стаття";
            // 
            // statyaField
            // 
            statyaField.DropDownStyle = ComboBoxStyle.DropDownList;
            statyaField.FormattingEnabled = true;
            statyaField.Items.AddRange(new object[] { "ст. 115", "ст. 125", "ст. 122", "ст. 121", "ст. 156", "ст. 185", "ст. 152", "ст. 151", "ст. 126" });
            statyaField.Location = new Point(6, 23);
            statyaField.Name = "statyaField";
            statyaField.Size = new Size(59, 23);
            statyaField.TabIndex = 5;
            statyaField.SelectedIndexChanged += StatyaField_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DataUvyazTimePicker);
            groupBox3.Location = new Point(166, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(146, 58);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Дата ув'язнення";
            // 
            // DataUvyazTimePicker
            // 
            DataUvyazTimePicker.Location = new Point(6, 23);
            DataUvyazTimePicker.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            DataUvyazTimePicker.Name = "DataUvyazTimePicker";
            DataUvyazTimePicker.Size = new Size(120, 23);
            DataUvyazTimePicker.TabIndex = 2;
            DataUvyazTimePicker.Value = new DateTime(2023, 4, 4, 0, 0, 0, 0);
            DataUvyazTimePicker.ValueChanged += DataUvyazTimePicker_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(KamNum);
            groupBox2.Location = new Point(318, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(103, 58);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "№ Камери";
            // 
            // KamNum
            // 
            KamNum.Location = new Point(6, 20);
            KamNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            KamNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            KamNum.Name = "KamNum";
            KamNum.ReadOnly = true;
            KamNum.Size = new Size(91, 23);
            KamNum.TabIndex = 2;
            KamNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            KamNum.ValueChanged += KamNum_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataNarTimePicker);
            groupBox1.Location = new Point(12, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(148, 60);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дата народження";
            // 
            // DataNarTimePicker
            // 
            DataNarTimePicker.Location = new Point(6, 22);
            DataNarTimePicker.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            DataNarTimePicker.Name = "DataNarTimePicker";
            DataNarTimePicker.Size = new Size(121, 23);
            DataNarTimePicker.TabIndex = 3;
            DataNarTimePicker.Value = new DateTime(2023, 5, 29, 0, 0, 0, 0);
            DataNarTimePicker.ValueChanged += DataNarTimePicker_ValueChanged;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(label1);
            groupBox11.Controls.Add(termBar1);
            groupBox11.Location = new Point(12, 195);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(148, 74);
            groupBox11.TabIndex = 25;
            groupBox11.TabStop = false;
            groupBox11.Text = "Термін";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 22);
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
            // groupBox6
            // 
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(PBTextBox);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(PrizvTextBox);
            groupBox6.Controls.Add(ImyaTextBox);
            groupBox6.Location = new Point(12, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(409, 68);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "ПІБ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 19);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 6;
            label8.Text = "По батькові";
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
            PBTextBox.Name = "PBTextBox";
            PBTextBox.PlaceholderText = "По батькові";
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
            PrizvTextBox.Name = "PrizvTextBox";
            PrizvTextBox.PlaceholderText = "Прізвище";
            PrizvTextBox.Size = new Size(120, 23);
            PrizvTextBox.TabIndex = 1;
            PrizvTextBox.TextChanged += PrizvTextBox_TextChanged;
            // 
            // ImyaTextBox
            // 
            ImyaTextBox.Location = new Point(134, 37);
            ImyaTextBox.Name = "ImyaTextBox";
            ImyaTextBox.PlaceholderText = "Ім'я";
            ImyaTextBox.Size = new Size(130, 23);
            ImyaTextBox.TabIndex = 2;
            ImyaTextBox.TextChanged += ImyaTextBox_TextChanged;
            // 
            // DobButton
            // 
            DobButton.BackColor = SystemColors.ButtonFace;
            DobButton.FlatStyle = FlatStyle.Flat;
            DobButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DobButton.Location = new Point(112, 275);
            DobButton.Name = "DobButton";
            DobButton.Size = new Size(200, 48);
            DobButton.TabIndex = 30;
            DobButton.Text = "Додати";
            DobButton.UseVisualStyleBackColor = false;
            DobButton.Click += DobButton_Click;
            // 
            // AddPrisoner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(436, 328);
            Controls.Add(DobButton);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox11);
            Controls.Add(groupBox6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPrisoner";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додати в'язня";
            groupBox10.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)KamNum).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)termBar1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox10;
        public ComboBox haractField;
        private GroupBox groupBox9;
        public ComboBox ierarhField;
        private GroupBox groupBox8;
        public ComboBox statField;
        private GroupBox groupBox4;
        private CheckBox checkNemaRod;
        private CheckBox checkMama;
        private CheckBox checkDad;
        private CheckBox checkKid;
        private CheckBox checkBro;
        private CheckBox checkHusb;
        private GroupBox groupBox5;
        public ComboBox statyaField;
        private GroupBox groupBox3;
        public DateTimePicker DataUvyazTimePicker;
        private GroupBox groupBox2;
        public NumericUpDown KamNum;
        private GroupBox groupBox1;
        public DateTimePicker DataNarTimePicker;
        private GroupBox groupBox11;
        private Label label1;
        public TrackBar termBar1;
        private GroupBox groupBox6;
        private Label label8;
        private Label label6;
        public TextBox PBTextBox;
        private Label label7;
        public TextBox PrizvTextBox;
        public TextBox ImyaTextBox;
        private Button DobButton;
    }
}