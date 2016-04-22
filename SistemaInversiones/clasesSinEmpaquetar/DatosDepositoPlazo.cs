﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DatosDepositoPlazo
    {
        int plazoMin;
        int plazoMax;
        double intereses;

        public int PlazoMin
        {
            get
            {
                return plazoMin;
            }

            set
            {
                plazoMin = value;
            }
        }

        public int PlazoMax
        {
            get
            {
                return plazoMax;
            }

            set
            {
                plazoMax = value;
            }
        }

        public double Intereses
        {
            get
            {
                return intereses;
            }

            set
            {
                intereses = value;
            }
        }

        public DatosDepositoPlazo(int plazoMinp, int plazoMaxp, double interesesp)
        {
            PlazoMin = plazoMinp;
            PlazoMax = plazoMaxp;
            Intereses = interesesp;
        }
    }
}
