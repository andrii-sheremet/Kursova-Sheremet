namespace Kursova
{
    partial class Form2
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
            button1 = new Button();
            PasswordField = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(110, 100);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(110, 43);
            PasswordField.MaxLength = 4;
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "Пароль";
            PasswordField.Size = new Size(80, 33);
            PasswordField.TabIndex = 1;
            PasswordField.TextAlign = HorizontalAlignment.Center;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 2;
            label1.Text = "Введіть код доступу";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(label1);
            Controls.Add(PasswordField);
            Controls.Add(button1);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox PasswordField;
        private Label label1;
    }
}