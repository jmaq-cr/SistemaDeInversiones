using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DatosInversion : Datos
    {
        private string tipo;
        private double monto;
        private int plazo;
        private string moneda;
        private double interesAnual;
        private double interesGanado;
        private double saldoFinal;

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

        public double InteresAnual
        {
            get
            {
                return interesAnual;
            }

            set
            {
                interesAnual = value;
            }
        }

        public string Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }

        public int Plazo
        {
            get
            {
                return plazo;
            }

            set
            {
                plazo = value;
            }
        }

        public double Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public DatosInversion(string tipop, double montop, int plazop, string monedap)
        {
            Tipo = tipop;
            Monto = montop;
            Plazo = plazop;
            Moneda = monedap;
        }
    }
}
