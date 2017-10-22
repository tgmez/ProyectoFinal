using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class ClaseFactory
	{

		private static ClaseFactory instance;
		private static ClaseInterfaz Interfaz;

		private ClaseFactory()
		{
			Interfaz = new ClasesDAO();
		}

		public static ClaseFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ClaseFactory();
				}
				return instance;
			}
		}

		public ClaseInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
