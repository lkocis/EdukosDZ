using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    public class IzvodenjeTransakcije : Transakcija
    {
        public Korisnik Primatelj { get; set; }
        public Korisnik Posiljatelj { get; set; }
        public override void IzvrsiTransakciju()
        {
            Console.WriteLine($"Transakcija u iznosu od {Iznos} je obavljena izmedu korisnika {Posiljatelj.Ime} {Posiljatelj.Prezime} i korisnika {Primatelj.Ime} {Primatelj.Prezime}");
            Primatelj.Uplati(Iznos);
            Posiljatelj.Isplati(Iznos);
        }
    }
}
