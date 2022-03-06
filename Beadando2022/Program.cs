using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajlnev = "fogado.txt";
            bool vanilyen;

            AdatFeldolgozas fs = new AdatFeldolgozas();

            Console.WriteLine("1. feladat: fájl beolvasás és adattárolás");

            fs.FajlBeolvasas(fajlnev);

            Console.WriteLine("\n2. feladat");
            Console.WriteLine("Foglalások száma: {0}", fs.AdatokSzama());

            Console.WriteLine("\n3. feladat");
            Console.Write("Adjon meg egy nevet: ");
            string benev = Console.ReadLine();
            Console.Write(fs.TanarKeres(benev));

            //do
            //{
            //    Console.Write("Adjon meg egy nevet: ");
            //    string benev = Console.ReadLine();
            //    vanilyen = fs.TanarKeres(benev);
            //    if (vanilyen == false) Console.WriteLine("\nNincs ilyen nevű tanár, adja meg újra a nevet!");
            //} while (vanilyen);






            Console.ReadLine();
        }
    }
}
