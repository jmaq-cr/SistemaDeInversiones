using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversionesConsola.PaqueteControl
{
    public class CalculadorDeInversiones
    {
        private IFabricaSistemas fabrica;
        private List<Persona> clientes;
        private List<Datos> datos;

        public CalculadorDeInversiones()
        {
            clientes = new List<Persona>();
            datos = new List<Datos>();
            fabrica = new FabricaSistemasTradicionales();
        }
        public Entrada calcularInversion(string nombre,string tipo,double monto,int plazo,string moneda)
        {
            DatosPredefinidos.cargarDatos();
            DatosInversion datosActuales = new DatosInversion(tipo, monto, plazo, moneda);
            datos.Add(datosActuales);
            Cliente clienteActual = new Cliente(nombre);
            clientes.Add(clienteActual);
            //Aquí hay que fabricar un tipo de inversión y pasarle los datos
            ITipoAhorroInversion inversion = fabrica.fabricaAhorroInversion(tipo);
            if (inversion.verificarDatos(datosActuales))
            {
                inversion.calcularRendimiento(datosActuales);
            }
            Entrada respuesta = RegistroHistorico.agregarEntrada(datosActuales, clienteActual);
            return respuesta;

        }
    }
}
