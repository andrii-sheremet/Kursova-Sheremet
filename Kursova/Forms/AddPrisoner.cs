﻿using System;
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
            new("- - -", new(1, 1, 1), "", -1,
                new(1, 1, 1), -1, "", -1, "", "");

        public AddPrisoner()
        {
            InitializeComponent();

            groupBox1.Visible = groupBox2.Visible = groupBox3.Visible =
                groupBox4.Visible = groupBox5.Visible = groupBox6.Visible =
                groupBox8.Visible = groupBox9.Visible =
                groupBox10.Visible = groupBox11.Visible = true;
        }

        //Кнопки
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
            Wrong += p.SecondName == "" || p.SecondName == "-"
                ? "Прізвище, " : "";
            Wrong += p.FirstName == "" || p.FirstName == "-"
                ? "Ім'я, " : "";
            Wrong += p.ThirdName == "" || p.ThirdName == "-"
                ? "Побатькові, " : "";
            Wrong += p.ImprisDate == new DateTime(1, 1, 1)
                ? "Дата ув'язнення, " : "";
            Wrong += p.BirthDay == new DateTime(1, 1, 1)
                ? "Дата народження, " : "";
            Wrong += p.Term == -1 ? "Термін ув'язнення, " : "";
            Wrong += p.NumKam == -1 ? "Номер камери, " : "";
            Wrong += p.Article == -1 ? "Стаття, " : "";
            Wrong += p.Gender == "" ? "Стать, " : "";
            Wrong += p.Family == "" ? "Родина, " : "";
            Wrong += p.Ierarh == "" ? "Місце в ієрархії, " : "";
            Wrong += p.Haract == "" ? "Особливість характеру " : "";

            if (Wrong == "")
            {
                Data.AddToData(p);
                Lobby lobby = new();
                lobby.Statistic();
                this.Close();
            }
            else
            {
                Wrong wrong = new(Wrong);
                wrong.ShowDialog();
            }
        }
        // Натискання кнопки додавання.

        //СкроллБар
        private void TermBar1_Scroll(object sender, EventArgs e)
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
        // СкроллБар терміну ув'язнення.

        //Чекбокси
        private void CheckMama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMama.Checked) checkNemaRod.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (мати).

        private void CheckDad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDad.Checked) checkNemaRod.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (батько).

        private void CheckKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKid.Checked) checkNemaRod.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (діти).

        private void CheckHusb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHusb.Checked) checkNemaRod.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (чоловік/дружина).

        private void CheckBro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBro.Checked) checkNemaRod.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (брат/сетсра).

        private void CheckNemaRod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNemaRod.Checked) checkMama.Checked =
                    checkDad.Checked = checkKid.Checked
                    = checkHusb.Checked = checkBro.Checked = false;
        }
        // Чекбокс відомостей про сім'ю (нема родичів).

        //Календарі
        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            p.BirthDay = DataNarTimePicker.Value;
        }
        // Календар дати народження.

        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            p.ImprisDate = DataUvyazTimePicker.Value;
        }
        // Календар дати ув'язнення.

        //Полі вводу
        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            p.NumKam = Convert.ToInt32(KamNum.Value);
        }
        //Поле для вводу номера камери.

        private void StatField_SelectedIndexChanged(object sender, EventArgs e)
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
        // Поле вводу статі.

        private void IerarhField_SelectedIndexChanged(object sender, EventArgs e)
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
        // Поле вводу інформації про місце в іерархії.

        private void HaractField_SelectedIndexChanged(object sender, EventArgs e)
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
        // Поле вводу інформації про особливості характеру.

        private void StatyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Article = Convert.ToInt32(statyaField.Text[3..]);
        }
        // Поле вводу статт'і.

        //Поля вводу ПІБ
        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PrizvTextBox.Text != "")
            {
                PrizvTextBox.BackColor = Color.White;
                p.SecondName = PrizvTextBox.Text;
            }
            else
            {
                p.SecondName = "";
            }
        }
        // Поле вводу прізвища.

        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ImyaTextBox.Text != "")
            {
                ImyaTextBox.BackColor = Color.White;
                p.FirstName = ImyaTextBox.Text;
            }
            else
            {
                p.FirstName = "";
            }
        }
        // Поле вводу ім'я.

        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PBTextBox.Text != "")
            {
                PBTextBox.BackColor = Color.White;
                p.ThirdName = PBTextBox.Text;
            }
            else
            {
                p.ThirdName = "";
            }
        }
        // Поле вводу по батькові.
    }
}
