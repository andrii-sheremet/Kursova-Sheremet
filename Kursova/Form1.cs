using System.CodeDom.Compiler;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections;
using System.Xml.Linq;

namespace Kursova
{
    public partial class Form1 : Form
    {

        private int term = 1;
        public SortedList<int, string> rod = new() { { 0, "" } };

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            zbros();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                findButton_Click(sender, e);
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

            Person p = Poisk.MembIn();

            foreach (var i in Data.data)
            {

                Poisk.Go(i);

                bool rodBool = false;
                foreach (KeyValuePair<int, string> memb in rod)
                {
                    rodBool = i.Rod.Contains(memb.Value);

                    if (!rodBool) break;
                }

                bool prBool = i.SecondName.ToUpper().Contains
                    (Poisk.SecondName.ToUpper());

                bool imBool = i.FirstName.ToUpper().Contains
                    (Poisk.FirstName.ToUpper());

                bool pbBool = i.ThirdName.ToUpper().Contains
                    (Poisk.ThirdName.ToUpper());

                if (prBool && imBool && pbBool && rodBool
                    && i.DateNar == Poisk.DateNar
                    && i.DateUvyaz == Poisk.DateUvyaz
                    && i.Statya == Poisk.Statya
                    && i.Stat == Poisk.Stat
                    && i.Haract == Poisk.Haract
                    && i.Ierarh == Poisk.Ierarh
                    && i.NumKam == Poisk.NumKam
                    && i.Term == Poisk.Term)
                {
                    table.Rows.Add
                        ($"{i.SecondName} {i.FirstName} {i.ThirdName}",
                        i.DateNar, $"ст.{i.Statya} ККУ", i.Term,
                        $"№ {i.NumKam}", i.Rod, i.Ierarh, i.Haract);
                    count++;
                }

                Poisk.MembOut(p);
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
            rodDef();
        }
        private void zbrosButton_Click(object sender, EventArgs e)
        {
            zbros();
        }


