using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    class DatosCuentaCorriente
    {
        private double montoMin;
        private double montoMax;
        private double interes;

        public double MontoMin
        {
            get
            {
                return montoMin;
            }

            set
            {
                montoMin = value;
            }
        }

        public double MontoMax
        {
            get
            {
                return montoMax;
            }

            set
            {
                montoMax = value;
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

        public DatosCuentaCorriente(double montoMinp,double montoMaxp,double interesesp)
        {
            MontoMin = montoMinp;
            MontoMax = montoMaxp;
            Interes = interesesp;
        }

    }
}
