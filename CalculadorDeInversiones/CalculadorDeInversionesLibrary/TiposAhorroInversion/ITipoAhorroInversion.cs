using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    interface ITipoAhorroInversion
    {
        bool verificarDatos(DatosInversionDTO datosp);
        void calcularRendimiento(DatosInversionDTO datosp);
    }
}
