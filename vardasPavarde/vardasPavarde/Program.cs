using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vardasPavarde
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas, pavarde;

            Console.Write("Iveskite varda: ");
            vardas = Console.ReadLine();

            Console.Write("Iveskite pavarde: ");
            pavarde = Console.ReadLine();

            Console.WriteLine(vardas + " " + pavarde);

            Console.ReadLine();
        }
    }
}
