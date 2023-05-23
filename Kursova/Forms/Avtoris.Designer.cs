namespace Kursova
{
    partial class Avtoris
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
            label1 = new Label();
            PasswordField = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 5;
            label1.Text = "Введіть код доступу";
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(61, 47);
            PasswordField.MaxLength = 4;
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '*';
            PasswordField.PlaceholderText = "Пароль";
            PasswordField.Size = new Size(80, 33);
            PasswordField.TabIndex = 4;
            PasswordField.TextAlign = HorizontalAlignment.Center;
            PasswordField.TextChanged += PasswordField_TextChanged;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(61, 97);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(80, 30);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // Avtoris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(201, 142);
            Controls.Add(label1);
            Controls.Add(PasswordField);
            Controls.Add(buttonOk);
            Name = "Avtoris";
            Text = "Avtoris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PasswordField;
        private Button buttonOk;
    }
}