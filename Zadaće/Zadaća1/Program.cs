using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLientCode.RunDemo();
        }

        public static class CLientCode
        {
            public static void RunDemo()
            {
                Banka banka = new Banka();

                Korisnik korisnik1 = new Korisnik();
                korisnik1.Ime = "Ana";
                korisnik1.Prezime = "Anić";
                korisnik1.DatumRodjenja = new DateTime(12 / 3 / 2003);
                korisnik1.Email = "ana.anic@mail.com";
                korisnik1.Adresa = "Joze Ivakića 34";
                korisnik1.Stanje = 50;

                Korisnik korisnik2 = new Korisnik();
                korisnik2.Ime = "Pero";
                korisnik2.Prezime = "Perić";
                korisnik2.DatumRodjenja = new DateTime(3 / 12 / 2003);
                korisnik2.Email = "pero.peric@mail.com";
                korisnik2.Adresa = "Bana Derenčina 6";
                korisnik2.Stanje = 30;

                banka.DodajKorisnka(korisnik1);
                banka.DodajKorisnka(korisnik2);

                korisnik1.PokaziStanje();
                korisnik2.PokaziStanje();


                IzvodenjeTransakcije izvodTransakcije = new IzvodenjeTransakcije();
                izvodTransakcije.Iznos = new decimal(20.99);
                izvodTransakcije.Primatelj = korisnik2;
                izvodTransakcije.Posiljatelj = korisnik1;

                banka.IzvrsiTransakciju(izvodTransakcije);

                korisnik1.PokaziStanje();
                korisnik2.PokaziStanje();

                Console.ReadKey();
            }
        }
    }
}
