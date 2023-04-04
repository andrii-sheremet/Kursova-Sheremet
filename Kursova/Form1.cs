using System.Data;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            Poisk.FirstName = Poisk.SecondName = Poisk.ThirdName = "-";

            Poisk.DateNar = new(1900, 01, 01);

            Poisk.Stat = "��";

            Poisk.Statya = -1;

            Poisk.DateUvyaz = new(1900, 01, 01);

            Poisk.Term = -1;

            Poisk.Rod = "";

            Poisk.NumKam = -1;

            Poisk.Ierarh = "";

            Poisk.Haract = "";

        }
        private int term = 1;
        private void termBar1_Scroll(object sender, EventArgs e)
        {
            switch (termBar1.Value)
            {
                case 1:
                    label1.Text = "1 ����";
                    term = 1;
                    break;
                case 2:
                    label1.Text = "2 ����";
                    term = 2;
                    break;
                case 3:
                    label1.Text = "3 ����";
                    term = 3;
                    break;
                case 4:
                    label1.Text = "5 ����";
                    term = 5;
                    break;
                case 5:
                    label1.Text = "8 ����";
                    term = 8;
                    break;
                case 6:
                    label1.Text = "15 ����";
                    term = 15;
                    break;
            }
            Poisk.Term = term;
        }


        private void findButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("ϲ�", typeof(string));
            table.Columns.Add("���� ���.", typeof(DateTime));
            table.Columns.Add("������", typeof(string));
            table.Columns.Add("������", typeof(string));

            Person p = Poisk.MembIn();

            foreach (var i in Data.data)
            {
                Poisk.Go(i);

                if (i.FirstName == Poisk.FirstName
                    && i.SecondName == Poisk.SecondName
                    && i.ThirdName == Poisk.ThirdName
                    && i.DateNar == Poisk.DateNar
                    && i.DateUvyaz == Poisk.DateUvyaz
                    && i.Statya == Poisk.Statya
                    && i.Stat == Poisk.Stat
                    && i.Rod == Poisk.Rod
                    && i.Haract == Poisk.Haract
                    && i.Ierarh == Poisk.Ierarh
                    && i.NumKam == Poisk.NumKam
                    && i.Term == Poisk.Term)
                {
                    table.Rows.Add
                        ($"{i.SecondName} {i.FirstName} {i.ThirdName}",
                        i.DateNar, $"��.{i.Statya} ���", $"� {i.NumKam}");
                }

                Poisk.MembOut(p);
            }

            dataGridView1.DataSource = table;
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
            if (statyaField.Text == "-" || statyaField.Text == "")
            {
                Poisk.Statya = -1;
            }
            else
            {
                Poisk.Statya = Convert.ToInt32(statyaField.Text[3..]);
            }
        }

        private void statField_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (statField.SelectedIndex)
            {
                case 0:
                    Poisk.Stat = "��";
                    break;
                case 1:
                    Poisk.Stat = "M";
                    break;
                case 2:
                    Poisk.Stat = "W";
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

        private void KamNum_ValueChanged(object sender, EventArgs e)
        {
            Poisk.NumKam = Convert.ToInt32(KamNum.Value);
        }



        //TimePickers
        private void DataNarTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Poisk.DateNar = DataNarTimePicker.Value;
        }

        private void DataUvyazTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Poisk.DateUvyaz = DataUvyazTimePicker.Value;
        }




        //��������
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
        }
        public string rod;
        private void checkRod_CheckedChanged(object sender, EventArgs e)
        {
            checkMama.Enabled = checkKid.Enabled
                = checkDad.Enabled = checkBro.Enabled
                = checkHusb.Enabled = !checkRod.Checked;

            if (checkRod.Checked)
            {
                Poisk.Rod = "";
            }
            else
            {
                Poisk.Rod = rod;
            }
        }
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
        }
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
        }
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
        }
        private void checkMama_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMama.Checked)
            {
                rod += " ����";
            }
            else
            {
                rod.Replace(" ����", "");
            }
        }
        private void checkDad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDad.Checked)
            {
                rod += " ������";
            }
            else
            {
                rod.Replace(" ������", "");
            }
        }
        private void checkKid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKid.Checked)
            {
                rod += " ĳ��";
            }
            else
            {
                rod.Replace(" ĳ��", "");
            }
        }
        private void checkHusb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHusb.Checked)
            {
                rod += " ������/�������";
            }
            else
            {
                rod.Replace(" ������/�������", "");
            }
        }
        private void checkBro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBro.Checked)
            {
                rod += " ����/������";
            }
            else
            {
                rod.Replace(" ����/������", "");
            }
        }
    }
    class Data
    {
        public static List<Person> data = new()
            {
                new Person( "������ ��������� ������������", DN(), "W", 152, DU(), 3, "���� ����", 1, "������", "����������"),
                new Person( "���������� ����� ³��������", DN(), "M", 156, DU(), 5, "������ ���� ĳ��", 3, "������", "س����"),
                new Person( "��������� ������ �������������", DN(), "M", 185, DU(), 8, "���� ����", 4, "������", "��������"),
                new Person( "�������� ������ ��������", DN(), "M", 152, DU(), 3, "���� ĳ��", 9, "�����", "��������"),
                new Person( "�������� ����� ���������", DN(), "M", 121, DU(), 8, "���� ĳ��", 2, "������", "����������"),
                new Person( "��������� ������ ���������", DN(), "M", 125, DU(), 3, "���� ����", 3, "������", "��������"),
                new Person( "��������� ������ ���������", DN(), "W", 115, DU(), 15, "���� ĳ��", 8, "�����", "��������"),
                new Person( "������� ³���� ��������", DN(), "M", 156, DU(), 5, "����", 7, "�����", "��������"),
                new Person( "������� ��� ��������", DN(), "W", 151, DU(), 1, "����", 4, "������", "����������"),
                new Person( "������ ����� �����볿���", DN(), "W", 115, DU(), 15, "����", 5, "�����", "����������"),
                new Person( "�������� ���� ³��������", DN(), "M", 185, DU(), 8, "���� ����", 10, "������", "��������"),
                new Person( "�������� ���� �������������", DN(), "M", 125, DU(), 3, "������ ���� ĳ��", 6, "�����", "��������"),
                new Person( "��������� ������ ���������", DN(), "M", 121, DU(), 8, "���� ����", 9, "������", "س����"),
                new Person( "��������� ���� ������������", DN(), "M", 115, DU(), 15, "���� ������ ĳ��", 5, "�����", "��������"),
                new Person( "������ ����� �������", DN(), "M", 126, DU(), 2, "������", 6, "������", "��������"),
                new Person( "��������� ������ �������������", DN(), "M", 156, DU(), 5, "���� ������ ĳ��", 8, "�����", "��������"),
                new Person( "�������� ��� �������", DN(), "W", 121, DU(), 8, "������", 9, "�����", "��������"),
                new Person( "������� ���� ³��볿���", DN(), "W", 122, DU(), 3, "���� ����", 10, "����������", "��������"),
                new Person( "������� ��������� �����������", DN(), "M", 125, DU(), 3, "���� ������ ĳ��", 10, "�����", "س����"),
                new Person( "�������� ����� ����������", DN(), "M", 122, DU(), 3, "���� ����", 1, "����������", "����������")
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

        public Person(string name, DateTime dateNar, string stat,
            int statya, DateTime dateUvyaz, int term, string rod,
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
        public static void Go(Person p)
        {

            FirstName = FirstName == "-" || FirstName == ""
                ? p.FirstName : FirstName;

            SecondName = SecondName == "-" || SecondName == ""
                ? p.SecondName : SecondName;

            ThirdName = ThirdName == "-" || ThirdName == ""
                ? p.ThirdName : ThirdName;

            DateNar = DateNar == new DateTime(1900, 01, 01)
                ? p.DateNar : DateNar;

            Stat = Stat == "��" ? p.Stat : Stat;

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
    }
}