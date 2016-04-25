using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public static class InteresesPredefinidos
    {
        private static List<DatosCuentaCorrienteDTO> datosCuentaCorriente = new List<DatosCuentaCorrienteDTO>();
        private static List<DatosDepositoPlazoDTO> datosDepositoPlazo = new List<DatosDepositoPlazoDTO>();
        private static List<DatosTasaPactadaDTO> datosTasaPactada = new List<DatosTasaPactadaDTO>();

        internal static List<DatosCuentaCorrienteDTO> DatosCuentaCorriente
        {
            get
            {
                return datosCuentaCorriente;
            }

            set
            {
                datosCuentaCorriente = value;
            }
        }
        
        internal static List<DatosDepositoPlazoDTO> DatosDepositoPlazo
        {
            get
            {
                return datosDepositoPlazo;
            }

            set
            {
                datosDepositoPlazo = value;
            }
        }

        internal static List<DatosTasaPactadaDTO> DatosTasaPactada
        {
            get
            {
                return datosTasaPactada;
            }

            set
            {
                datosTasaPactada = value;
            }
        }

        public static void asignarIntereses(DatosInversionDTO datosp)
        {
            if(datosp.Tipo.Equals("Cuenta Corriente"))
            {
                validarCuentaCorriente(datosp);
            }
            else if(datosp.Tipo.Equals("Depósito Plazo"))
            {
                validarDepositoPlazo(datosp);
            }
            else if(datosp.Tipo.Equals("Tasa Pactada"))
            {
                validarTasaPactada(datosp);
            }
            else
            {
                Console.WriteLine("No se encuentra");
            }
        }
        public static void validarCuentaCorriente(Datos datosp)
        {
            for (int i = 0; i < DatosCuentaCorriente.Count; i++)
            {
                if (datosp.Monto >= DatosCuentaCorriente[i].MontoMin && datosp.Monto <= DatosCuentaCorriente[i].MontoMax)
                {
                    datosp.InteresAnual = DatosCuentaCorriente[i].Interes;
                    break;
                }
            }
        }
        public static void validarDepositoPlazo(Datos datosp)
        {
            for (int i = 0; i < DatosDepositoPlazo.Count; i++)
            {
                if (datosp.Plazo >= DatosDepositoPlazo[i].PlazoMin && datosp.Plazo <= DatosDepositoPlazo[i].PlazoMax)
                {
                    datosp.InteresAnual = DatosDepositoPlazo[i].Interes;
                    break;

                }
            }
        }
        public static void validarTasaPactada(Datos datosp)
        {
            for (int i = 0; i < DatosTasaPactada.Count; i++)
            {
                if (datosp.Plazo >= DatosTasaPactada[i].PlazoMin && datosp.Plazo <= DatosTasaPactada[i].PlazoMax)
                {
                    if (datosp.Moneda.Equals("colones"))
                    {
                        datosp.InteresAnual = DatosTasaPactada[i].InteresColones;
                        break;
                    }
                    else
                    {
                        datosp.InteresAnual = DatosTasaPactada[i].InteresDolares;
                        break;
                    }
                }
            }
        }

    }
}
