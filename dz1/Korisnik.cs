using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public class Korisnik : Osoba, IBankovniRacun
    {
        private decimal StanjeRacuna { get; set; }

        public Korisnik(string ime, string prezime) : base(ime, prezime)
        {
            StanjeRacuna = 100;
        }

        public decimal ProvjeriStanjeRacuna()
        {
            return StanjeRacuna;
        }

        public void Uplata(decimal iznos)
        {
            StanjeRacuna += iznos;
            
        }

        public void Isplata(decimal iznos)
        {
            if(StanjeRacuna >= iznos)
            {
                StanjeRacuna -= iznos;
            }
            else
            {
                Console.WriteLine("Nedovoljno stanje racuna za isplatu.");
            }
        }

        public override void PrikaziOsobnePodatke()
        {
            Console.WriteLine($"Korisnik: {Ime} {Prezime}");
        }
    }
}
