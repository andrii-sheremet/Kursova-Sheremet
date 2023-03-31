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
                    break;
                case 2:
                    label1.Text = "2 ����";
                    break;
                case 3:
                    label1.Text = "3 ����";
                    break;
                case 4:
                    label1.Text = "5 ����";
                    break;
                case 5:
                    label1.Text = "8 ����";
                    break;
                case 6:
                    label1.Text = "15 ����";
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

            Poisk p = new Poisk();
            table.Rows.Add($"������� ����� ����������", new DateTime(2004, 11, 16), $"��.{i.Statya} ���", $"� {i.NumKam}", new Button());

            foreach (var i in Data.data)
            {
                if(i.FirstName == p.FirstName
                    && i.SecondName == p.SecondName
                    && i.Statya == p.Statya
                    && i.NumKam == p.NumKam)
                table.Rows.Add($"{i.SecondName} {i.FirstName} {i.ThirdName}", i.DateNar, $"��.{i.Statya} ���", $"� {i.NumKam}", new Button());
            }

            dataGridView1.DataSource = table;
        }

        private void checkKamNum_CheckedChanged(object sender, EventArgs e)
        {
            KamNum.Enabled = !checkKamNum.Checked;
        }

        private void checkDataNar_CheckedChanged(object sender, EventArgs e)
        {
            DataNarTimePicker.Enabled = !checkDataNar.Checked;
        }

        private void checkDataUvyaz_CheckedChanged(object sender, EventArgs e)
        {
            DataUvyazTimePicker.Enabled = !checkDataUvyaz.Checked;
        }

        private void PrizvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImyaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PBTextBox_TextChanged(object sender, EventArgs e)
        {

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
            Random r = new Random();
            int y = r.Next(1950, 1996);
            int m = r.Next(1, 13);
            int d = 0;
            if (m % 2 == 1 && m <= 7 || m % 2 == 0 && m >= 8)
            {
                d = r.Next(1, 32);
            }
            else if (m == 2) d = r.Next(1, y % 4 == 0 ? 30 : 29);
            else d = r.Next(1, 31);

            return new DateTime(y, m, d);

        }
        static DateTime DU()
        {
            Random r = new Random();
            int y = r.Next(1990, 2023);
            int m = r.Next(1, 13);
            int d = 0;
            if (m % 2 == 1 && m <= 7 || m % 2 == 0 && m >= 8)
            {
                d = r.Next(1, 31);
            }
            else if (m == 2) d = r.Next(0, y % 4 == 0 ? 30 : 29);
            else d = r.Next(1, 31);

            return new DateTime(y, m, d);

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

    class Poisk : Form1
    {
        public int[] ids;
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

        public Poisk()
        {

            SecondName = PrizvTextBox.Text;
            FirstName = ImyaTextBox.Text;
            ThirdName = PBTextBox.Text;

            Stat = statField.Text;

            Statya = Convert.ToInt32(statyaField.Text);

            DateNar = DataNarTimePicker.Value;

            DateUvyaz = DataUvyazTimePicker.Value;

            Stat = statField.Text.ToString();

            switch (termBar1.Value)
            {
                case 1:
                    Term = 1;
                    break;
                case 2:
                    Term = 2;
                    break;
                case 3:
                    Term = 3;
                    break;
                case 4:
                    Term = 5;
                    break;
                case 5:
                    Term = 8;
                    break;
                case 6:
                    Term = 15;
                    break;
            }

            NumKam = (int)KamNum.Value;

            Ierarh = ierarhField.Text;

            Haract = haractField.Text;

            string r;

        }
    }
}