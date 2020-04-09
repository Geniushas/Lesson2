using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trueFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu A: ");
            double skaiciusA = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Iveskite skaiciu B: ");
            double skaiciusB = Convert.ToDouble(Console.ReadLine());

            if(skaiciusA == skaiciusB)
            {
                Console.WriteLine("(A = B) - True");
            }
            else
            {
                Console.WriteLine("(A = B) - False");
            }

            Console.ReadLine();
        }
    }
}
