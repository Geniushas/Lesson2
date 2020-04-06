using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiksmuIsvestis
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaiciusVienas, skaiciusDu;
            double suma, skirtumas, daugyba, dalyba;

            Console.Write("Parasykite pirma skaiciu: ");
            skaiciusVienas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Parasykite antra skaiciu: ");
            skaiciusDu = Convert.ToDouble(Console.ReadLine());
            
            suma = skaiciusVienas + skaiciusDu;
            skirtumas = skaiciusVienas - skaiciusDu;
            daugyba = skaiciusVienas * skaiciusDu;
            dalyba = skaiciusVienas / skaiciusDu;

            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Skirtumas = " + skirtumas);
            Console.WriteLine("Daugyba = " + daugyba);
            Console.WriteLine("Dalyba = " + dalyba);

            Console.ReadLine();
        }
    }
}
