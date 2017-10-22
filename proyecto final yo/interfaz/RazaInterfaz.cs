using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.interfaz
{
	public interface RazaInterfaz
	{
		void crear(Raza raza);
		void modificar(Raza raza);
		List<Raza> listar();
		void eliminar(Raza raza);
		Raza obtener(int id);
		Raza obtenerPorPersonaje(int idPersonaje);
	}
}
