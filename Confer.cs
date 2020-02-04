using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Confer
    {
        static public void Con() {
            DateTime date = new DateTime();

            Console.WriteLine(" ");
            Console.Write("Введите название конференции: ");
            string title = Console.ReadLine();
            
            Console.Write("Введите место проведения: ");
            string mest = Console.ReadLine();

            Console.WriteLine("Введите дату проведения (DD.MM.YYYY): ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            date = new DateTime(year, month, day);
            string dateString = String.Format("{0:dd/MM/yyyy}", date);

            Confer.output( title, mest, dateString);
        }

        static public void output(string title, string mest, string dateString) 
        {
            int p = 0;
            string q = $"Конференция.txt";

            FileInfo file = new FileInfo(q);
            if (file.Exists)
            {
                ++p;
                string u = $"Конференция{p}.txt";
                q = u;
            }

            StreamWriter sw = new StreamWriter(q);
            sw.WriteLine($"Название конференции: {title}");
            sw.WriteLine($"Место проведения: {mest}");
            sw.WriteLine($"Дата проведения: {dateString}");
            sw.Close();
        }
    }
}