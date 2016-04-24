using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SistemaInversionesConsola.PaqueteControl
{
    public static class RegistroHistorico
    {
        static List<Entrada> entradas = new List<Entrada>();
        static string textoXml = "";

        public static void generarArchivos()
        {
            for(int i = 0; i < entradas.Count; i++)
            {
                textoXml += toXML(entradas[i]);
                textoXml += "\n";
            }
            using (StreamWriter writer =
            new StreamWriter("registro.xml"))
                {
                    writer.Write(textoXml);
                }
            toCsv(entradas, "registro.csv");

        }
        public static Entrada agregarEntrada(DatosInversion datos, Cliente cliente)
        {
            Entrada nuevaEntrada = new Entrada();
            nuevaEntrada.Fecha = DateTime.Now;
            nuevaEntrada.Nombre = cliente.Nombre;
            nuevaEntrada.TipoInversion = datos.Tipo;
            nuevaEntrada.Monto = datos.Monto;
            nuevaEntrada.Moneda = datos.Moneda;
            nuevaEntrada.Plazo = datos.Plazo;
            nuevaEntrada.InteresAnual = datos.InteresAnual;
            nuevaEntrada.InteresGanado = datos.InteresGanado;
            nuevaEntrada.ImpuestoRenta = datos.ImpuestoRenta;
            nuevaEntrada.SaldoFinal = datos.SaldoFinal;
            entradas.Add(nuevaEntrada);
            return nuevaEntrada;
        }
        public static string toXML<T>(T obj)
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }
        public static void toCsv<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .OrderBy(p => p.Name);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(";", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(";", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
    }
}
