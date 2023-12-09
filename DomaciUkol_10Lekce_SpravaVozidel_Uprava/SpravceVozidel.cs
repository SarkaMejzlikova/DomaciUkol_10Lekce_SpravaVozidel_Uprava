using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_10Lekce_SpravaVozidel_Uprava
{
    public class SpravceVozidel
    {
        List<Vozidlo> vozidla = new List<Vozidlo>();

        public void NoveAuto()
        {
            Console.WriteLine("Zadejte následující údaje:");

            Console.Write("Model: ");
            string m = Console.ReadLine();

            Console.Write("Rok výroby: ");
            string rokV = Console.ReadLine();
            int rv;
            while (!Int32.TryParse(rokV, out rv) || rv < 1989 || rv > DateTime.Now.Year)
            {
                Console.WriteLine("Nezadali jste správný rok výroby, zkuste to znovu.");
                rokV = Console.ReadLine();
            }

            Console.Write("Barva: ");
            string b = Console.ReadLine();

            Console.Write("Počet dveří: ");
            string pocetD = Console.ReadLine();
            int pd;
            while (!Int32.TryParse(pocetD, out pd) || pd < 3 || pd > 5)
            {
                Console.WriteLine("Nezadali jste správný počet dveří, zkuste to znovu.");
                pocetD = Console.ReadLine();
            }

            Automobil auto = new Automobil(model: m, pocetDveri: pd, rokVyroby: rv, barva: b);
            vozidla.Add(auto);
        }

        public void NovyMotocykl()
        {
            Console.WriteLine("Zadejte následující údaje:");

            Console.Write("Typ Motocyklu: ");
            string tm = Console.ReadLine();

            Console.Write("Rok výroby: ");
            string rokV = Console.ReadLine();
            int rv;
            while (!Int32.TryParse(rokV, out rv) || rv < 1989 || rv > DateTime.Now.Year)
            {
                Console.WriteLine("Nezadali jste správný rok výroby, zkuste to znovu.");
                rokV = Console.ReadLine();
            }

            Console.Write("Barva: ");
            string b = Console.ReadLine();

            Console.Write("Počet kol: ");
            string pocetK = Console.ReadLine();
            int pk;
            while (!Int32.TryParse(pocetK, out pk) || pk < 1 || pk > 3)
            {
                Console.WriteLine("Nezadali jste správný počet kol, zkuste to znovu.");
                pocetK = Console.ReadLine();
            }

            Console.Write("Objem motoru: ");
            string objemM = Console.ReadLine();
            int om;
            while (!Int32.TryParse(objemM, out om) || om < 0)
            {
                Console.WriteLine("Nezadali jste správný objem motoru, zkuste to znovu.");
                objemM = Console.ReadLine();
            }

            Motocykl moto = new Motocykl(typMotockylu: tm, pocetKol: pk, rokVyroby: rv, barva: b, objemMotoru: om );
            vozidla.Add(moto);
        }

        public void VypisVozidel()
        {
            Console.WriteLine("Seznam vozidel je následující:\n");
            foreach (var v in vozidla)
            {
                if (v is Automobil)
                {
                    Console.WriteLine((Automobil)v);
                }
                else if (v is Motocykl)
                {
                    Console.WriteLine((Motocykl)v);
                }

            }
        }

    }
}
