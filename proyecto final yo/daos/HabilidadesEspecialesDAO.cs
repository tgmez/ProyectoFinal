using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public  class HabilidadesEspecialesDAO : HabilidadesEspecialesInterfaz
	{

		private static int contadorId = 1;

		public  void crear(HabilidadEspecial habilidadEspecial)
		{
			habilidadEspecial.Id = contadorId++;
			Datos.habilidadesEspeciales.Add(habilidadEspecial);

		}
		public  void modificar(HabilidadEspecial habilidadEspecial)
		{

		}
		public  List<HabilidadEspecial> listar()
		{
			return Datos.habilidadesEspeciales;
		}
		public  void eliminar(HabilidadEspecial habilidadEspecial)
		{
			Datos.habilidadesEspeciales.Remove(habilidadEspecial);
		}
		public  HabilidadEspecial obtener(int id)
		{
			foreach (HabilidadEspecial item in Datos.habilidadesEspeciales)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
	}
}
