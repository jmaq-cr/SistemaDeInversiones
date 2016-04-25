using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    class CuentaCorriente : ITipoAhorroInversion
    {
        public void calcularRendimiento(DatosInversionDTO datosp)
        {
            Rendimiento.calcularRendimiento(datosp);
        }

        public bool verificarDatos(DatosInversionDTO datosp)
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
