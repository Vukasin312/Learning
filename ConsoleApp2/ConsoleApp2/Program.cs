using System;
using System.Data.Common;
using System.Net.NetworkInformation;
using System.Net.Security;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = "";
            string prezime = "";
            string pol = "";
            int godine;
            int klasa;
            int sediste;

            Console.WriteLine("Unesite pol putnika: Muski/Zenski");
            pol = Console.ReadLine();

            if (pol == "Musko" || pol == "Muski")
            {
                pol = "M";
            }
            else
            {
                pol = "Z";
            }

            Console.Write("Unesite ime putnika: ");
            ime = Console.ReadLine();

            Console.Write("Unesite prezime putnika: ");
            prezime = Console.ReadLine();

            Console.Write("Koliko godina ima putnik: ");
            godine = Convert.ToInt32(Console.ReadLine());

            Console.Write("Klasa putnika: 1/2/3 ");
            klasa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sediste putnika: ");
            sediste = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Dobro dosli u AIRLINES SIMIC");
            Console.WriteLine(" Ime: " + ime + "\n Prezime: " + prezime + "\n Godine: " + godine + "\n Pol: " + pol);
            Console.WriteLine("Vase sediste je broj: " + sediste + " - Klasa: " + klasa);
            Console.ReadKey();
        }
    }
}


