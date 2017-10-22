using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public  class RazaDAO : RazaInterfaz
	{
		private static int contadorId = 1;

		public  void crear(Raza raza)
		{
			raza.Id = contadorId++;
			Datos.razas.Add(raza);

		}
		public  void modificar(Raza raza)
		{

		}
		public  List<Raza> listar()
		{
			return Datos.razas;
		}
		public  void eliminar(Raza raza)
		{
			Datos.razas.Remove(raza);
		}
		public  Raza obtener(int id)
		{
			foreach (Raza item in Datos.razas)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public  Raza obtenerPorPersonaje(int idPersonaje)
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