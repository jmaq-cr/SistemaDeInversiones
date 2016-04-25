using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public abstract class Rendimiento
    {
        public static void calcularRendimiento(DatosInversion datosp)
        {
            InteresesPredefinidos.asignarIntereses(datosp);
            if(datosp.Tipo.Equals("Depósito Plazo"))
            {
                double interesGanado = sumatoria(datosp.Plazo, datosp.Monto, datosp.InteresAnual);
                datosp.InteresGanado = interesGanado;
                //Como es Depósito Plazo se quita un 8% por impuesto sobre la renta
                datosp.ImpuestoRenta = interesGanado * 0.08;
                datosp.SaldoFinal = datosp.Monto + datosp.InteresGanado - (interesGanado * 0.08);
            }
            else
            {
                datosp.InteresGanado = sumatoria(datosp.Plazo, datosp.Monto, datosp.InteresAnual);
                datosp.ImpuestoRenta = 0;
                datosp.SaldoFinal = datosp.Monto + datosp.InteresGanado;

            }
        }
        private static double sumatoria(int plazop, double montop, double interesp)
        {
            double resultado = 0;
            for (int i = 1; i <= plazop ; i++)
            {
                resultado += montop * (interesp / 36000);
            }
            return resultado;
        }
    }
}
