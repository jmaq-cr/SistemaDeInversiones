using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public class CalculadorDeInversiones:Controlador
    {
        private IFabricaSistemas fabrica;
        private Salida respuesta;

        public CalculadorDeInversiones()
        {
            fabrica = new FabricaSistemasTradicionales();
        }
        public Salida calcularInversion(string nombre,string tipo,double monto,int plazo,string moneda)
        {
            CargaDeDatos.cargarDatos();
            DatosInversion datosActuales = new DatosInversion(tipo, monto, plazo, moneda);
            Cliente clienteActual = new Cliente(nombre);
            ITipoAhorroInversion inversion = fabrica.fabricaAhorroInversion(tipo);
            if (inversion.verificarDatos(datosActuales))
            {
                inversion.calcularRendimiento(datosActuales);
                respuesta = RegistroHistorico.agregarEntrada(datosActuales, clienteActual);
            }
            return respuesta;

        }
    }
}
