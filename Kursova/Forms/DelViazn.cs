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
    public partial class DelViazn : Form
    {
        public DelViazn()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            foreach (var item in Data.Find(comboBox1.Text))
            {
                comboBox1.Items.Add($"{item.SecondName} {item.FirstName} {item.ThirdName}");
            }
        }
    }
}
