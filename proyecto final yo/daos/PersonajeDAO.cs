using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class PersonajeDAO
	{
		private static int contadorId = 1;

		public static void crear(Personaje personaje)
		{
			personaje.Id = contadorId++;
			Datos.personajes.Add(personaje);

		}
		public static void modificar(Personaje personaje)
		{

		}
		public static List<Personaje> listar()
		{
			return Datos.personajes;
		}
		public static void eliminar(Personaje personaje)
		{
			foreach (Raza raza in RazaDAO.listar()) {
				foreach (Personaje p in raza.personajes) {
					if (p.Id == personaje.Id) raza.personajes.Remove(p);
				}
			}
			foreach (Clase clase in ClasesDAO.listar())
			{
				foreach (Personaje p in clase.personajes)
				{
					if (p.Id == personaje.Id) clase.personajes.Remove(p);
				}
			}
			Datos.personajes.Remove(personaje);
		}
		public static Personaje obtener(int id)
		{
			foreach (Personaje item in Datos.personajes)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public static bool personajeTieneRaza(int id)
		{
			foreach (Raza raza in RazaDAO.listar()) {
				foreach (Personaje personaje in raza.personajes) {
					if (personaje.Id == id) return true;
				}
			}
			return false;
		}
		public static bool personajeTieneClase(int id)
		{
			foreach (Clase clase in ClasesDAO.listar())
			{
				foreach (Personaje personaje in clase.personajes)
				{
					if (personaje.Id == id) return true;
				}
			}
			return false;
		}
	}
}