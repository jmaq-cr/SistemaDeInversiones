﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    interface IFabricaSistemas
    {
        ITipoAhorroInversion fabricaAhorroInversion(string tipoInversion);
    }
}