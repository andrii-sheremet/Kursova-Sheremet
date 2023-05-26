using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Kursova
{
    public partial class AddPrisoner : Form
    {
        private Person p =
            new("1 1 1", new(1, 1, 1), "", -1,
                new(1, 1, 1), -1, "", -1, "", "");


        public AddPrisoner()
        {
            InitializeComponent();

            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible =
                groupBox4.Visible = groupBox5.Visible = groupBox6.Visible =
                groupBox8.Visible = groupBox9.Visible =
                groupBox10.Visible = groupBox11.Visible = true;
        }

        private void DobButton_Click(object sender, EventArgs e)
        {
            if (PrizvTextBox.Text == "") PrizvTextBox.BackColor = Color.Pink;
            if (ImyaTextBox.Text == "") ImyaTextBox.BackColor = Color.Pink;
            if (PBTextBox.Text == "") PBTextBox.BackColor = Color.Pink;


            p.Family = "";
            if (checkMama.Checked) p.Family += "Мати ";
            if (checkDad.Checked) p.Family += "Батько ";
            if (checkKid.Checked) p.Family += "Діти ";
            if (checkHusb.Checked) p.Family += "Чоловік/Дружина ";
            if (checkBro.Checked) p.Family += "Брат/Сестра ";
            if (checkNemaRod.Checked) p.Family = "Нема родичів ";

            string Wrong = "";
            Wrong += p.SecondName == "" ? "Прізвище, " : "";
            Wrong += p.FirstName == "" ? "Ім'я, " : "";
            Wrong += p.ThirdName == "" ? "Побатькові, " : "";
            Wrong += p.ImprisDate == new DateTime(1, 1, 1)
                ? "Дата ув'язнення, " : "";
            Wrong += p.BirthDay == new DateTime(1, 1, 1)
                ? "Дата народження, " : "";
            Wrong += p.Term == -1 ? "Термін ув'язнення, " : "";
            Wrong += p.NumKam == -1 ? "Номер камеери, " : "";
            Wrong += p.Article == -1 ? "Стаття, " : "";
            Wrong += p.Gender == "" ? "Стать, " : "";
            Wrong += p.Family == "" ? "Родина, " : "";
            Wrong += p.Ierarh == "" ? "Місце в ієрархії, " : "";
            Wrong += p.Haract == "" ? "Особливість характеру " : "";

            if (Wrong == "")
            {
                Data.AddToData(p);
                this.Close();
            }
            else
            {
                Wrong f4 = new(Wrong);
                f4.ShowDialog();
            }
        }

        private void termBar1_Scroll(object sender, EventArgs e)
        {
            switch (termBar1.Value)
            {
                case 1:
                    label1.Text = "1 роки";
                    p.Term = 1;
                    break;
                case 2:
                    label1.Text = "2 роки";
                    p.Term = 2;
                    break;
                case 3:
                    label1.Text = "3 років";
                    p.Term = 3;
                    break;
                case 4:
                    label1.Text = "5 років";
                    p.Term = 5;
                    break;
                case 5:
                    label1.Text = "8 років";
                    p.Term = 8;
                    break;
                case 6:
                    label1.Text = "15 років";
                    p.Term = 15;
                    break;
            }
        }

        private void statField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statField.SelectedIndex)
            {
                case 0:
                    p.Gender = "W";
                    break;
                case 1:
                    p.Gender = "M";
                    break;
            }
        }

        private void checkMama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMama.Checked) checkNemaRod.Checked = false;
        }//Чекбокс Мати
        private void checkDad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDad.Checked) checkNemaRod.Checked = false;
        }//Чекбокс Батько
        private void checkKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKid.Checked) checkNemaRod.Checked = false;
        }//Чекбокс Діти
        private void checkHusb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHusb.Checked) checkNemaRod.Checked = false;
        }//Чекбокс Чоловік/Дружина
        private void checkBro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBro.Checked) checkNemaRod.Checked = false;
        } //Чекбокс Брат/Сетсра
        private void checkNemaRod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNemaRod.Checked) checkMama.Checked = checkDad.Checked = checkKid.Checked
                    = checkHusb.Checked = checkBro.Checked = false;
        }//Чекбокс Нема родичів


        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            p.BirthDay = DataNarTimePicker.Value;
        }
        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            p.ImprisDate = DataUvyazTimePicker.Value;
        }

        private void haractField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (haractField.SelectedIndex)
            {
                case 0:
                    p.Haract = "Агресивний";
                    break;
                case 1:
                    p.Haract = "Спокійний";
                    break;
                case 2:
                    p.Haract = "Нестійкий";
                    break;
                case 3:
                    p.Haract = "Шістка";
                    break;
            }
        }

        private void ierarhField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ierarhField.SelectedIndex)
            {
                case 0:
                    p.Ierarh = "Блатні";
                    break;
                case 1:
                    p.Ierarh = "Мужики";
                    break;
                case 2:
                    p.Ierarh = "Козли";
                    break;
                case 3:
                    p.Ierarh = "Заполоскані";
                    break;
                case 4:
                    p.Ierarh = "Опущені";
                    break;
            }
        }

        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            p.NumKam = Convert.ToInt32(KamNum.Value);
        }

        private void statyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Article = Convert.ToInt32(statyaField.Text[3..]);
        }

        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrizvTextBox.Text != "")
            {
                PrizvTextBox.BackColor = Color.White;
                p.SecondName = PrizvTextBox.Text;
            }
        }

        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ImyaTextBox.Text != "")
            {
                ImyaTextBox.BackColor = Color.White;
                p.FirstName = ImyaTextBox.Text;
            }
        }

        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PBTextBox.Text != "")
            {
                PBTextBox.BackColor = Color.White;
                p.ThirdName = PBTextBox.Text;
            }
        }
    }
}
