using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nulisTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius;

            Console.Write("Iveskite skaiciu: ");
            skaicius = Convert.ToDouble(Console.ReadLine());

            if(skaicius < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }
    }
}
