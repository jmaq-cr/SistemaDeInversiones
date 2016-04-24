using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    public class Entrada
    {
        DateTime fecha;
        string nombre;
        string tipoInversion;
        double monto;
        string moneda;
        int plazo;
        double interesAnual;
        double interesGanado;
        double impuestoRenta;
        double saldoFinal;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string TipoInversion
        {
            get
            {
                return tipoInversion;
            }

            set
            {
                tipoInversion = value;
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
        public double ImpuestoRenta
        {
            get
            {
                return impuestoRenta;
            }

            set
            {
                impuestoRenta = value;
            }
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

        

        public Entrada()
        {
        }
    }
}
