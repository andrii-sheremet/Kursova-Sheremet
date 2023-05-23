using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class People
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

    }//Класс для створення персонажів для в'язниці
}
