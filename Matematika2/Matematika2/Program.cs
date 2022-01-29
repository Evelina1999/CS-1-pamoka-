using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu 1");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu 2");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu sandauga yra: {0}", skaicius1 * skaicius2);
            Console.WriteLine("Skaiciu dalyba yra: {0}", skaicius1 / skaicius2);
            Console.WriteLine("Skaiciu suma yra: {0}", skaicius1 + skaicius2);
            Console.WriteLine("skaiciu skirtumas: {0}", skaicius1 - skaicius2);
            Console.ReadLine();

        }
    }
}
