using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staciakampioPlotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double staciakampioIlgis, staciakampioPlotis;

            Console.Write("Iveskite staciakampio ilgi: ");
            staciakampioIlgis = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite staciakampio ploti: ");
            staciakampioPlotis = Convert.ToDouble(Console.ReadLine());

            double staciakampioPlotas = staciakampioIlgis * staciakampioPlotis;

            Console.WriteLine("Staciakampio plotas = " + staciakampioPlotas);

            Console.ReadLine();
        }
    }
}
