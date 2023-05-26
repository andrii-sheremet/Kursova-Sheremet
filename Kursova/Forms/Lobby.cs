using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace Kursova
{
    public partial class Lobby : Form
    {

        private int term = 1;

        public Lobby()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Lobby_KeyDown);

            checkTerm.Checked = checkKamNum.Checked = checkDataNar.Checked
                = checkDataUvyaz.Checked = true;

            termBar1.Enabled = KamNum.Enabled = DataNarTimePicker.Enabled
                = DataUvyazTimePicker.Enabled = false;

            Data.ReadData();
            Statistic();
        }

        private void Lobby_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                findButton_Click(sender, e);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            }
            if (e.KeyCode == Keys.Space)
            {
                Control? activeControl = ActiveControl;
                if (activeControl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)activeControl;
                    checkBox.Checked = !checkBox.Checked;
                }
                else if (activeControl is Button)
                {
                    Button button = (Button)activeControl;
                    button.PerformClick();
                }
                else if (activeControl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)activeControl;
                    int selectedIndex = comboBox.SelectedIndex;
                    if (selectedIndex < comboBox.Items.Count - 1)
                    {
                        comboBox.SelectedIndex = selectedIndex + 1;
                    }
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Statistic();

            DataTable table = new DataTable();
            table.Columns.Add("ПІБ", typeof(string));
            table.Columns.Add("Дата нар.", typeof(DateTime));
            table.Columns.Add("Стаття", typeof(string));
            table.Columns.Add("Термін", typeof(int));
            table.Columns.Add("Камера", typeof(string));
            table.Columns.Add("Живі родичі", typeof(string));
            table.Columns.Add("Місце в Ієрархії", typeof(string));
            table.Columns.Add("Характер", typeof(string));

            int count = 0;

            foreach (var i in Person.exampl.Search())
            {
                table.Rows.Add
                    ($"{i.SecondName} {i.FirstName} {i.ThirdName}",
                    i.BirthDay, $"ст.{i.Article} ККУ", i.Term,
                    $"№ {i.NumKam}", i.Family, i.Ierarh, i.Haract);
                count++;
            }

            labelSum.Text = Convert.ToString(count);

            if (count > 0)
            {
                exceptionPanel.Visible = false;
            }
            else
            {
                exceptionPanel.Visible = true;
                table.Rows.Clear();
                table.Columns.Clear();
            }

            dataGridView1.DataSource = table;
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            checkMama.Checked = checkDad.Checked = checkKid.Checked
                = checkNemaRod.Checked = checkHusb.Checked = checkBro.Checked
                = false;
        }

        private void ZbrosButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Поля вводу ПІБ
        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exampl.SecondName = PrizvTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Прізвище

        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exampl.FirstName = ImyaTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Ім'я

        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exampl.ThirdName = PBTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Побатькові


        //СкроллБар
        private void TermBar1_Scroll(object sender, EventArgs e)
        {
            switch (termBar1.Value)
            {
                case 1:
                    label1.Text = "1 рік";
                    term = 1;
                    break;
                case 2:
                    label1.Text = "2 роки";
                    term = 2;
                    break;
                case 3:
                    label1.Text = "3 роки";
                    term = 3;
                    break;
                case 4:
                    label1.Text = "5 років";
                    term = 5;
                    break;
                case 5:
                    label1.Text = "8 років";
                    term = 8;
                    break;
                case 6:
                    label1.Text = "15 років";
                    term = 15;
                    break;
            }
            Person.exampl.Term = term;
            Statistic();
        }//Термін ув'язнення


        //Полі вводу
        private void StatyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statyaField.Text == "-" || statyaField.Text == "")
            {
                Person.exampl.Article = -1;
            }
            else
            {
                Person.exampl.Article = Convert.ToInt32(statyaField.Text[3..]);
            }
            Statistic();
        }//Стат'я

        private void StatField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statField.SelectedIndex)
            {
                case 0:
                    Person.exampl.Gender = "Усі";
                    break;
                case 1:
                    Person.exampl.Gender = "W";
                    break;
                case 2:
                    Person.exampl.Gender = "M";
                    break;
            }
            Statistic();
        }//Стать

        private void IerarhField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.exampl.Ierarh = ierarhField.Text;
            Statistic();
        }//Місце в іерархії

        private void HaractField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.exampl.Haract = haractField.Text;
            Statistic();
        }//Особливість характеру

        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            Person.exampl.NumKam = Convert.ToInt32(KamNum.Value);
            Statistic();
        }//Поле для вводу номера камери

        //TimePickers
        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Person.exampl.BirthDay = DataNarTimePicker.Value;
            Statistic();
        }//Дата Народження

        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Person.exampl.ImprisDate = DataUvyazTimePicker.Value;
            Statistic();
        }//Дата Ув'язнення


        //CheckBoxes
        private void CheckTerm_CheckedChanged(object sender, EventArgs e)
        {

            termBar1.Enabled = label1.Visible = !checkTerm.Checked;

            if (checkTerm.Checked)
            {
                Person.exampl.Term = -1;
            }
            else
            {
                Person.exampl.Term = term;
            }
            Statistic();
        } //Чекбокс терміну ув'язнення

        private void CheckKamNum_CheckedChanged(object sender, EventArgs e)
        {
            KamNum.Enabled = !checkKamNum.Checked;

            if (checkKamNum.Checked)
            {
                Person.exampl.NumKam = -1;
            }
            else
            {
                Person.exampl.NumKam = (int)KamNum.Value;
            }
        }//Чекбокс номеру камери

        private void CheckDataNar_CheckedChanged(object sender, EventArgs e)
        {
            DataNarTimePicker.Enabled = !checkDataNar.Checked;

            if (checkDataNar.Checked)
            {
                Person.exampl.BirthDay = new(1900, 01, 01);
            }
            else
            {
                Person.exampl.BirthDay = DataNarTimePicker.Value;
            }
        }//Чекбокс дати народження

        private void CheckDataUvyaz_CheckedChanged(object sender, EventArgs e)
        {
            DataUvyazTimePicker.Enabled = !checkDataUvyaz.Checked;

            if (checkDataUvyaz.Checked)
            {
                Person.exampl.ImprisDate = new(1900, 01, 01);
            }
            else
            {
                Person.exampl.ImprisDate = DataUvyazTimePicker.Value;
            }
        }//Чекбокс дати ув'язнення

        private void CheckMama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMama.Checked)
            {
                Person.exampl.fam.Add(1, "Мати");
                checkNemaRod.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(1);
            }
        }//Чекбокс Мати

        private void CheckDad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDad.Checked)
            {
                Person.exampl.fam.Add(2, "Батько");
                checkNemaRod.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(2);
            }
        }//Чекбокс Батько

        private void CheckKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKid.Checked)
            {
                Person.exampl.fam.Add(3, "Діти");
                checkNemaRod.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(3);
            }
        }//Чекбокс Діти

        private void CheckHusb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHusb.Checked)
            {
                Person.exampl.fam.Add(4, "Чоловік/Дружина");
                checkNemaRod.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(4);
            }
        }//Чекбокс Чоловік/Дружина

        private void CheckBro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBro.Checked)
            {
                Person.exampl.fam.Add(5, "Брат/Сестра");
                checkNemaRod.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(5);
            }
        } //Чекбокс Брат/Сетсра

        private void CheckNemaRod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNemaRod.Checked)
            {
                Person.exampl.fam.Clear();
                Person.exampl.fam.Add(6, "Нема родичів");
                checkMama.Checked = checkDad.Checked = checkKid.Checked
                    = checkHusb.Checked = checkBro.Checked = false;
            }
            else
            {
                Person.exampl.fam.Remove(6);
            }
        }//Чекбокс Нема родичів

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            AddPrisoner f = new();
            f.ShowDialog();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            int lastIndex = dataGridView1.SelectedRows.Count - 1;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[lastIndex];

                Confirmation f = new(selectedRow);
                f.ShowDialog();
            }
            else
            {
                RowChoose f = new();
                f.ShowDialog();
            }

        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();

        public void Statistic()
        {
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (var i in Data.data)
            {
                if (Person.exampl.NumKam == -1)
                {
                    count[0] = Data.data.Count;
                }
                else if (i.NumKam == Person.exampl.NumKam) count[0]++;

                if (Person.exampl.Term == -1)
                {
                    count[1] = Data.data.Count;
                }
                else if (i.Term == Person.exampl.Term) count[1]++;

                if (Person.exampl.Article == -1)
                {
                    count[2] = Data.data.Count;
                }
                else if (i.Article == Person.exampl.Article) count[2]++;

                if (Person.exampl.Gender == "Усі")
                {
                    count[3] = Data.data.Count;
                }
                else if (i.Gender == Person.exampl.Gender) count[3]++;

                if (Person.exampl.Haract == "-")
                {
                    count[4] = Data.data.Count;
                }
                else if (i.Haract == Person.exampl.Haract) count[4]++;

                if (Person.exampl.NumKam == -1)
                {
                    count[5] = Data.data.Count;
                }
                else if (i.NumKam == Person.exampl.NumKam) count[5]++;

                if (Person.exampl.BirthDay == new DateTime(1900, 01, 01))
                {
                    count[6] = Data.data.Count;
                }
                else if (i.BirthDay == Person.exampl.BirthDay) count[6]++;

                if (Person.exampl.ImprisDate == new DateTime(1900, 01, 01))
                {
                    count[7] = Data.data.Count;
                }
                else if (i.ImprisDate == Person.exampl.ImprisDate) count[7]++;

                if (Person.exampl.Ierarh == "-")
                {
                    count[8] = Data.data.Count;
                }
                else if (i.Ierarh == Person.exampl.Ierarh) count[8]++;
            }

            label3.Text = Convert.ToString(count[0]);
            label10.Text = Convert.ToString(count[1]);
            label4.Text = Convert.ToString(count[2]);
            label11.Text = Convert.ToString(count[3]);
            label13.Text = Convert.ToString(count[4]);
            label3.Text = Convert.ToString(count[5]);
            label2.Text = Convert.ToString(count[6]);
            label5.Text = Convert.ToString(count[7]);
            label12.Text = Convert.ToString(count[8]);
        }
    }
}
