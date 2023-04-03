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
                    label1.Text = "1 ����";
                    Poisk.Term = 1;
                    break;
                case 2:
                    label1.Text = "2 ����";
                    Poisk.Term = 2;
                    break;
                case 3:
                    label1.Text = "3 ����";
                    Poisk.Term = 3;
                    break;
                case 4:
                    label1.Text = "5 ����";
                    Poisk.Term = 5;
                    break;
                case 5:
                    label1.Text = "8 ����";
                    Poisk.Term = 8;
                    break;
                case 6:
                    label1.Text = "15 ����";
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
            table.Columns.Add("ϲ�", typeof(string));
            table.Columns.Add("���� ���.", typeof(DateTime));
            table.Columns.Add("������", typeof(string));
            table.Columns.Add("������", typeof(string));
            table.Columns.Add("������", typeof(Button));

            /*foreach (var i in Data.data)
            {
                if (i.FirstName == p.FirstName
                    && i.SecondName == p.SecondName
                    && i.Statya == p.Statya
                    && i.NumKam == p.NumKam
                    && i.ThirdName == p.ThirdName)
                    table.Rows.Add($"{i.SecondName} {i.FirstName} {i.ThirdName}", i.DateNar, $"��.{i.Statya} ���", $"� {i.NumKam}", new Button());*/
                    table.Rows.Add($"{Poisk.SecondName} {Poisk.FirstName} {Poisk.ThirdName}", Poisk.DateNar, $"��.{Poisk.Statya} ���", $"� {Poisk.NumKam}", new Button());
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
                    Poisk.Stat = "�";
                    break;
                case 2:
                    Poisk.Stat = "�";
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
                new Person(0, "������ ��������� ������������", DN(), "W", 152, DU(), 3, "���� ����", 1, "������", "����������"),
                new Person(1, "���������� ����� ³��������", DN(), "M", 156, DU(), 5, "������ ���� ĳ��", 3, "������", "س����"),
                new Person(2, "��������� ������ �������������", DN(), "M", 185, DU(), 8, "���� ����", 4, "������", "��������"),
                new Person(3, "�������� ������ ��������", DN(), "M", 152, DU(), 3, "���� ĳ��", 9, "�����", "��������"),
                new Person(4, "�������� ����� ���������", DN(), "M", 121, DU(), 8, "���� ĳ��", 2, "������", "����������"),
                new Person(5, "��������� ������ ���������", DN(), "M", 125, DU(), 3, "���� ����", 3, "������", "��������"),
                new Person(6, "��������� ������ ���������", DN(), "W", 115, DU(), 15, "���� ĳ��", 8, "�����", "��������"),
                new Person(7, "������� ³���� ��������", DN(), "M", 156, DU(), 5, "����", 7, "�����", "��������"),
                new Person(8, "������� ��� ��������", DN(), "W", 151, DU(), 1, "����", 4, "������", "����������"),
                new Person(9, "������ ����� �����볿���", DN(), "W", 115, DU(), 15, "����", 5, "�����", "����������"),
                new Person(10, "�������� ���� ³��������", DN(), "M", 185, DU(), 8, "���� ����", 10, "������", "��������"),
                new Person(11, "�������� ���� �������������", DN(), "M", 125, DU(), 3, "������ ���� ĳ��", 6, "�����", "��������"),
                new Person(12, "��������� ������ ���������", DN(), "M", 121, DU(), 8, "���� ����", 9, "������", "س����"),
                new Person(13, "��������� ���� ������������", DN(), "M", 115, DU(), 15, "���� ������ ĳ��", 5, "�����", "��������"),
                new Person(14, "������ ����� �������", DN(), "M", 126, DU(), 2, "������", 6, "������", "��������"),
                new Person(15, "��������� ������ �������������", DN(), "M", 156, DU(), 5, "���� ������ ĳ��", 8, "�����", "��������"),
                new Person(16, "�������� ��� �������", DN(), "W", 121, DU(), 8, "������", 9, "�����", "��������"),
                new Person(17, "������� ���� ³��볿���", DN(), "W", 122, DU(), 3, "���� ����", 10, "����������", "��������"),
                new Person(18, "������� ��������� �����������", DN(), "M", 125, DU(), 3, "���� ������ ĳ��", 10, "�����", "س����"),
                new Person(19, "�������� ����� ����������", DN(), "M", 122, DU(), 3, "���� ����", 1, "����������", "����������")
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