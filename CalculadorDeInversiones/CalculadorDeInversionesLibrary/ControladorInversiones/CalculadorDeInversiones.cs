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
        private SalidaDTO respuesta;

        public CalculadorDeInversiones()
        {
            fabrica = new FabricaSistemasTradicionales();
        }
        public SalidaDTO calcularInversion(string nombre,string tipo,double monto,int plazo,string moneda)
        {
            CargaDeDatos.cargarDatos();
            DatosInversionDTO datosActuales = new DatosInversionDTO (tipo, monto, plazo, moneda);
            ClienteDTO clienteActual = new ClienteDTO(nombre);
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
