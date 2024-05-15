using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća1
{
    public class Banka
    {
        private List<Korisnik> korisnici;
        private List<Transakcija> transakcije;

        public Banka()
        {
            korisnici = new List<Korisnik>();
            transakcije = new List<Transakcija>();
        }

        public void DodajKorisnka(Korisnik korisnik)
        {
            korisnici.Add(korisnik);
        }

        public Korisnik PronadiKorisnika(int brojRacuna)
        {
            foreach (Korisnik korisnik in korisnici)
            {
                if (brojRacuna == korisnik.BrojRacuna)
                    return korisnik;
            }
            return null;
        }

        public void IzvrsiTransakciju(Transakcija transakcija)
        {
            transakcija.IzvrsiTransakciju();
            transakcije.Add(transakcija);
        }
    }
}
