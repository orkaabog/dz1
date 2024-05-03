using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public class Isplata : Transakcija
    {
        public Isplata(IBankovniRacun racunPosiljatelj, IBankovniRacun racunPrimatelj, decimal iznos)
            : base(racunPosiljatelj, racunPrimatelj, iznos) { }

        public override void NapraviTransakciju()
        {
            RacunPosiljatelj.Isplata(Iznos);
            RacunPrimatelj.Uplata(Iznos);
            Console.WriteLine($"Izvršena isplata s računa pošiljatelja u iznosu od {Iznos}.");
        }
    }
}
