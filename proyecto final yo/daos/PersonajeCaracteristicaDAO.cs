using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class PersonajeCaracteristicaDAO
	{
		private static int contadorId = 1;

		public static void crear(PersonajeCaracteristica personajeCaracteristica)
		{
			personajeCaracteristica.Id = contadorId++;
			Datos.personajesCaracteristicas.Add(personajeCaracteristica);

		}
		public static void modificar(PersonajeCaracteristica personajeCaracteristica)
		{

		}
		public static List<PersonajeCaracteristica> listar()
		{
			return Datos.personajesCaracteristicas;
		}
		public static void eliminar(PersonajeCaracteristica personajeCaracteristica)
		{
			Datos.personajesCaracteristicas.Remove(personajeCaracteristica);

		}
		public static PersonajeCaracteristica obtener(int id)
		{
			foreach (PersonajeCaracteristica item in Datos.personajesCaracteristicas)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public static List<PersonajeCaracteristica> obtenerCaracteristicaPersonajesPorPersonaje(int id)
		{
			List<PersonajeCaracteristica> result = new List<PersonajeCaracteristica>();
			foreach (PersonajeCaracteristica item in Datos.personajesCaracteristicas)
			{
				if (item.Id == id) result.Add(item);
			}
			return result;
		}
	}
}