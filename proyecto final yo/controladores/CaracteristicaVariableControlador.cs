using proyecto_final_yo.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.controladores
{
	public static class CaracteristicaVariableControlador
	{

		public static void Crear()
		{
			Console.WriteLine("Nombre:");
			String Nombre = InputUtils.leerString();

			CaracteristicaVariable caracteristicaVariable = new CaracteristicaVariable
			{
				nombre = Nombre
			};

			CaracteristicasVariablesDAO.crear(caracteristicaVariable);

			foreach (Personaje item in PersonajeDAO.listar()) {
				PersonajeCaracteristicaDAO.crear(new PersonajeCaracteristica {
					caracteristicaVariable = caracteristicaVariable,
					personaje = item,
					Valor = 1
				});
			}
		}

		public static void Modificar()
		{
			Listar();
			Console.WriteLine("Seleccione Id:");
			int id = InputUtils.leerId();
			if (CaracteristicasVariablesDAO.obtener(id) == null)
			{
				Console.WriteLine("Id no existe.");
				return;
			}
			CaracteristicaVariable item = CaracteristicasVariablesDAO.obtener(id);
			Console.WriteLine("Seleccione opcion: ");
			Console.WriteLine("1 - Nombre");
			int opcion = InputUtils.leerInt(1, 1);
			switch (opcion)
			{
				case 1:
					Console.WriteLine("Nombre:");
					item.nombre = InputUtils.leerString();
					break;
				default:
					Console.WriteLine("La opcion ingresada no es correcta");
					break;
			}
		}

		public static void Listar() {
			foreach (CaracteristicaVariable item in CaracteristicasVariablesDAO.listar())
			{
				Console.WriteLine("Id: {0} --- Nombre: {1}", item.Id, item.nombre);
			}
		}

		public static void Eliminar() {
			Listar();
			Console.WriteLine("Seleccione Id:");
			int id = InputUtils.leerId();
			if (CaracteristicasVariablesDAO.obtener(id) == null)
			{
				Console.WriteLine("Id no existe.");
				return;
			}
			CaracteristicasVariablesDAO.eliminar(CaracteristicasVariablesDAO.obtener(id));
		}
	}
}
