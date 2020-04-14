using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devintaIrDesimta
{
    class Program
    {
        static void Main(string[] args)
        {
            string miestoPavadinimas = "Majamis";
            string gatvesPavadinimas = "Kalifornijos gatve";
            string namoNumeris = "64";
            DateTime pastatymoMetai = new DateTime(2017, 01, 01);
            DateTime statybuPradzia = new DateTime(2015);
            
            Console.WriteLine(miestoPavadinimas);
            Console.WriteLine(gatvesPavadinimas);
            Console.WriteLine(namoNumeris);
            Console.WriteLine(pastatymoMetai);
            Console.ReadLine();
        }
    }
}
