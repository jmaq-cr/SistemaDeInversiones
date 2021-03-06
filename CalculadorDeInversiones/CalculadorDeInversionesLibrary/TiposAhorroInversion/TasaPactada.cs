﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    class TasaPactada : ITipoAhorroInversion
    {
        public void calcularRendimiento(DatosInversionDTO datosp)
        {
            Rendimiento.calcularRendimiento(datosp);
        }

        public bool verificarDatos(DatosInversionDTO datosp)
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
