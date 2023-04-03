using System.Data;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Kursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            KamNum.Enabled = checkMama.Checked = checkKid.Checked
                    = checkDad.Checked = checkBro.Checked = checkHusb.Checked
                    = termBar1.Enabled = label1.Visible
                    = DataNarTimePicker.Enabled = DataUvyazTimePicker.Enabled
                    = false;

            checkKamNum.Checked = checkDataNar.Checked = checkRod.Checked
                = checkTerm.Checked = checkDataUvyaz.Checked = true;

        }

        private void termBar1_Scroll(object sender, EventArgs e)
        {
            switch (termBar1.Value)
            {
                case 1:
                    label1.Text = "1 роки";
                    Poisk.Term = 1;
                    break;
                case 2:
                    label1.Text = "2 роки";
                    Poisk.Term = 2;
                    break;
                case 3:
                    label1.Text = "3 років";
                    Poisk.Term = 3;
                    break;
                case 4:
                    label1.Text = "5 років";
                    Poisk.Term = 5;
                    break;
                case 5:
                    label1.Text = "8 років";
                    Poisk.Term = 8;
                    break;
                case 6:
                    label1.Text = "15 років";
                    Poisk.Term = 15;
                    break;
                default:
                    Poisk.Term = -1;
                    break;

            }
        }

        private void checkTerm_CheckedChanged(object sender, EventArgs e)
        {

            termBar1.Enabled = label1.Visible = !checkTerm.Checked;
        }

        private void checkRod_CheckedChanged(object sender, EventArgs e)
        {
            checkMama.Enabled = checkKid.Enabled
                = checkDad.Enabled = checkBro.Enabled
                = checkHusb.Enabled = !checkRod.Checked;
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("ПІБ", typeof(string));
            table.Columns.Add("Дата нар.", typeof(DateTime));
            table.Columns.Add("Стаття", typeof(string));
            table.Columns.Add("Камера", typeof(string));
            table.Columns.Add("Більше", typeof(Button));

            /*foreach (var i in Data.data)
            {
                if (i.FirstName == p.FirstName
                    && i.SecondName == p.SecondName
                    && i.Statya == p.Statya
                    && i.NumKam == p.NumKam
                    && i.ThirdName == p.ThirdName)
                    table.Rows.Add($"{i.SecondName} {i.FirstName} {i.ThirdName}", i.DateNar, $"ст.{i.Statya} ККУ", $"№ {i.NumKam}", new Button());*/
                    table.Rows.Add($"{Poisk.SecondName} {Poisk.FirstName} {Poisk.ThirdName}", Poisk.DateNar, $"ст.{Poisk.Statya} ККУ", $"№ {Poisk.NumKam}", new Button());
            //}

            dataGridView1.DataSource = table;
        }

        private void checkKamNum_CheckedChanged(object sender, EventArgs e)
        {
            KamNum.Enabled = !checkKamNum.Checked;
        }

        private void checkDataNar_CheckedChanged(object sender, EventArgs e)
        {
            DataNarTimePicker.Enabled = !checkDataNar.Checked;
            Poisk.Term = -1;
        }

        private void checkDataUvyaz_CheckedChanged(object sender, EventArgs e)
        {
            DataUvyazTimePicker.Enabled = !checkDataUvyaz.Checked;
        }
        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.SecondName = PrizvTextBox.Text.Trim();
        }

        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.FirstName = ImyaTextBox.Text.Trim();
        }

        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {
            Poisk.ThirdName = PBTextBox.Text.Trim();
        }
        private void statyaField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk.Statya = Convert.ToInt32(statyaField.Text[3..]);
        }

        private void statField_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (statField.SelectedIndex)
            {
                case 0:
                    Poisk.Stat = "N";
                    break;
                case 1:
                    Poisk.Stat = "М";
                    break;
                case 2:
                    Poisk.Stat = "Ж";
                    break;
                default:
                    Poisk.Stat = "N";
                    break;
            }
        }

        private void ierarhField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk.Ierarh = ierarhField.Text.Trim();
        }

        private void haractField_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk.Haract = haractField.Text.Trim();
        }

    }
    class Data
    {
        public static List<Person> data = new()
            {
                new Person(0, "Білоус Єлизавета Олександрівна", DN(), "W", 152, DU(), 3, "Мати Брат", 1, "Опущені", "Агресивний"),
                new Person(1, "Гончаренко Андрій Віталійович", DN(), "M", 156, DU(), 5, "Сестра Шлюб Діти", 3, "Опущені", "Шістка"),
                new Person(2, "Кравченко Максим Володимирович", DN(), "M", 185, DU(), 8, "Мати Брат", 4, "Мужики", "Спокійний"),
                new Person(3, "Петренко Микита Олегович", DN(), "M", 152, DU(), 3, "Шлюб Діти", 9, "Блатні", "Нестійкий"),
                new Person(4, "Шевченко Андрій Сергійович", DN(), "M", 121, DU(), 8, "Шлюб Діти", 2, "Мужики", "Агресивний"),
                new Person(5, "Кравченко Дмитро Сергійович", DN(), "M", 125, DU(), 3, "Мати Брат", 3, "Опущені", "Нестійкий"),
                new Person(6, "Ковальчук Наталія Миколаївна", DN(), "W", 115, DU(), 15, "Шлюб Діти", 8, "Блатні", "Нестійкий"),
                new Person(7, "Мельник Віталій Ігорович", DN(), "M", 156, DU(), 5, "Мати", 7, "Козли", "Нестійкий"),
                new Person(8, "Мельник Юлія Василівна", DN(), "W", 151, DU(), 1, "Мати", 4, "Мужики", "Агресивний"),
                new Person(9, "Олійник Ірина Анатоліївна", DN(), "W", 115, DU(), 15, "Мати", 5, "Блатні", "Агресивний"),
                new Person(10, "Петренко Олег Віталійович", DN(), "M", 185, DU(), 8, "Мати Шлюб", 10, "Опущені", "Нестійкий"),
                new Person(11, "Петренко Ігор Володимирович", DN(), "M", 125, DU(), 3, "Сестра Шлюб Діти", 6, "Козли", "Спокійний"),
                new Person(12, "Сидоренко Дмитро Сергійович", DN(), "M", 121, DU(), 8, "Мати Брат", 9, "Мужики", "Шістка"),
                new Person(13, "Тарасенко Марія Олександрівна", DN(), "M", 115, DU(), 15, "Мати Батько Діти", 5, "Блатні", "Спокійний"),
                new Person(14, "Ушаков Сергій Юрійович", DN(), "M", 126, DU(), 2, "Батько", 6, "Опущені", "Спокійний"),
                new Person(15, "Ковальчук Дмитро Олександрович", DN(), "M", 156, DU(), 5, "Мати Батько Діти", 8, "Козли", "Нестійкий"),
                new Person(16, "Харченко Юлія Іванівна", DN(), "W", 121, DU(), 8, "Батько", 9, "Блатні", "Спокійний"),
                new Person(17, "Царенко Анна Віталіївна", DN(), "W", 122, DU(), 3, "Мати Шлюб", 10, "Заполоскані", "Нестійкий"),
                new Person(18, "Лисенко Олександр Миколайович", DN(), "M", 125, DU(), 3, "Мати Батько Діти", 10, "Козли", "Шістка"),
                new Person(19, "Шевченко Денис Васильович", DN(), "M", 122, DU(), 3, "Мати Шлюб", 1, "Заполоскані", "Агресивний")
            };
        static DateTime DN()
        {
            /*Random r = new Random();
            int y = r.Next(1950, 1996);
            int m = r.Next(1, 13);
            int d = 0;
            if (m % 2 == 1 && m <= 7 || m % 2 == 0 && m >= 8)
            {
                d = r.Next(1, 32);
            }
            else if (m == 2) d = r.Next(1, y % 4 == 0 ? 30 : 29);
            else d = r.Next(1, 31);

            return new DateTime(y, m, d);*/
            return new DateTime(2004, 11, 16);

        }
        static DateTime DU()
        {
            /*Random r = new Random();
            int y = r.Next(1990, 2023);
            int m = r.Next(1, 13);
            int d = 0;
            if (m % 2 == 1 && m <= 7 || m % 2 == 0 && m >= 8)
            {
                d = r.Next(1, 31);
            }
            else if (m == 2) d = r.Next(0, y % 4 == 0 ? 30 : 29);
            else d = r.Next(1, 31);

            return new DateTime(y, m, d);*/

            return new DateTime(2004, 11, 16);

        }
    }

    class Person
    {
        public int Id { get; }
        public string FirstName { get; }
        public string SecondName { get; }
        public string ThirdName { get; }
        public DateTime DateNar { get; }
        public string Stat { get; }
        public int Statya { get; }
        public DateTime DateUvyaz { get; }
        public int Term { get; }
        public string Rod { get; }
        public int NumKam { get; }
        public string Ierarh { get; }
        public string Haract { get; }

        public Person(int id, string name, DateTime dateNar, string stat,
            int statya, DateTime dateUvyaz, int term, string rod,
            int numKam, string ierarh, string haract)
        {

            Id = id;

            string[] n = name.Split(' ');
            SecondName = n[0];
            FirstName = n[1];
            ThirdName = n[2];

            DateNar = dateNar;
            Stat = stat;
            Statya = statya;
            DateUvyaz = dateUvyaz;
            Term = term;
            Rod = rod;
            NumKam = numKam;
            Ierarh = ierarh;
            Haract = haract;
        }
    }

    static class Poisk
    {
        public static string FirstName { get; set; }
        public static string SecondName { get; set; }
        public static string ThirdName { get; set; }
        public static DateTime DateNar { get; set; }
        public static string Stat { get; set; }
        public static int Statya { get; set; }
        public static DateTime DateUvyaz { get; set; }
        public static int Term { get; set; }
        public static string Rod { get; set; }
        public static int NumKam { get; set; }
        public static string Ierarh { get; set; }
        public static string Haract { get; set; }
        static Poisk()
        {
            FirstName = SecondName = ThirdName = "-";
            DateNar = new(1900, 01, 01);
            Stat = "-";
            Statya = -1;
            DateUvyaz = new(1900, 01, 01);
            Term = -1;
            Rod = "";
            NumKam = -1;
            Ierarh = "";
            Haract = "";
        }
    }
}