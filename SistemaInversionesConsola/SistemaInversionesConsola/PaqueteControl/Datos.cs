using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    public abstract class Datos
    {
        private string tipo;
        private double monto;
        private int plazo;
        private string moneda;
        private double interesAnual;

        
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
        public Datos(string tipop, double montop, int plazop, string monedap)
        {
            Tipo = tipop;
            Monto = montop;
            Plazo = plazop;
            Moneda = monedap;
        }
        public abstract void toString();
    }
}
