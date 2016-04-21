using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class TasaPactada : ITipoAhorroInversion
    {
        public void obtenerIntereses(Datos datosp)
        {
            DatosPredefinidos.asignarIntereses(datosp);
        }

        public bool verificarDatos(Datos datosp)
        {
            if (datosp.Plazo >= 15)
            {
                if ((datosp.Moneda.Equals("colones") && datosp.Monto >= 100000) || (datosp.Moneda.Equals("dolares") && datosp.Monto >= 500))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
