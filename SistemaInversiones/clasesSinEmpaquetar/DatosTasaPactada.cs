using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DatosTasaPactada
    {
        int plazoMin;
        int plazoMax;
        double interesesColones;
        double interesesDolares;

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

        public double InteresesColones
        {
            get
            {
                return interesesColones;
            }

            set
            {
                interesesColones = value;
            }
        }

        public double InteresesDolares
        {
            get
            {
                return interesesDolares;
            }

            set
            {
                interesesDolares = value;
            }
        }

        public DatosTasaPactada(int plazoMinp, int plazoMaxp, double interesesColonesp, double interesesDolaresp)
        {
            PlazoMin = plazoMinp;
            PlazoMax = plazoMaxp;
            InteresesColones = interesesColonesp;
            InteresesDolares = interesesDolaresp;
        }
    }
}
