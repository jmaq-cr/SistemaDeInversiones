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

        public DatosInversion(string tipop, double montop, int plazop, string monedap)
        {
            tipo = tipop;
            monto = montop;
            plazo = plazop;
            moneda = monedap;
        }
    }
}
