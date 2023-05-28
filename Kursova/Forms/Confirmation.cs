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
    public partial class Confirmation : Form
    {
        private string? name;
        private DateTime dateTime;
        private int numKam;
        private int term;

        public Confirmation(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            name = selectedRow.Cells["ПІБ"].Value.ToString();
            dateTime =
                Convert.ToDateTime(selectedRow.Cells["Дата нар."].Value.ToString());
            numKam =
                Convert.ToInt32(selectedRow.Cells["Камера"].Value.ToString().Replace("№ ", ""));
            term =
                Convert.ToInt32(selectedRow.Cells["Термін"].Value.ToString());


            Prizon.Text = name;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Data.DelPers(name, dateTime, numKam, term);

            this.Close();
        }
        // Натискання кнопки Так

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Натискання кнопки Так
    }
}
