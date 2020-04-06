using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kintamujuVidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaiciusVienas = 3;
            double skaiciusDu = 5;
            double skaiciusTrys = 13;

            double vidurkis = (skaiciusVienas + skaiciusDu + skaiciusTrys) / 3;

            Console.Write("Vidurkis: " + vidurkis);

            Console.ReadLine();
        }
    }
}
