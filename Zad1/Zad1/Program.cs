using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Podaj temp. w stopniach Celcjusza");
            C = double.Parse(Console.ReadLine());
            F = (9.0 / 5.0 * C) + 32;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
