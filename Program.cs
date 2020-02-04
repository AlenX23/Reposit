using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kyrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Confer t = new Confer();
            Invol t1 = new Invol();
            Scientist t2 = new Scientist();
            int k = 0;

            Console.Write("Введите количество конференций: ");
            int n = int.Parse(Console.ReadLine());

            while (k < n) 
            {
                Confer.Con();

                Console.Write("Введите количество участников: ");
                int n1 = int.Parse(Console.ReadLine());
                int k1 = 0;

                while (k1 < n1) 
                {
                    Invol.inv();
                    Scientist.scien();
                    k1++;
                }
                k++;
            }  
            Console.ReadKey();          
        }
    }
}