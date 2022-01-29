using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurkis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite 4 skaicius");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            double skaicius3 = Convert.ToDouble(Console.ReadLine());
            double skaicius4 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Vidurkis: {0}", (skaicius1 + skaicius2 + skaicius3 + skaicius4) / 4 );
            Console.ReadLine();

            



            
        }
    }
}
