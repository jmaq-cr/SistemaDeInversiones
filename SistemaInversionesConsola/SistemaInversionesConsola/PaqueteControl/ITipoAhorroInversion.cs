using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    interface ITipoAhorroInversion
    {
        bool verificarDatos(DatosInversion datosp);
        void calcularRendimiento(DatosInversion datosp);
    }
}
