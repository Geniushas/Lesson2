using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciaiEiluteje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            double skaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}");
            
            Console.ReadLine();
        }
    }
}
