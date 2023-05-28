using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Person
    {
        public static Person exampl = new();
        // Екземпляр класу, в якому зберігаються усі дані фільтру для пошуку.

        public SortedList<int, string> fam = new() { { 0, "" } };
        // Сортований лист в якому зберігається інформація про родину даного в'язня.

        public string FirstName { get; set; } = "";
        // Властивість для ім'я.

        public string SecondName { get; set; } = "";
        // Властивість для прізвища.

        public string ThirdName { get; set; } = "";
        // Властивість для по батькові.

        public DateTime BirthDay { get; set; } = new(1900, 01, 01);
        // Властивість для дати народження.

        public string Gender { get; set; } = "Усі";
        // Властивість для статі.

        public int Article { get; set; } = -1;
        // Властивість для статті.

        public DateTime ImprisDate { get; set; } = new(1900, 01, 01);
        // Властивість для дати ув'язнення.

        public int Term { get; set; } = -1;
        // Властивість для терміну ув'язнення.

        public string Family { get; set; } = "";
        // Властивість для інформації про родину.

        public int NumKam { get; set; } = -1;
        // Властивість для номера кімнати.

        public string Ierarh { get; set; } = "-";
        // Властивість для інформації про місце в ієрархії.

        public string Haract { get; set; } = "-";
        // Властивість для інформації про особливість характеру.

        public Person() { }

        public Person(string name, DateTime birthday, string gender,
            int article, DateTime imprisDate, int term, string famInd,
            int numKam, string ierarh, string haract)
        {

            string[] n = name.Split(' ');
            SecondName = n[0];
            FirstName = n[1];
            ThirdName = n[2];

            BirthDay = birthday;
            Gender = gender;
            Article = article;
            ImprisDate = imprisDate;
            Term = term;
            Family = famInd;
            NumKam = numKam;
            Ierarh = ierarh;
            Haract = haract;
        }

        public List<Person> Search()
        {
            List<Person> list = new();
            DateTime defTime = new(1900, 01, 01);

            foreach (var i in Data.data)
            {
                bool famBool = false;
                foreach (KeyValuePair<int, string> memb in fam)
                {
                    famBool = i.Family.Contains(memb.Value);

                    if (!famBool) break;
                }

                if ((i.FirstName.ToUpper().Contains(FirstName.ToUpper())
                    || FirstName == "")
                    && (i.SecondName.ToUpper().Contains(SecondName.ToUpper())
                    || SecondName == "")
                    && (i.ThirdName.ToUpper().Contains(ThirdName.ToUpper())
                    || ThirdName == "")
                    && (BirthDay == i.BirthDay
                    || BirthDay == defTime)
                    && (ImprisDate == i.ImprisDate
                    || ImprisDate == defTime)
                    && (Ierarh == i.Ierarh
                    || Ierarh == "-")
                    && (Haract == i.Haract
                    || Haract == "-")
                    && famBool
                    && (Gender == i.Gender
                    || Gender == "Усі")
                    && (Article == i.Article
                    || Article == -1)
                    && (NumKam == i.NumKam
                    || NumKam == -1)
                    && (Term == i.Term
                    || Term == -1))
                {
                    list.Add(i);
                }
            }
            return list;
        }
        // Метод, що здійснює пошук по базі даних та шукає в'язнів, що підходять заданим критеріям.

    }//Класс для створення персонажів для в'язниці
}
