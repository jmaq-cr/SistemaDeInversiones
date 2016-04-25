using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesConsola
{
    class ValidadorDatos
    {
        public static string leerTipo()
        {
            string caracter = Console.ReadLine();
            if (caracter.Equals("1"))
            {
                return "Cuenta Corriente";
            }
            else if (caracter.Equals("2"))
            {
                return "Depósito Plazo";
            }
            else if (caracter.Equals("3"))
            {
                return "Tasa Pactada";
            }
            else
            {
                Console.Write("La opción no es válida. Vuelva a ingresar un valor\n>>");
                return leerTipo();
            }
        }
        public static string leerMoneda(string tipop)
        {
            if (tipop.Equals("Tasa Pactada"))
            {
                Console.Write("\nElija la moneda\n1)Colones\n2)Dólares\n>>");
                string caracter = Console.ReadLine();
                if (caracter.Equals("1"))
                {
                    return "colones";
                }
                else if (caracter.Equals("2"))
                {
                    return "dólares";
                }
                else
                {
                    Console.Write("La opción no es válida. Vuelva a ingresar un valor\n>>");
                    return leerMoneda(tipop);
                }
            }
            else
            {
                Console.Write("El tipo de inversión elegida solo se permite colones. Su inversión será en colones");
                return "colones";
            }

        }
        public static double leerMonto()
        {
            string numeroS = Console.ReadLine();
            double numero;
            if (double.TryParse(numeroS, out numero))
            {
                return numero;
            }
            else
            {
                Console.Write("La opción no es válida. Ingrese un valor numérico\n>>");
                return leerMonto();
            }
        }
        public static int leerPlazo()
        {
            string numeroS = Console.ReadLine();
            int numero;
            if (int.TryParse(numeroS, out numero))
            {
                return numero;
            }
            else
            {
                Console.Write("La opción no es válida. Ingrese un valor numérico\n>>");
                return leerPlazo();
            }
        }
    }
}
