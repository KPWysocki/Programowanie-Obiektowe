using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,delta;
            Console.WriteLine("Podaj współczynniki a,b i c rownania ax^2+bx+c=0 \n a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Delta wynosi");
            delta = (b * b) - 4 * a * c;
            Console.WriteLine(delta);
            Console.ReadKey();
        }
    }
}

