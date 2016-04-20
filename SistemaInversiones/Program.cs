using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInversiones
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VistaGUI());
            double val = calculaRendimiento(31, 1000000, 2);
            MessageBox.Show(val.ToString("0.00"));
        }
        static double calculaRendimiento(int plazo,double monto, double interes)
        {
            double resultado = 0;
            for(int i = 1; i <= plazo; i++)
            {
                resultado += monto * (interes / 36000);
            }
            return resultado;
        }
    }
}
