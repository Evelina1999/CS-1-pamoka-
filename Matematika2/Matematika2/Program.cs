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
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            double skaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(skaicius1 * skaicius2);
            Console.WriteLine(skaicius1 / skaicius2);
            Console.WriteLine(skaicius1 + skaicius2);
            Console.WriteLine(skaicius1 - skaicius2);
            Console.ReadLine();

        }
    }
}
