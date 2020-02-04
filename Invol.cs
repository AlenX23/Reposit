using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Invol
    {
        static public void inv()
        {
            Console.WriteLine(" ");
            Console.Write("Тип участия: ");
            string invo = Console.ReadLine();
            Invol.proverka(invo);

            Console.Write("Тема доклада: ");
            string theme = Console.ReadLine();
            Invol.proverka(theme);

            Console.Write("Публикация(Да-1/Нет-0): ");
            int a = int.Parse(Console.ReadLine());

            string l = (a == 1) ? ("Да") : ("Нет");

            Invol.output(invo, theme, l);
        }

        static public void proverka(string s)
        {
            while (String.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Error! Введите снова:");
                string inv = Console.ReadLine();
                s = inv;
            }
        }

        static public void output(string invo, string theme, string l)
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

            StreamWriter sw = new StreamWriter(q, true);
            sw.WriteLine("");
            sw.WriteLine($"Тип участия: {invo}");
            sw.WriteLine($"Тема доклада: {theme}");
            sw.WriteLine($"Публикация: {l}");
            sw.Close();
        }
    }
}