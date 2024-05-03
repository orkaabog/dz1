using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public abstract class Transakcija : ITransakcija
    {
        protected IBankovniRacun RacunPosiljatelj { get; }
        protected IBankovniRacun RacunPrimatelj { get; }
        protected decimal Iznos { get; }

        protected Transakcija(IBankovniRacun racunPosiljatelj, IBankovniRacun racunPrimatelj, decimal iznos)
        {
            RacunPosiljatelj = racunPosiljatelj;
            RacunPrimatelj = racunPrimatelj;
            Iznos = iznos;
        }
            
        public virtual void NapraviTransakciju()
        {
            Console.WriteLine("Transakcija obavljena.");
        }

    }
}
