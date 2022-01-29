using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli");
            int simbolis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0} \n{0} {0}\n{0} {0}\n{0} {0}\n{0}{0}{0}", simbolis);
            Console.ReadLine();
        }

    }
}
