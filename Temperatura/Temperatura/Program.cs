using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsijai;
            int kelvinai;
            int farenheitai;

            Console.WriteLine("parasykite temperatura laipsniais C");

            celsijai= Convert.ToInt32(Console.ReadLine());

            kelvinai = celsijai + 273;
            farenheitai = celsijai * 18 / 10 + 32;

            Console.WriteLine("Temperatura Kelvinais: {0}", kelvinai = celsijai + 273);
            Console.WriteLine("Temperatura Farenheitais: {0}", farenheitai = celsijai * 18 / 10 + 32);


            Console.ReadLine();

           
            
        }
    }
}
