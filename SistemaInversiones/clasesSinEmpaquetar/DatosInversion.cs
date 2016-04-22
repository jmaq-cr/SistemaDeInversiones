using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DatosInversion : Datos
    {
        
        private double interesGanado;
        private double saldoFinal;

        public DatosInversion(string tipop, double montop, int plazop, string monedap) : base(tipop, montop, plazop, monedap)
        {
        }

        public double SaldoFinal
        {
            get
            {
                return saldoFinal;
            }

            set
            {
                saldoFinal = value;
            }
        }

        public double InteresGanado
        {
            get
            {
                return interesGanado;
            }

            set
            {
                interesGanado = value;
            }
        }
    }
}
