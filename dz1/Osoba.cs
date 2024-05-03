using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public abstract class Osoba
    {
        public string Ime { get; }
        public string Prezime { get; }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public virtual void PrikaziOsobnePodatke()
        {
            Console.WriteLine($"Ime: {Ime}, Prezime: {Prezime}");
        }
    }
}
