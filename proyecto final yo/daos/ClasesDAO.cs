using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class ClasesDAO
	{

		private static int contadorId = 1;


		public static void crear(Clase clase)
		{
			clase.Id = contadorId++;
			Datos.clases.Add(clase);

		}
		public static void modificar(Clase clase)
		{

		}
		public static List<Clase> listar()
		{
			return Datos.clases;
		}
		public static void eliminar(Clase clase)
		{
			Datos.clases.Remove(clase);
		}
		public static Clase obtener(int id)
		{
			foreach (Clase item in Datos.clases)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public static Clase obtenerPorIdPersonaje(int id)
		{
			foreach (Clase item in Datos.clases)
			{
				foreach (Personaje p in item.personajes) {
					if (p.Id == id) return item;
				}
			}
			return null;
		}
	}
}
