using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minusPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite pirma skaiciu: ");
            double skaiciusVienas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite antra skaiciu: ");
            double skaiciusDu = Convert.ToDouble(Console.ReadLine());

            skaiciusVienas++;
            skaiciusDu--;
        }
    }
}
