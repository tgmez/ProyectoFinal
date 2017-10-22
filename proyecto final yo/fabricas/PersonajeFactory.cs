using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class PersonajeFactory
	{

		private static PersonajeFactory instance;
		private static PersonajeInterfaz Interfaz;

		private PersonajeFactory()
		{
			Interfaz = new PersonajeDAO();
		}

		public static PersonajeFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new PersonajeFactory();
				}
				return instance;
			}
		}

		public PersonajeInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
