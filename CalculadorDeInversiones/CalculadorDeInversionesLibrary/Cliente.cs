using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
    public class Cliente : Persona
    {
        private string nombre;

        public Cliente(string nombrep)
        {
            Nombre = nombrep;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
