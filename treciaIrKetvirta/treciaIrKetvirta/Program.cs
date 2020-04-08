using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciaIrKetvirta
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas = "Andriaus Petrausko mokykla";
            string kursoPavadinimas = "C astraus pagrindai";
            int studentuSkaicius = 3;
            DateTime siandienosData = DateTime.Today;

            Console.WriteLine("Mokykla - " + mokyklosPavadinimas);
            Console.WriteLine("Kurso pavadinimas - " + kursoPavadinimas);
            Console.WriteLine("Studentu skaicius - " + studentuSkaicius);
            Console.WriteLine("Siandienos data - " + siandienosData.ToString("D"));

            DateTime kursoPradzia = new DateTime(2020, 01, 01);
            DateTime kursoPabaiga = new DateTime(2020, 05, 06);
            Console.WriteLine("Kurso pradzia - " + kursoPradzia.ToString("D"));
            Console.WriteLine("Kurso pabaiga - " + kursoPabaiga.ToString("D"));

            double kursoTrukmeDienomis = kursoPabaiga.Subtract(kursoPradzia).TotalDays;
            Console.WriteLine("Kurso trukme dienomis - " + kursoTrukmeDienomis);

            double kursoTrukmeSavaitemis = kursoTrukmeDienomis / 7;
            Console.WriteLine("Kurso trukme savaitemis (tiksliai) - " + kursoTrukmeSavaitemis);



            Console.ReadLine();
        }
    }
}
