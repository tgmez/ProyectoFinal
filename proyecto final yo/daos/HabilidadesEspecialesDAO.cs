using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class HabilidadesEspecialesDAO
	{

		private static int contadorId = 1;

		public static void crear(HabilidadEspecial habilidadEspecial)
		{
			habilidadEspecial.Id = contadorId++;
			Datos.habilidadesEspeciales.Add(habilidadEspecial);

		}
		public static void modificar(HabilidadEspecial habilidadEspecial)
		{

		}
		public static List<HabilidadEspecial> listar()
		{
			return Datos.habilidadesEspeciales;
		}
		public static void eliminar(HabilidadEspecial habilidadEspecial)
		{
			Datos.habilidadesEspeciales.Remove(habilidadEspecial);
		}
		public static HabilidadEspecial obtener(int id)
		{
			foreach (HabilidadEspecial item in Datos.habilidadesEspeciales)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
	}
}
