using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public class CaracteristicasVariablesDAO : CaracteristicaVariableInterfaz
	{

		private static int contadorId = 1;

		public void crear(CaracteristicaVariable caracteristicaVariable) {
			caracteristicaVariable.Id = contadorId++;
			Datos.caracteristicasVariables.Add(caracteristicaVariable);
		
		}
		public void modificar(CaracteristicaVariable caracteristicaVariable) {

		}
		public List<CaracteristicaVariable> listar() {
			return Datos.caracteristicasVariables;
		}
		public void eliminar(CaracteristicaVariable caracteristicaVariable) {
			Datos.caracteristicasVariables.Remove(caracteristicaVariable);
		}
		public CaracteristicaVariable obtener(int id) {
			foreach (CaracteristicaVariable item in Datos.caracteristicasVariables) {
				if (item.Id == id) return item;
			}
			return null;
		}
	}
}
