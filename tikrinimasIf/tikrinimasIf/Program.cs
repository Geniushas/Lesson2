using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tikrinimasIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string eilute;

            Console.WriteLine("Iveskite teksto eilute:");
            eilute = Console.ReadLine();

            if (eilute == "")
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            Console.ReadLine();
        }
    }
}
