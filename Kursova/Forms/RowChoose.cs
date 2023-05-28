using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class RowChoose : Form
    {
        public RowChoose()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e) =>
            this.Close();
        // Натискання кнопки "Далі".
    }
}
