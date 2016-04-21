using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    interface ITipoAhorroInversion
    {
        bool verificarDatos(Datos datosp);
        void obtenerIntereses(Datos datosp);
    }
}
