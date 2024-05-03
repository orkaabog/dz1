using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public class Banka
    {
        private List<IBankovniRacun> korisnici;

        public Banka(List<IBankovniRacun> korisnici)
        {
            this.korisnici = korisnici;
        }

        public void NapraviTransakciju(Transakcija transakcija)
        {
            transakcija.NapraviTransakciju();
        }
    }

}
