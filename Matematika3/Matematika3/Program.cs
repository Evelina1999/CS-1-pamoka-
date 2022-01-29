using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu A");
            int skaiciusA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu B");
            int skaiciusB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu C");
            int skaiciusC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skaiciusA + skaiciusB * skaicius c yra lygu:");
            Console.WriteLine((skaiciusA + skaiciusB) * skaiciusC);
            Console.WriteLine("skaiciusA * skaiciusC + skaiciusB * skaiciusC yra lygu:");
            Console.WriteLine(skaiciusA * skaiciusC + skaiciusB * skaiciusC);
            Console.ReadLine();

        }
    }
}
