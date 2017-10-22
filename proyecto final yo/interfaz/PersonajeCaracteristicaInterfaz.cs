using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.interfaz
{
	public interface PersonajeCaracteristicaInterfaz
	{
		void crear(PersonajeCaracteristica personajeCaracteristica);
		void modificar(PersonajeCaracteristica personajeCaracteristica);
		List<PersonajeCaracteristica> listar();
		void eliminar(PersonajeCaracteristica personajeCaracteristica);
		PersonajeCaracteristica obtener(int id);
		List<PersonajeCaracteristica> obtenerCaracteristicaPersonajesPorPersonaje(int id);
	}
}
