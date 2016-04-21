using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    class FabricaSistemasTradicionales : IFabricaSistemas
    {
        public FabricaSistemasTradicionales()
        {

        }

        public ITipoAhorroInversion fabricaAhorroInversion(string tipoInversion)
        {
            if (tipoInversion.Equals("DepositoPlazo"))
            {
                ITipoAhorroInversion temp = new DepositoPlazo();
                return temp;
            }
            else if (tipoInversion.Equals("TasaPactada"))
            {
                ITipoAhorroInversion temp = new TasaPactada();
                return temp;
            }
            else
            {
                ITipoAhorroInversion temp = new CuentaCorriente();
                return temp;
            }
        }
    }
}
