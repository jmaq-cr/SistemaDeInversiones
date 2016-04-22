using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInversiones.clasesSinEmpaquetar
{
    public static class DatosPredefinidos
    {
        private static List<DatosCuentaCorriente> datosCuentaCorriente = new List<DatosCuentaCorriente>();
        private static List<DatosDepositoPlazo> datosDepositoPlazo = new List<DatosDepositoPlazo>();
        private static List<DatosTasaPactada> datosTasaPactada = new List<DatosTasaPactada>();

        public static void asignarIntereses(Datos datosp)
        {
            if(datosp.Tipo.Equals("Cuenta Corriente"))
            {
                for (int i = 0 ; i <= datosCuentaCorriente.Count ; i++)
                {
                    if (datosp.Monto >= datosCuentaCorriente[i].MontoMin && datosp.Monto <= datosCuentaCorriente[i].MontoMax)
                    {
                        datosp.InteresAnual = datosCuentaCorriente[i].Intereses;
                    }
                }
            }
            else if(datosp.Tipo.Equals("Deposito Plazo"))
            {
                for(int i = 0 ; i <= datosDepositoPlazo.Count ; i++)
                {
                    if(datosp.Plazo >= datosDepositoPlazo[i].PlazoMin && datosp.Plazo <= datosDepositoPlazo[i].PlazoMax)
                    {
                        datosp.InteresAnual = datosDepositoPlazo[i].Intereses;
                    }
                }
            }
            else if(datosp.Tipo.Equals("Tasa Pactada"))
            {
                for (int i = 0; i <= datosTasaPactada.Count; i++)
                {
                    if(datosp.Plazo >= datosTasaPactada[i].PlazoMin && datosp.Plazo <= datosTasaPactada[i].PlazoMax)
                    {
                        if (datosp.Moneda.Equals("colones"))
                        {
                            datosp.InteresAnual = datosTasaPactada[i].InteresesColones;
                        }
                        else
                        {
                            datosp.InteresAnual = datosTasaPactada[i].InteresesDolares;
                        }
                    }
                }
            }
        }
        public static void cargarDatos()
        {
            string json = File.ReadAllText("DatosPredefinidos/DatosCuentaCorriente.json");
            datosCuentaCorriente = JsonConvert.DeserializeObject<List<DatosCuentaCorriente>>(json);
            json = File.ReadAllText("DatosPredefinidos/DatosDepositoPlazo.json");
            datosDepositoPlazo = JsonConvert.DeserializeObject<List<DatosDepositoPlazo>>(json);
            json = File.ReadAllText("DatosPredefinidos/DatosTasaPactada.json");
            datosTasaPactada = JsonConvert.DeserializeObject<List<DatosTasaPactada>>(json);
        }
    }
}
