using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public  class PersonajeDAO : PersonajeInterfaz
	{
		private static int contadorId = 1;

		public  void crear(Personaje personaje)
		{
			personaje.Id = contadorId++;
			Datos.personajes.Add(personaje);

		}
		public  void modificar(Personaje personaje)
		{

		}
		public  List<Personaje> listar()
		{
			return Datos.personajes;
		}
		public  void eliminar(Personaje personaje)
		{
			foreach (Raza raza in new RazaDAO().listar()) {
				foreach (Personaje p in raza.personajes) {
					if (p.Id == personaje.Id) raza.personajes.Remove(p);
				}
			}
			foreach (Clase clase in new ClasesDAO().listar())
			{
				foreach (Personaje p in clase.personajes)
				{
					if (p.Id == personaje.Id) clase.personajes.Remove(p);
				}
			}
			Datos.personajes.Remove(personaje);
		}
		public  Personaje obtener(int id)
		{
			foreach (Personaje item in Datos.personajes)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public  bool personajeTieneRaza(int id)
		{
			foreach (Raza raza in new RazaDAO().listar()) {
				foreach (Personaje personaje in raza.personajes) {
					if (personaje.Id == id) return true;
				}
			}
			return false;
		}
		public  bool personajeTieneClase(int id)
		{
			foreach (Clase clase in new ClasesDAO().listar())
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