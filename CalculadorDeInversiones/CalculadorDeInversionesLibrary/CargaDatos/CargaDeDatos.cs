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
            List<DatosCuentaCorrienteDTO>  datosCuentaCorriente = JsonConvert.DeserializeObject<List<DatosCuentaCorrienteDTO>>(json);
            InteresesPredefinidos.DatosCuentaCorriente = datosCuentaCorriente;
            json = File.ReadAllText("DatosPredefinidos/DatosDepositoPlazo.json");
            List<DatosDepositoPlazoDTO> datosDepositoPlazo = JsonConvert.DeserializeObject<List<DatosDepositoPlazoDTO>>(json);
            InteresesPredefinidos.DatosDepositoPlazo = datosDepositoPlazo;
            json = File.ReadAllText("DatosPredefinidos/DatosTasaPactada.json");
            List<DatosTasaPactadaDTO> datosTasaPactada = JsonConvert.DeserializeObject<List<DatosTasaPactadaDTO>>(json);
            InteresesPredefinidos.DatosTasaPactada = datosTasaPactada;
        }
    }
}
