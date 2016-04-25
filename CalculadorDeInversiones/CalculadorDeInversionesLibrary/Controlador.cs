using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    interface Controlador
    {
        Salida calcularInversion(string nombre, string tipo, double monto, int plazo, string moneda);
    }
}
