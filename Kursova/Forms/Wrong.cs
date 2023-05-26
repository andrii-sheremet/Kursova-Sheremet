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
    public partial class Wrong : Form
    {
        public Wrong(string text)
        {
            InitializeComponent();
            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
