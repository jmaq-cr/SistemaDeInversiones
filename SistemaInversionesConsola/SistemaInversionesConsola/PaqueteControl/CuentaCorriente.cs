using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    class CuentaCorriente : ITipoAhorroInversion
    {
        public void calcularRendimiento(DatosInversion datosp)
        {
            Rendimiento.calcularRendimiento(datosp);
        }

        public bool verificarDatos(DatosInversion datosp)
        {
            if(datosp.Monto >= 25000 && datosp.Moneda.Equals("colones"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
