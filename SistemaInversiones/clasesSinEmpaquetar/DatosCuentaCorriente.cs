using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DatosCuentaCorriente
    {
        private double montoMin;
        private double montoMax;
        private double intereses;

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

        public DatosCuentaCorriente(double montoMinp,double montoMaxp,double interesesp)
        {
            MontoMin = montoMinp;
            MontoMax = montoMaxp;
            Intereses = interesesp;
        }

    }
}
