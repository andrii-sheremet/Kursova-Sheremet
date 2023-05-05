﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal static class Data
    {
        public static List<Person> data = new();
        private static string file = @"C:\Users\User\Desktop\Курсова\VS\Kursova\Kursova\Documents\data.doc";
        private static string text = File.ReadAllText(file);

        public static void ReadData()
        {
            string[] pers = text.Split(';');

            foreach (string s in pers)
            {
                if (s.Length > 0)
                {
                    s.Replace("\r\n", "").Trim();
                    string[] i = s.Split(',');
                    string[] a = i[1].Split(' ');
                    string[] b = i[4].Split(' ');
                    DateTime date1 = new(
                        Convert.ToInt32(a[0]),
                        Convert.ToInt32(a[1]),
                        Convert.ToInt32(a[2])
                        );

                    DateTime date2 = new(
                        Convert.ToInt32(b[0]),
                        Convert.ToInt32(b[1]),
                        Convert.ToInt32(b[2])
                        );
                    Person p = new(i[0], date1, i[2], Convert.ToInt32(i[3]),
                        date2, Convert.ToInt32(i[5]), i[6], Convert.ToInt32(i[7]),
                        i[8], i[9]);
                    data.Add(p);
                }
            }
        }
        public static void AddToData(Person p)
        {
            

            string name, DateTime dateNar, string stat,
            int statya, DateTime dateUvyaz, int term, string rodInd,
            int numKam, string ierarh, string haract
        }
    }
}