        public void zbros()
        {
            KamNum.Enabled = termBar1.Enabled = label1.Visible
                    = DataNarTimePicker.Enabled = DataUvyazTimePicker.Enabled
                    = false;

            checkKamNum.Checked = checkDataNar.Checked = checkTerm.Checked
                = checkDataUvyaz.Checked = true;

            statField.Text = "Усі";

            rodDef();

            PrizvTextBox.Text = ImyaTextBox.Text = PBTextBox.Text
                = statyaField.Text = ierarhField.Text = haractField.Text = "-";
        }
        public void rodDef() =>
            checkMama.Checked = checkDad.Checked = checkKid.Checked
                = checkNemaRod.Checked = checkHusb.Checked = checkBro.Checked
                = false;
        private void Statistic()
        {
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (var i in Data.data)
            {
                if (Poisk.NumKam == -1)
                {
                    count[0] = Data.data.Count;
                }
                else if (i.NumKam == Poisk.NumKam) count[0]++;

                if (Poisk.Term == -1)
                {
                    count[1] = Data.data.Count;
                }
                else if (i.Term == Poisk.Term) count[1]++;

                if (Poisk.Statya == -1)
                {
                    count[2] = Data.data.Count;
                }
                else if (i.Statya == Poisk.Statya) count[2]++;

                if (Poisk.Stat == "Усі")
                {
                    count[3] = Data.data.Count;
                }
                else if (i.Stat == Poisk.Stat) count[3]++;

                if (Poisk.Haract == "-")
                {
                    count[4] = Data.data.Count;
                }
                else if (i.Haract == Poisk.Haract) count[4]++;

                if (Poisk.NumKam == -1)
                {
                    count[5] = Data.data.Count;
                }
                else if (i.NumKam == Poisk.NumKam) count[5]++;

                if (Poisk.DateNar == new DateTime(1900, 01, 01))
                {
                    count[6] = Data.data.Count;
                }
                else if (i.DateNar == Poisk.DateNar) count[6]++;

                if (Poisk.DateUvyaz == new DateTime(1900, 01, 01))
                {
                    count[7] = Data.data.Count;
                }
                else if (i.DateUvyaz == Poisk.DateUvyaz) count[7]++;

                if (Poisk.Ierarh == "-")
                {
                    count[8] = Data.data.Count;
                }
                else if (i.Ierarh == Poisk.Ierarh) count[8]++;
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


        //Поля вводу ПІБ
        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.SecondName = PrizvTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Прізвище
        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.FirstName = ImyaTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Ім'я
        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.ThirdName = PBTextBox.Text.Trim();
            Statistic();
            findButton_Click(sender, e);
        }//Побатькові


        //СкроллБар
        private void termBar1_Scroll(object sender, EventArgs e)
        {
            switch (termBar1.Value)
            {
                case 1:
                    label1.Text = "1 роки";
                    term = 1;
                    break;
                case 2:
                    label1.Text = "2 роки";
                    term = 2;
                    break;
                case 3:
                    label1.Text = "3 років";
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
            Poisk.Term = term;
            Statistic();
        }//Термін ув'язнення


        //Полі вводу
        private void statyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statyaField.Text == "-" || statyaField.Text == "")
            {
                Poisk.Statya = -1;
            }
            else
            {
                Poisk.Statya = Convert.ToInt32(statyaField.Text[3..]);
            }
            Statistic();
        }//Стат'я
        private void statField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statField.SelectedIndex)
            {
                case 0:
                    Poisk.Stat = "Усі";
                    break;
                case 1:
                    Poisk.Stat = "M";
                    break;
                case 2:
                    Poisk.Stat = "W";
                    break;
            }
            Statistic();
        }//Стать
        private void ierarhField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk.Ierarh = ierarhField.Text;
            Statistic();
        }//Місце в іерархії
        private void haractField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk.Haract = haractField.Text;
            Statistic();
        }//Особливість характеру


        
        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            Poisk.NumKam = Convert.ToInt32(KamNum.Value);
            Statistic();
        }//Поле для вводу номера камери


        //TimePickers
        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Poisk.DateNar = DataNarTimePicker.Value;
            Statistic();
        }//Дата Народження
        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Poisk.DateUvyaz = DataUvyazTimePicker.Value;
            Statistic();
        }//Дата Ув'язнення


        //CheckBoxes
        private void checkTerm_CheckedChanged(object sender, EventArgs e)
        {

            termBar1.Enabled = label1.Visible = !checkTerm.Checked;

            if (checkTerm.Checked)
            {
                Poisk.Term = -1;
            }
            else
            {
                Poisk.Term = term;
            }
            Statistic();
        } //Чекбокс терміну ув'язнення
        private void checkKamNum_CheckedChanged(object sender, EventArgs e)
        {
            KamNum.Enabled = !checkKamNum.Checked;

            if (checkKamNum.Checked)
            {
                Poisk.NumKam = -1;
            }
            else
            {
                Poisk.NumKam = (int)KamNum.Value;
            }
        }//Чекбокс номеру камери
        private void checkDataNar_CheckedChanged(object sender, EventArgs e)
        {
            DataNarTimePicker.Enabled = !checkDataNar.Checked;

            if (checkDataNar.Checked)
            {
                Poisk.DateNar = new(1900, 01, 01);
            }
            else
            {
                Poisk.DateNar = DataNarTimePicker.Value;
            }
        }//Чекбокс дати народження
        private void checkDataUvyaz_CheckedChanged(object sender, EventArgs e)
        {
            DataUvyazTimePicker.Enabled = !checkDataUvyaz.Checked;

            if (checkDataUvyaz.Checked)
            {
                Poisk.DateUvyaz = new(1900, 01, 01);
            }
            else
            {
                Poisk.DateUvyaz = DataUvyazTimePicker.Value;
            }
        }//Чекбокс дати ув'язнення
        private void checkMama_CheckedChanged(object sender, EventArgs e)
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
        private void checkDad_CheckedChanged(object sender, EventArgs e)
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
        private void checkKid_CheckedChanged(object sender, EventArgs e)
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
        private void checkHusb_CheckedChanged(object sender, EventArgs e)
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
        private void checkBro_CheckedChanged(object sender, EventArgs e)
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
        private void checkNemaRod_CheckedChanged(object sender, EventArgs e)
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



    }
    class Data
    {
        public Data()
        {
            string path1 = $@"C:\Users\User\Desktop\data.txt";

            string[] pers = File.ReadAllText(path1).Split(';');

            foreach (string s in pers)
            {
                string[] i = s.Split(",");
                DateTime date1 = new(
                    Convert.ToInt16(i[1].Split(' ')[0]),
                    Convert.ToInt16(i[1].Split(' ')[1]),
                    Convert.ToInt16(i[1].Split(' ')[2])
                    );

                DateTime date2 = new(
                    Convert.ToInt16(i[4].Split(' ')[0]),
                    Convert.ToInt16(i[4].Split(' ')[1]),
                    Convert.ToInt16(i[4].Split(' ')[2])
                    );

                data.Add(new(i[0], date1, i[2], Convert.ToInt16(i[3]),
                    date2, Convert.ToInt16(i[5]), i[6], Convert.ToInt16(i[7]),
                    i[8], i[9]));
            }
        }

        

        public static List<Person> data = new()
            {
                new Person( "Білоус Єлизавета Олександрівна", new(1970, 1, 1), "W", 152, new(2001, 2, 14), 3, "Мати Брат/Сестра", 1, "Опущені", "Агресивний"),
                new Person( "Мухамад Мурад Іванович", new(1975, 3, 15), "M", 156, new(2002, 6, 21), 5, "Діти Чоловік/Дружина Брат/Сестра", 3, "Опущені", "Шістка"),
                new Person( "Кравченко Максим Володимирович", new(1970, 5, 27), "M", 185, new(2003, 11, 5), 8, "Мати Брат/Сестра", 4, "Мужики", "Спокійний"),
                new Person( "Петренко Микита Олегович", new(1975, 8, 9), "M", 152, new(2004, 4, 8), 3, "Діти Чоловік/Дружина", 9, "Блатні", "Нестійкий"),
                new Person( "Шевченко Андрій Сергійович", new(1970, 10, 21), "M", 121, new(2005, 9, 13), 8, "Діти Чоловік/Дружина", 2, "Мужики", "Агресивний"),
                new Person( "Гончаренко Андрій Віталійович", new(1975, 12, 3), "M", 125, new(2006, 12, 22), 3, "Мати Брат/Сестра", 12, "Опущені", "Нестійкий"),
                new Person( "Ковальчук Наталія Миколаївна", new(1980, 2, 14), "W", 115, new(2007, 8, 7), 15, "Діти Чоловік/Дружина", 8, "Блатні", "Нестійкий"),
                new Person( "Мельник Віталій Ігорович", new(1985, 4, 26), "M", 156, new(2008, 1, 17), 5, "Мати", 7, "Козли", "Нестійкий"),
                new Person( "Мельник Юлія Василівна", new(1990, 7, 8), "W", 151, new(2009, 6, 28), 1, "Мати", 4, "Заполоскані", "Агресивний"),
                new Person( "Олійник Ірина Анатоліївна", new(1991, 9, 19), "W", 115, new(2010, 10, 9), 15, "Мати", 5, "Блатні", "Агресивний"),
                new Person( "Петренко Олег Віталійович", new(1992, 11, 1), "M", 185, new(2011, 3, 12), 8, "Нема родичів", 10, "Опущені", "Нестійкий"),
                new Person( "Петренко Ігор Володимирович", new(1971, 2, 12), "M", 125, new(2012, 7, 23), 3, "Діти Чоловік/Дружина Брат/Сестра", 6, "Козли", "Спокійний"),
                new Person( "Сидоренко Дмитро Сергійович", new(1966, 4, 24), "M", 121, new(2013, 12, 3), 8, "Мати Брат/Сестра", 9, "Мужики", "Шістка"),
                new Person( "Тарасенко Марія Олександрівна", new(1961, 7, 6), "M", 115, new(2014, 8, 18), 15, "Мати Батько Діти", 5, "Блатні", "Спокійний"),
                new Person( "Ушаков Сергій Юрійович", new(1966, 9, 17), "M", 126, new(2015, 1, 27), 2, "Батько", 6, "Опущені", "Спокійний"),
                new Person( "Ковальчук Дмитро Олександрович", new(1971, 11, 29), "M", 156, new(2016, 6, 8), 5, "Нема родичів", 8, "Козли", "Нестійкий"),
                new Person( "Харченко Юлія Іванівна", new(1976, 1, 10), "W", 121, new(2017, 10, 19), 8, "Батько", 9, "Блатні", "Спокійний"),
                new Person( "Малащук Ярослава Сергіївна", new(1985, 8, 17), "W", 122, new(2018, 5, 2), 3, "Мати Чоловік/Дружина", 10, "Блатні", "Нестійкий"),
                new Person( "Лисенко Олександр Миколайович", new(1986, 6, 4), "M", 125, new(2019, 11, 14), 3, "Мати Батько Діти", 10, "Козли", "Шістка"),
                new Person( "Шевченко Денис Васильович", new(1993, 8, 16), "M", 122, new(2020, 3, 26), 3, "Мати Брат/Сестра", 1, "Заполоскані", "Агресивний"),
                new Person( "Шевченко Олександра Василівна", new(1992, 4, 26), "Ж", 122, new(2020, 3, 26), 3, "Мати Брат/Сестра", 1, "Заполоскані", "Агресивний")
            };
    }//Класс із базою даних 
    class Person
    {
        public string FirstName { get; }
        public string SecondName { get; }
        public string ThirdName { get; }
        public DateTime DateNar { get; set; }
        public string Stat { get; }
        public int Statya { get; }
        public DateTime DateUvyaz { get; }
        public int Term { get; }
        public string Rod { get; }
        public int NumKam { get; }
        public string Ierarh { get; }
        public string Haract { get; }

        public Person(string name, DateTime dateNar, string stat,
            int statya, DateTime dateUvyaz, int term, string rodInd,
            int numKam, string ierarh, string haract)
        {

            string[] n = name.Split(' ');
            SecondName = n[0];
            FirstName = n[1];
            ThirdName = n[2];

            DateNar = dateNar;
            Stat = stat;
            Statya = statya;
            DateUvyaz = dateUvyaz;
            Term = term;
            Rod = rodInd;
            NumKam = numKam;
            Ierarh = ierarh;
            Haract = haract;
        }
    }//Класс для створення персонажів для в'язниці
    static class Poisk
    {

        public static string FirstName { get; set; } = "-";
        public static string SecondName { get; set; } = "-";
        public static string ThirdName { get; set; } = "-";
        public static DateTime DateNar { get; set; } = new(1900, 01, 01);
        public static string Stat { get; set; } = "Усі";
        public static int Statya { get; set; } = -1;
        public static DateTime DateUvyaz { get; set; } = new(1900, 01, 01);
        public static int Term { get; set; } = -1;
        public static string Rod { get; set; } = "";
        public static int NumKam { get; set; } = -1;
        public static string Ierarh { get; set; } = "-";
        public static string Haract { get; set; } = "-";

        public static void Go(Person p)
        {

            FirstName = FirstName == "" || FirstName == "-"
                ? p.FirstName : FirstName;

            SecondName = SecondName == "" || SecondName == "-"
                ? p.SecondName : SecondName;

            ThirdName = ThirdName == "" || ThirdName == "-"
                ? p.ThirdName : ThirdName;

            DateNar = DateNar == new DateTime(1900, 01, 01)
                ? p.DateNar : DateNar;

            Stat = Stat == "Усі" ? p.Stat : Stat;

            Statya = Statya == -1 ? p.Statya : Statya;

            DateUvyaz = DateUvyaz == new DateTime(1900, 01, 01)
                ? p.DateUvyaz : DateUvyaz;

            Term = Term == -1 ? p.Term : Term;

            Rod = Rod == "" ? p.Rod : Rod;

            NumKam = NumKam == -1 ? p.NumKam : NumKam;

            Ierarh = Ierarh == "-" || Ierarh == ""
                ? p.Ierarh : Ierarh;

            Haract = Haract == "-" || Haract == ""
                ? p.Haract : Haract;
        }

        public static Person MembIn() =>
            new($"{SecondName} {FirstName} {ThirdName}", DateNar, Stat,
                Statya, DateUvyaz, Term, Rod, NumKam, Ierarh, Haract);

        public static void MembOut(Person memb)
        {
            SecondName = memb.SecondName;
            FirstName = memb.FirstName;
            ThirdName = memb.ThirdName;
            Stat = memb.Stat;
            Statya = memb.Statya;
            Term = memb.Term;
            Rod = memb.Rod;
            NumKam = memb.NumKam;
            DateNar = memb.DateNar;
            DateUvyaz = memb.DateUvyaz;
            Ierarh = memb.Ierarh;
            Haract = memb.Haract;
        }
    }//Класс для перевірки по базі даних за вписаними ознаками  
}