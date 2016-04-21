using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class CuentaCorriente : ITipoAhorroInversion
    {
        public void obtenerIntereses(Datos datosp)
        {
            DatosPredefinidos.asignarIntereses(datosp);
        }

        public bool verificarDatos(Datos datosp)
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
