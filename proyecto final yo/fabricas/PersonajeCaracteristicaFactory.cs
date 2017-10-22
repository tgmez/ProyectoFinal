using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class PersonajeCaracteristicaFactory
	{

		private static PersonajeCaracteristicaFactory instance;
		private static PersonajeCaracteristicaInterfaz Interfaz;

		private PersonajeCaracteristicaFactory()
		{
			Interfaz = new PersonajeCaracteristicaDAO();
		}

		public static PersonajeCaracteristicaFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new PersonajeCaracteristicaFactory();
				}
				return instance;
			}
		}

		public PersonajeCaracteristicaInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
