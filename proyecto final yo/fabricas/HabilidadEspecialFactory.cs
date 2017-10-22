using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class HabilidadEspecialFactory
	{

		private static HabilidadEspecialFactory instance;
		private static HabilidadesEspecialesInterfaz Interfaz;

		private HabilidadEspecialFactory()
		{
			Interfaz = new HabilidadesEspecialesDAO();
		}

		public static HabilidadEspecialFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new HabilidadEspecialFactory();
				}
				return instance;
			}
		}

		public HabilidadesEspecialesInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
