using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja mase w kg");
            int masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost w metrach:");
            double wzrost = double.Parse(Console.ReadLine());
            double BMI = masa / (wzrost * wzrost);
            Console.WriteLine("Twoje BMI to {0}", BMI);

            Console.ReadKey();
        }
    }
}
