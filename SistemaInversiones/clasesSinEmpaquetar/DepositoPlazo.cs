using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class DepositoPlazo : ITipoAhorroInversion
    {
        public Datos obtenerIntereses(Datos datosp)
        {
            return datosp;
        }

        public bool verificarDatos(Datos datosp)
        {
            return true;
        }
    }
}
