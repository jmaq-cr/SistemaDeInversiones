using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    interface IFabricaSistemas
    {
        ITipoAhorroInversion fabricaAhorroInversion(string tipoInversion);
    }
}
