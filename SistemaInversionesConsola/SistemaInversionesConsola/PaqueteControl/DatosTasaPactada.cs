using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    class DatosTasaPactada
    {
        int plazoMin;
        int plazoMax;
        double interesColones;
        double interesDolares;

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

        public double InteresColones
        {
            get
            {
                return interesColones;
            }

            set
            {
                interesColones = value;
            }
        }

        public double InteresDolares
        {
            get
            {
                return interesDolares;
            }

            set
            {
                interesDolares = value;
            }
        }

        public DatosTasaPactada(int plazoMinp, int plazoMaxp, double interesesColonesp, double interesesDolaresp)
        {
            PlazoMin = plazoMinp;
            PlazoMax = plazoMaxp;
            InteresColones = interesesColonesp;
            InteresDolares = interesesDolaresp;
        }
    }
}
