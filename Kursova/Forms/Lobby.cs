using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public SortedList<int, string> rod = new() { { 0, "" } };

        public Lobby()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Lobby_KeyDown);

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
                else if (activeControl is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)activeControl;
                    button.PerformClick();
                }
                else if (activeControl is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)activeControl;
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

            foreach (var i in Person.exempl.Search())
            {
                table.Rows.Add
                    ($"{i.SecondName} {i.FirstName} {i.ThirdName}",
                    i.DateNar, $"ст.{i.Statya} ККУ", i.Term,
                    $"№ {i.NumKam}", i.Rod, i.Ierarh, i.Haract);
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
        private void label9_Click(object sender, EventArgs e)
        {
            RodDef();
        }
        private void zbrosButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void RodDef() =>
            checkMama.Checked = checkDad.Checked = checkKid.Checked
                = checkNemaRod.Checked = checkHusb.Checked = checkBro.Checked
                = false;

        //Поля вводу ПІБ
        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exempl.SecondName = PrizvTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Прізвище
        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exempl.FirstName = ImyaTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Ім'я
        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            Person.exempl.ThirdName = PBTextBox.Text.Trim();
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
            Person.exempl.Term = term;
            Statistic();
        }//Термін ув'язнення


        //Полі вводу
        private void StatyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statyaField.Text == "-" || statyaField.Text == "")
            {
                Person.exempl.Statya = -1;
            }
            else
            {
                Person.exempl.Statya = Convert.ToInt32(statyaField.Text[3..]);
            }
            Statistic();
        }//Стат'я

        private void statField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statField.SelectedIndex)
            {
                case 0:
                    Person.exempl.Stat = "Усі";
                    break;
                case 1:
                    Person.exempl.Stat = "W";
                    break;
                case 2:
                    Person.exempl.Stat = "M";
                    break;
            }
            Statistic();
        }//Стать

        private void IerarhField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.exempl.Ierarh = ierarhField.Text;
            Statistic();
        }//Місце в іерархії

        private void HaractField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person.exempl.Haract = haractField.Text;
            Statistic();
        }//Особливість характеру

        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            Person.exempl.NumKam = Convert.ToInt32(KamNum.Value);
            Statistic();
        }//Поле для вводу номера камери

        //TimePickers
        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Person.exempl.DateNar = DataNarTimePicker.Value;
            Statistic();
        }//Дата Народження

        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Person.exempl.DateUvyaz = DataUvyazTimePicker.Value;
            Statistic();
        }//Дата Ув'язнення


        //CheckBoxes
        private void CheckTerm_CheckedChanged(object sender, EventArgs e)
        {

            termBar1.Enabled = label1.Visible = !checkTerm.Checked;

            if (checkTerm.Checked)
            {
                Person.exempl.Term = -1;
            }
            else
            {
                Person.exempl.Term = term;
            }
            Statistic();
        } //Чекбокс терміну ув'язнення
        private void CheckKamNum_CheckedChanged(object sender, EventArgs e)
        {
            KamNum.Enabled = !checkKamNum.Checked;

            if (checkKamNum.Checked)
            {
                Person.exempl.NumKam = -1;
            }
            else
            {
                Person.exempl.NumKam = (int)KamNum.Value;
            }
        }//Чекбокс номеру камери
        private void CheckDataNar_CheckedChanged(object sender, EventArgs e)
        {
            DataNarTimePicker.Enabled = !checkDataNar.Checked;

            if (checkDataNar.Checked)
            {
                Person.exempl.DateNar = new(1900, 01, 01);
            }
            else
            {
                Person.exempl.DateNar = DataNarTimePicker.Value;
            }
        }//Чекбокс дати народження
        private void CheckDataUvyaz_CheckedChanged(object sender, EventArgs e)
        {
            DataUvyazTimePicker.Enabled = !checkDataUvyaz.Checked;

            if (checkDataUvyaz.Checked)
            {
                Person.exempl.DateUvyaz = new(1900, 01, 01);
            }
            else
            {
                Person.exempl.DateUvyaz = DataUvyazTimePicker.Value;
            }
        }//Чекбокс дати ув'язнення
        private void CheckMama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMama.Checked)
            {
                rod.Add(1, "Мати");
                checkNemaRod.Checked = false;
            }
            else
            {
                rod.Remove(1);
            }
        }//Чекбокс Мати
        private void CheckDad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDad.Checked)
            {
                rod.Add(2, "Батько");
                checkNemaRod.Checked = false;
            }
            else
            {
                rod.Remove(2);
            }
        }//Чекбокс Батько
        private void CheckKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKid.Checked)
            {
                rod.Add(3, "Діти");
                checkNemaRod.Checked = false;
            }
            else
            {
                rod.Remove(3);
            }
        }//Чекбокс Діти
        private void CheckHusb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHusb.Checked)
            {
                rod.Add(4, "Чоловік/Дружина");
                checkNemaRod.Checked = false;
            }
            else
            {
                rod.Remove(4);
            }
        }//Чекбокс Чоловік/Дружина
        private void CheckBro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBro.Checked)
            {
                rod.Add(5, "Брат/Сестра");
                checkNemaRod.Checked = false;
            }
            else
            {
                rod.Remove(5);
            }
        } //Чекбокс Брат/Сетсра
        private void CheckNemaRod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNemaRod.Checked)
            {
                rod.Add(6, "Нема родичів");
                checkMama.Checked = checkDad.Checked = checkKid.Checked
                    = checkHusb.Checked = checkBro.Checked = false;
            }
            else
            {
                rod.Remove(6);
            }
        }//Чекбокс Нема родичів

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();


        public void Statistic()
        {
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (var i in Data.data)
            {
                if (Person.exempl.NumKam == -1)
                {
                    count[0] = Data.data.Count;
                }
                else if (i.NumKam == Person.exempl.NumKam) count[0]++;

                if (Person.exempl.Term == -1)
                {
                    count[1] = Data.data.Count;
                }
                else if (i.Term == Person.exempl.Term) count[1]++;

                if (Person.exempl.Statya == -1)
                {
                    count[2] = Data.data.Count;
                }
                else if (i.Statya == Person.exempl.Statya) count[2]++;

                if (Person.exempl.Stat == "Усі")
                {
                    count[3] = Data.data.Count;
                }
                else if (i.Stat == Person.exempl.Stat) count[3]++;

                if (Person.exempl.Haract == "-")
                {
                    count[4] = Data.data.Count;
                }
                else if (i.Haract == Person.exempl.Haract) count[4]++;

                if (Person.exempl.NumKam == -1)
                {
                    count[5] = Data.data.Count;
                }
                else if (i.NumKam == Person.exempl.NumKam) count[5]++;

                if (Person.exempl.DateNar == new DateTime(1900, 01, 01))
                {
                    count[6] = Data.data.Count;
                }
                else if (i.DateNar == Person.exempl.DateNar) count[6]++;

                if (Person.exempl.DateUvyaz == new DateTime(1900, 01, 01))
                {
                    count[7] = Data.data.Count;
                }
                else if (i.DateUvyaz == Person.exempl.DateUvyaz) count[7]++;

                if (Person.exempl.Ierarh == "-")
                {
                    count[8] = Data.data.Count;
                }
                else if (i.Ierarh == Person.exempl.Ierarh) count[8]++;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddPrisoner f = new();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int lastIndex = dataGridView1.SelectedRows.Count - 1;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[lastIndex];

                Confirmation f = new(selectedRow);
                f.ShowDialog();
            }
        }

    }
}
