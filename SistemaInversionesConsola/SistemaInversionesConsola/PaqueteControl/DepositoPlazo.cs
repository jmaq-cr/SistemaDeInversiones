using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    class DepositoPlazo : ITipoAhorroInversion
    {
        public void calcularRendimiento(DatosInversion datosp)
        {
            Rendimiento.calcularRendimiento(datosp);
        }

        public bool verificarDatos(DatosInversion datosp)
        {
            if (datosp.Moneda.Equals("colones") && datosp.Plazo >= 30)
            {
                if(datosp.Plazo>=30 && datosp.Plazo <= 89)
                {
                    if(datosp.Monto >= 100000)
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
                    if (datosp.Monto >= 50000)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
