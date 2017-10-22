using proyecto_final_yo.daos;
using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.fabricas
{
	public class RazaFactory
	{

		private static RazaFactory instance;
		private static RazaInterfaz Interfaz;

		private RazaFactory()
		{
			Interfaz = new RazaDAO();
		}

		public static RazaFactory Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new RazaFactory();
				}
				return instance;
			}
		}

		public RazaInterfaz obtenerDAO()
		{
			return Interfaz;
		}

	}
}
