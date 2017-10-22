using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public  class PersonajeCaracteristicaDAO : PersonajeCaracteristicaInterfaz
	{
		private static int contadorId = 1;

		public  void crear(PersonajeCaracteristica personajeCaracteristica)
		{
			personajeCaracteristica.Id = contadorId++;
			Datos.personajesCaracteristicas.Add(personajeCaracteristica);

		}
		public  void modificar(PersonajeCaracteristica personajeCaracteristica)
		{

		}
		public  List<PersonajeCaracteristica> listar()
		{
			return Datos.personajesCaracteristicas;
		}
		public  void eliminar(PersonajeCaracteristica personajeCaracteristica)
		{
			Datos.personajesCaracteristicas.Remove(personajeCaracteristica);

		}
		public  PersonajeCaracteristica obtener(int id)
		{
			foreach (PersonajeCaracteristica item in Datos.personajesCaracteristicas)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public  List<PersonajeCaracteristica> obtenerCaracteristicaPersonajesPorPersonaje(int id)
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