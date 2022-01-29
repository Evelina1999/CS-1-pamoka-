using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_antra_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Rectangle r1 = new Rectangle();
            r.Acceptdetails(3.5d, 5.5d);
            r.Display();
            r1.Acceptdetails(1.5d, 4.4d);
            r1.Display();
            Console.ReadLine();
        }

    }
    class Rectangle
    {
        //member veriables
        private double lenght;
        private double width;

        public void Acceptdetails(double inLenght, double inWidht)
        {
            lenght = inLenght;
            width = inWidht;
        }
        public double GetArea()
        {
            return lenght * width;
        }
        public void Display()
        {
            Console.WriteLine("Lenght:{0}", lenght);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }

}