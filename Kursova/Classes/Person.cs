using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Person
    {
        public static Person exempl = new();

        public string FirstName { get; set; } = "";
        public string SecondName { get; set; } = "";
        public string ThirdName { get; set; } = "";
        public DateTime DateNar { get; set; } = new(1900, 01, 01);
        public string Stat { get; set; } = "Усі";
        public int Statya { get; set; } = -1;
        public DateTime DateUvyaz { get; set; } = new(1900, 01, 01);
        public int Term { get; set; } = -1;
        public string Rod { get; set; } = "";
        public int NumKam { get; set; } = -1;
        public string Ierarh { get; set; } = "-";
        public string Haract { get; set; } = "-";

        public Person() { }

        public Person(string name, DateTime dateNar, string stat,
            int statya, DateTime dateUvyaz, int term, string rodInd,
            int numKam, string ierarh, string haract) : base()
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


        public List<Person> Search()
        {
            List<Person> list = new();
            DateTime defTime = new(1900, 01, 01);

            foreach (var i in Data.data)
            {
                if ((i.FirstName.ToUpper().Contains(FirstName.ToUpper())
                    || FirstName == "")
                    && (i.SecondName.ToUpper().Contains(SecondName.ToUpper())
                    || SecondName == "")
                    && (i.ThirdName.ToUpper().Contains(ThirdName.ToUpper())
                    || ThirdName == "")
                    && (DateNar == i.DateNar
                    || DateNar == defTime)
                    && (DateUvyaz == i.DateUvyaz
                    || DateUvyaz == defTime)
                    && (Ierarh == i.Ierarh
                    || Ierarh == "-")
                    && (Haract == i.Haract
                    || Haract == "-")
                    && (Stat == i.Stat
                    || Stat == "Усі")
                    && (Statya == i.Statya
                    || Statya == -1)
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
    }//Класс для створення персонажів для в'язниці
}
