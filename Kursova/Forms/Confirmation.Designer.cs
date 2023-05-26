namespace Kursova
{
    partial class Confirmation
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
            button1 = new Button();
            button2 = new Button();
            Prizon = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 42);
            label1.TabIndex = 0;
            label1.Text = "Чи згодні ви стерти з бази даних \r\nцього в'язня без можливості повернення.\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(63, 88);
            button1.Name = "button1";
            button1.Size = new Size(84, 26);
            button1.TabIndex = 1;
            button1.Text = "Так";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 88);
            button2.Name = "button2";
            button2.Size = new Size(84, 26);
            button2.TabIndex = 2;
            button2.Text = "Ні";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // Prizon
            // 
            Prizon.AutoSize = true;
            Prizon.Location = new Point(12, 54);
            Prizon.Name = "Prizon";
            Prizon.Size = new Size(0, 15);
            Prizon.TabIndex = 3;
            // 
            // Confirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 119);
            ControlBox = false;
            Controls.Add(Prizon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Confirmation";
            Text = "Підтвердіть";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label Prizon;
    }
}