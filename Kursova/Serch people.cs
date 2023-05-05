﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Poisk : People
    {
        /*public static string FirstName { get; set; } = "-";
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
        public static string Haract { get; set; } = "-";*/

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
