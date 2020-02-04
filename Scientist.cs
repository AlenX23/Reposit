using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Scientist
    {
        static public void scien()
        {
            Console.Write("Введите Фамилию Имя Отчество : ");
            string name = Console.ReadLine();

            Console.Write("Выберите учёную степень(Кандидат наук/Доктор наук): ");
            string s = Console.ReadLine();

            Console.Write("Введите страну: ");
            string country = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.Write("Введите название организации, к которой прикреплен ученый: ");
            string organization = Console.ReadLine();

            Scientist.output(name, s, country, city, organization);
        }

        static public void output(string name,string s, string country, string city, string organization)
        {
            int p = 0;
            string q = $"Ученый.txt";

            FileInfo file = new FileInfo(q);
            if (file.Exists)
            {
                ++p;
                string u = $"Ученый{p}.txt";
                q = u;
            }

            StreamWriter sw = new StreamWriter(q);
            sw.WriteLine($"Фамилия Имя Отчество: {name}");
            sw.WriteLine($"Учёная степень: {s}");
            sw.WriteLine($"Страна: {country}");
            sw.WriteLine($"Город: {city}");
            sw.WriteLine($"Название организации: {organization}");
            sw.Close();
        }

    }
}