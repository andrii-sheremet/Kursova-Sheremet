using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kursova
{
    public partial class Avtoris : Form
    {
        public Avtoris()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (PasswordField.Text == "1111")
            {
                Lobby f = new();
                f.Show();
                this.Visible = false;
            }
            else
            {
                PasswordField.Text = "";
                PasswordField.BackColor = Color.LightPink;
            }
        }
        // Натискання кнопки Ок.

        private void PasswordField_TextChanged(object sender, EventArgs e) =>
            PasswordField.BackColor = Color.White;
        // Введення не правильного паролю.
    }
}
