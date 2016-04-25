using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadorDeInversionesLibrary;

namespace CalculadorDeInversionesGUI
{
    public partial class VentanaPrincipal : Form
    {

        static string nombre;
        static string tipo;
        static string moneda;
        static string monto;
        static string plazo;

        private string resultado;

        public VentanaPrincipal()
        {
            InitializeComponent();
            llenarTipos();
            llenarMoneda(true);
        }

        private void llenarTipos()
        {
            boxTipo.Items.AddRange(new object[] { "Cuenta Corriente", "Depósito Plazo", "Tasa Pactada" });
            boxTipo.SelectedIndex = 0;
        }

        private void llenarMoneda(Boolean soloColones)
        {
            boxMoneda.Items.Clear();
            if(!soloColones)
                boxMoneda.Items.AddRange(new object[] { "colones", "dólares" });
            else
                boxMoneda.Items.AddRange(new object[] { "colones" });
            boxMoneda.SelectedIndex = 0;
        }

        private void ponerResultadoMalo()
        {
            resultado = "***Los datos suministrados no están correctos. Por favor revise que: \n" +
                        "El monto sea un número correcto\n" + 
                        "El plazo de días sea un número entero";
        }

        private void obtenerEntradas()
        {
            nombre = textboxNombre.Text;
            tipo = boxTipo.Text;
            moneda = boxMoneda.Text;
            monto = textboxMonto.Text;
            plazo = textboxPlazo.Text;
        }

        public Boolean validarDatos()
        {
            Boolean validacionCorrecta = ValidadorDatos.leerMonto(monto) && ValidadorDatos.leerPlazo(plazo);
            return validacionCorrecta;
        }

        public void calcularResultado()
        {
            CalculadorDeInversiones control = new CalculadorDeInversiones();
            Salida consulta = control.calcularInversion(nombre, tipo, Double.Parse(monto), int.Parse(plazo), moneda);
            if (consulta != null)
                formatearResultado(consulta);
            else
                resultado = "***Los datos suministrados no cumplen con los requisitos mínimos. Su calculo no se ha realizado***";
        }

        public void formatearResultado(Salida pConsulta)
        {
            resultado = "";
            resultado += "\n----------Datos de la Inversión----------\n" +
                         "Nombre: " + pConsulta.Nombre + "\n" +
                         "Tipo de Inversión: " + pConsulta.TipoInversion + "\n" +
                         "Monto de Ahorro e Inversión: " + pConsulta.Monto + "\n" +
                         "Moneda: " + pConsulta.Moneda + "\n" +
                         "Plazo: " + pConsulta.Plazo + "\n" +
                         "Porcentaje de Interés Anual: " + pConsulta.InteresAnual + "\n" +
                         "--------------Rendimiento--------------\n" +
                         "Plazo: " + pConsulta.Plazo + "\n" +
                         "Monto de Ahorro e Inversión: " + pConsulta.Monto + "\n" +
                         "Intereses Ganados: " + pConsulta.InteresGanado + "\n";
            if (pConsulta.TipoInversion.Equals("Depósito Plazo"))
            {
                resultado += "Impuesto de Renta: " + pConsulta.ImpuestoRenta + "\n";
            }
            resultado += "Saldo Final: " + pConsulta.SaldoFinal; 
        }

        public void mostrarResultado()
        {
            MessageBox.Show(resultado);
        }

        //Métodos de acciones
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            obtenerEntradas();
            if (validarDatos())
            {
                calcularResultado();
            }
            else
            {
                ponerResultadoMalo();
            }
            mostrarResultado();
        }

        private void boxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(boxTipo.SelectedIndex == 2)
                llenarMoneda(false);
            else
                llenarMoneda(true);
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            RegistroHistorico.generarArchivos();
            MessageBox.Show("Los registros se han guardado correctamente");
        }
    }
}
