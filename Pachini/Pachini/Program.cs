using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pachini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Семья Пачини приветствует вас!");
            Console.WriteLine("Нажмите 1, чтобы узнать имя Дона, нажмите 2 чтобы узнать имя Консильери");
            int p = Int32.Parse(Console.ReadLine());
            if (p==1)
            {
                Console.WriteLine("Артем");
            }
            else if (p == 2)
            {
                Console.WriteLine("Левон");
            }
            else
            {
                Console.WriteLine("Олень");
            }
            Console.ReadKey();
        }
    }
}
