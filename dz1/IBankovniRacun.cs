﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    public interface IBankovniRacun
    {
        void Uplata(decimal iznos);
        void Isplata(decimal iznos);
        decimal ProvjeriStanjeRacuna();
    }
}