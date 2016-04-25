using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeInversionesLibrary
{
	class DepositoPlazo : ITipoAhorroInversion
	{
		public void calcularRendimiento(DatosInversionDTO datosp)
		{
			Rendimiento.calcularRendimiento(datosp);
		}

		public bool verificarDatos(DatosInversionDTO datosp)
		{
			if (datosp.Moneda.Equals("colones") && datosp.Plazo >= 30)
			{
				if(datosp.Plazo>=30 && datosp.Plazo <= 89)
				{
					return validarMonto(datosp, 100000);
				}
				else
				{
					return validarMonto(datosp, 50000);
				}
			}
			else
			{
				return false;
			}

		}
		private bool validarMonto(Datos datosp, double monto)
		{
			if (datosp.Monto >= monto)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}


