using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class RazaDAO
	{
		private static int contadorId = 1;

		public static void crear(Raza raza)
		{
			raza.Id = contadorId++;
			Datos.razas.Add(raza);

		}
		public static void modificar(Raza raza)
		{

		}
		public static List<Raza> listar()
		{
			return Datos.razas;
		}
		public static void eliminar(Raza raza)
		{
			Datos.razas.Remove(raza);
		}
		public static Raza obtener(int id)
		{
			foreach (Raza item in Datos.razas)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public static Raza obtenerPorPersonaje(int idPersonaje)
		{
			foreach (Raza item in Datos.razas)
			{
				foreach (Personaje personaje in item.personajes)
				{
					if (personaje.Id == idPersonaje) return item;
				}
			}
			return null;
		}
	}
}