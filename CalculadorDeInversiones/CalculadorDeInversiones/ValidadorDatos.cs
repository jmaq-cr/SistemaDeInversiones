using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesGUI
{
    class ValidadorDatos
    {
        public static Boolean leerMonto(string pMonto)
        {
            double numero;
            if (double.TryParse(pMonto, out numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean leerPlazo(string pPlazo)
        {
            int numero;
            if (int.TryParse(pPlazo, out numero))
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
