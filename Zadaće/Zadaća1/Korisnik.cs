using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    public class Korisnik : Osoba, IBankovniRacun
    {
        public int BrojRacuna { get; set; }
        public decimal Stanje { get; set; }

        public Korisnik()
        {
            Stanje = 10;
        }

        public void PokaziStanje()
        {
            Console.WriteLine("Stanje na računu korisnika " + Ime + " " + Prezime + " iznosi: " + Stanje);
        }
        public void Uplati(decimal iznos)
        {
            Stanje += iznos;
        }
        public void Isplati(decimal iznos)
        {
            Stanje -= iznos;
        }
    }
}
