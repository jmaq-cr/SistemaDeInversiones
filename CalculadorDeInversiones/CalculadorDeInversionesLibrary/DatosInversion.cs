using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public class DatosInversion : Datos
    {
        
        private double interesGanado;
        private double impuestoRenta;
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

        public override void toString()
        {
            Console.Write("Tipo de Inversión: ");
            Console.Write(Tipo);
            Console.Write("\nMonto a Invertir: ");
            Console.Write(Monto);
            Console.Write("\nPlazo: ");
            Console.Write(Plazo);
            Console.Write("\nMoneda: ");
            Console.Write(Moneda);
            Console.Write("\nTasa de Interés Anual: ");
            Console.Write(InteresAnual);
            Console.Write("\nIntereses Ganados: ");
            Console.Write(interesGanado);
            Console.Write("\nSaldo Final: ");
            Console.Write(saldoFinal);

        }
    }
}
