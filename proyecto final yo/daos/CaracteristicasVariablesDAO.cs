using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public static class CaracteristicasVariablesDAO
	{

		private static int contadorId = 1;


		public static void crear(CaracteristicaVariable caracteristicaVariable) {
			caracteristicaVariable.Id = contadorId++;
			Datos.caracteristicasVariables.Add(caracteristicaVariable);
		
		}
		public static void modificar(CaracteristicaVariable caracteristicaVariable) {

		}
		public static List<CaracteristicaVariable> listar() {
			return Datos.caracteristicasVariables;
		}
		public static void eliminar(CaracteristicaVariable caracteristicaVariable) {
			Datos.caracteristicasVariables.Remove(caracteristicaVariable);
		}
		public static CaracteristicaVariable obtener(int id) {
			foreach (CaracteristicaVariable item in Datos.caracteristicasVariables) {
				if (item.Id == id) return item;
			}
			return null;
		}
	}
}
