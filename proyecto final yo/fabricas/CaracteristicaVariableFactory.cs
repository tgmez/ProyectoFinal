using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class CaracteristicaVariableFactory
	{

		private static CaracteristicaVariableFactory instance;
		private static CaracteristicaVariableInterfaz Interfaz;

		private CaracteristicaVariableFactory() {
			Interfaz = new CaracteristicasVariablesDAO();
		}

		public static CaracteristicaVariableFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CaracteristicaVariableFactory();
				}
				return instance;
			}
		}

		public CaracteristicaVariableInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
