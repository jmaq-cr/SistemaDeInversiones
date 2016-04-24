using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    class TasaPactada : ITipoAhorroInversion
    {
        public void calcularRendimiento(DatosInversion datosp)
        {
            Rendimiento.calcularRendimiento(datosp);
        }

        public bool verificarDatos(DatosInversion datosp)
        {
            if (datosp.Plazo >= 15)
            {
                if ((datosp.Moneda.Equals("colones") && datosp.Monto >= 100000) || (datosp.Moneda.Equals("dólares") && datosp.Monto >= 500))
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
