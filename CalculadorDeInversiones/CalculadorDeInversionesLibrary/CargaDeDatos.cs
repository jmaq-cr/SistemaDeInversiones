using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public static class CargaDeDatos
    {

        public static void cargarDatos()
        {
            string json = File.ReadAllText("DatosPredefinidos/DatosCuentaCorriente.json");
            List<DatosCuentaCorriente>  datosCuentaCorriente = JsonConvert.DeserializeObject<List<DatosCuentaCorriente>>(json);
            InteresesPredefinidos.DatosCuentaCorriente = datosCuentaCorriente;
            json = File.ReadAllText("DatosPredefinidos/DatosDepositoPlazo.json");
            List<DatosDepositoPlazo> datosDepositoPlazo = JsonConvert.DeserializeObject<List<DatosDepositoPlazo>>(json);
            InteresesPredefinidos.DatosDepositoPlazo = datosDepositoPlazo;
            json = File.ReadAllText("DatosPredefinidos/DatosTasaPactada.json");
            List<DatosTasaPactada> datosTasaPactada = JsonConvert.DeserializeObject<List<DatosTasaPactada>>(json);
            InteresesPredefinidos.DatosTasaPactada = datosTasaPactada;
        }
    }
}
