using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    internal class Data
    {
        public static List<Person> data = new();

        private static string file = @"Documents\data.doc";
        private static string text = File.ReadAllText(file);

        public static void ReadData()
        {
            string[] pers = text.Split(';');

            foreach (string s in pers)
            {
                s.Replace("\n", "").Trim();

                if (s.Length > 0)
                {
                    string[] i = s.Split(',');
                    string[] a = i[1].Replace(" 0:00:00", "").Split(' ');
                    string[] b = i[4].Replace(" 0:00:00", "").Split(' ');

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
                        date2, Convert.ToInt32(i[5]), i[6].Trim(), Convert.ToInt32(i[7]),
                        i[8], i[9]);

                    data.Add(p);
                }
            }
        }

        public static void AddToData(Person p)
        {
            string res = $"\r\n{p.SecondName} {p.FirstName} {p.ThirdName}" +
                $",{p.BirthDay.Year} {p.BirthDay.Month} {p.BirthDay.Day}," +
                $"{p.Gender},{p.Article}," +
                $"{p.ImprisDate.Year} {p.ImprisDate.Month} {p.ImprisDate.Day}," +
                $"{p.Term},{p.Family},{p.NumKam},{p.Ierarh},{p.Haract};";

            WriteData(text + res);
        }

        private static void WriteData(string text)
        {
            using (FileStream fs = File.Create(file))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
            }

            Data.ReadData();
        }

        public static void DelPers(string? name, DateTime birthday,
            int numkam, int term)
        {
            string text = "";

            foreach(var p in data)
            {
                if ((name.Contains($"{p.SecondName} {p.FirstName} {p.ThirdName}")
                    && numkam == p.NumKam)
                    && term == p.Term
                    && birthday == p.BirthDay)
                    continue;

                text += $"{p.SecondName} {p.FirstName} {p.ThirdName}" +
                    $",{p.BirthDay.Year} {p.BirthDay.Month} {p.BirthDay.Day}," +
                    $"{p.Gender},{p.Article}," +
                    $"{p.ImprisDate.Year} {p.ImprisDate.Month} {p.ImprisDate.Day}," +
                    $"{p.Term},{p.Family},{p.NumKam},{p.Ierarh},{p.Haract};";
            }
            WriteData(text);
        }
    }
}
