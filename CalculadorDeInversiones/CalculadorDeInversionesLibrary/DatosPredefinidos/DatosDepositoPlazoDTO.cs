using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    class DatosDepositoPlazoDTO
    {
        int plazoMin;
        int plazoMax;
        double interes;

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

        public double Interes
        {
            get
            {
                return interes;
            }

            set
            {
                interes = value;
            }
        }

        public DatosDepositoPlazoDTO(int plazoMinp, int plazoMaxp, double interesesp)
        {
            PlazoMin = plazoMinp;
            PlazoMax = plazoMaxp;
            Interes = interesesp;
        }
    }
}
