using CalculadorDeInversionesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesConsola
{
    class Program
    {
        static string nombre;
        static string tipo;
        static string moneda;
        static double monto;
        static int plazo;
        static void Main(string[] args)
        {
            principal();
        }
        static void principal()
        {
            Console.WriteLine("\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n▒▒ CALCULADOR DE INVERSIONES ▒▒\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("1) Calcular Inversión");
            Console.WriteLine("2) Salir");
            Console.Write(">>");
            if (eleccion())
            {
                try
                {
                    CalculadorDeInversiones control = new CalculadorDeInversiones();
                    Salida consulta1 = control.calcularInversion(nombre, tipo, monto, plazo, moneda);
                    Console.Write("\n----------Datos de la Inversión----------\n");
                    Console.Write("Nombre: ");
                    Console.WriteLine(consulta1.Nombre);
                    Console.Write("Tipo de Inversión: ");
                    Console.WriteLine(consulta1.TipoInversion);
                    Console.Write("Monto de Ahorro e Inversión: ");
                    Console.WriteLine(consulta1.Monto);
                    Console.Write("Moneda: ");
                    Console.WriteLine(consulta1.Moneda);
                    Console.Write("Plazo: ");
                    Console.WriteLine(consulta1.Plazo);
                    Console.Write("Porcentaje de Interés Anual: ");
                    Console.WriteLine(consulta1.InteresAnual);
                    Console.Write("--------------Rendimiento--------------\n");
                    Console.Write("Plazo: ");
                    Console.WriteLine(consulta1.Plazo);
                    Console.Write("Monto de Ahorro e Inversión: ");
                    Console.WriteLine(consulta1.Monto);
                    Console.Write("Intereses Ganados: ");
                    Console.WriteLine(consulta1.InteresGanado);
                    if (consulta1.TipoInversion.Equals("Depósito Plazo"))
                    {
                        Console.Write("Impuesto de Renta: ");
                        Console.WriteLine(consulta1.ImpuestoRenta);
                    }
                    Console.Write("Saldo Final: ");
                    Console.WriteLine(consulta1.SaldoFinal);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("\n***Los datos suministrados no cumplen con los requisitos mínimos. Su calculo no se ha realizado***");
                }

                principal();
            }
            else
            {
                RegistroHistorico.generarArchivos();
            }
        }
        static bool eleccion()
        {
            string caracter = Console.ReadLine();
            if (caracter.Equals("1"))
            {
                validarDatos();
                return true;
            }
            else if (caracter.Equals("2"))
            {
                Console.WriteLine("Saliendo...");
                return false;
            }
            else
            {
                Console.Write("La opción no es válida. Vuelva a ingresar un valor\n>>");
                return eleccion();
            }
        }
        static bool validarDatos()
        {
            Console.WriteLine("Digite su nombre");
            Console.Write(">>");
            nombre = Console.ReadLine();
            Console.Write("Elija un tipo de inversión\n1)Cuenta Corriente\n2)Certificado de Depósito Plazo\n3)Inversión a la Vista Tasa Pactada\n>>");
            tipo = leerTipo();
            moneda = leerMoneda(tipo);
            Console.WriteLine("\nIngrese el monto a invertir");
            Console.Write(">>");
            monto = leerMonto();
            Console.WriteLine("Ingrese el plazo de la inversión en días");
            Console.Write(">>");
            plazo = leerPlazo();
            return true;
        }
        static string leerTipo()
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
        static string leerMoneda(string tipop)
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
        static double leerMonto()
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
        static int leerPlazo()
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
