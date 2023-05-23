namespace Kursova
{
    partial class DelViazn
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            delButton = new Button();
            form5BindingSource = new BindingSource(components);
            PIBField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)form5BindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(253, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(19, 23);
            comboBox1.TabIndex = 5;
            // 
            // delButton
            // 
            delButton.Location = new Point(55, 49);
            delButton.Name = "delButton";
            delButton.Size = new Size(186, 64);
            delButton.TabIndex = 4;
            delButton.Text = "Видалити";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // PIBField
            // 
            PIBField.Location = new Point(26, 20);
            PIBField.Name = "PIBField";
            PIBField.Size = new Size(221, 23);
            PIBField.TabIndex = 6;
            // 
            // DelViazn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 118);
            Controls.Add(comboBox1);
            Controls.Add(delButton);
            Controls.Add(PIBField);
            Name = "DelViazn";
            Text = "DelViazn";
            ((System.ComponentModel.ISupportInitialize)form5BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button delButton;
        private BindingSource form5BindingSource;
        private TextBox PIBField;
    }
}