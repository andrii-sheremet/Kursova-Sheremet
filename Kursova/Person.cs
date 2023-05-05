using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Person : People
    {

        public new string FirstName { get; set; } = "-";
        public new string SecondName { get; set; } = "-";
        public new string ThirdName { get; set; } = "-";
        public new DateTime DateNar { get; set; } = new(1900, 01, 01);
        public new string Stat { get; set; } = "Усі";
        public new int Statya { get; set; } = -1;
        public new DateTime DateUvyaz { get; set; } = new(1900, 01, 01);
        public new int Term { get; set; } = -1;
        public new string Rod { get; set; } = "";
        public new int NumKam { get; set; } = -1;
        public new string Ierarh { get; set; } = "-";
        public new string Haract { get; set; } = "-";


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
    }//Класс для створення персонажів для в'язниці
}
