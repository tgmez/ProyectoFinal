using proyecto_final_yo.controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo
{
	public class Program
	{
		static void Main(string[] args)
		{
			Datos.inicializar();
			int opcion = -1;
			while (opcion != 0)
			{
				Console.Clear();
				Console.WriteLine("------------------------------------------------------------------------------");
				Console.WriteLine("---------------------------BIENVENIDO-----------------------------------------");
				Console.WriteLine("------------------------------------------------------------------------------");
				Console.WriteLine("0- SALIR");
				Console.WriteLine("HABILIDADES ESPECIALES");
				Console.WriteLine("1- CREAR  ");
				Console.WriteLine("2- MODIFICAR  ");
				Console.WriteLine("3- LISTAR  ");
				Console.WriteLine("4- ELIMINAR  ");
				Console.WriteLine("5- LISTAR POR CLASE  ");
				Console.WriteLine("CLASES");
				Console.WriteLine("6- CREAR  ");
				Console.WriteLine("7- MODIFICAR  ");
				Console.WriteLine("8- LISTAR");
				Console.WriteLine("9- ELIMINAR");
				Console.WriteLine("PERSONAJES");
				Console.WriteLine("10- CREAR ");
				Console.WriteLine("11- MODIFICAR ");
				Console.WriteLine("12- LISTAR ");
				Console.WriteLine("13- ELIMINAR ");
				Console.WriteLine("14- LISTAR POR CLASE ");
				Console.WriteLine("15- LISTAR POR RAZA");
				Console.WriteLine("RAZAS");
				Console.WriteLine("16- CREAR ");
				Console.WriteLine("17- MODIFICAR ");
				Console.WriteLine("18- LISTAR");
				Console.WriteLine("19- ELIMINAR ");
				Console.WriteLine("CARACTERISTICAS");
				Console.WriteLine("20- CREAR ");
				Console.WriteLine("21- MODIFICAR ");
				Console.WriteLine("22- LISTAR");
				Console.WriteLine("23- ELIMINAR ");
				Console.WriteLine("NIVEL");
				Console.WriteLine("24- SUBIR NIVEL");
				Console.WriteLine("Ingrese la opción deseada:  ");
				opcion = InputUtils.leerInt();
				Console.Clear();
				switch (opcion)
				{
					case 0:
						Console.WriteLine("El programa ah finalizado");
						break;
					case 1:
						HabilidadesEspecialesControlador.Crear();
						break;
					case 2:
						HabilidadesEspecialesControlador.Modificar();
						break;
					case 3:
						HabilidadesEspecialesControlador.Listar();
						break;
					case 4:
						HabilidadesEspecialesControlador.Eliminar();
						break;
					case 5:
						HabilidadesEspecialesControlador.ListarPorClase();
						break;
					case 6:
						ClasesControlador.Crear();
						break;
					case 7:
						ClasesControlador.Modificar();
						break;
					case 8:
						ClasesControlador.Listar();
						break;
					case 9:
						ClasesControlador.Eliminar();
						break;
					case 10:
						PersonajeControlador.Crear();
						break;
					case 11:
						PersonajeControlador.Modificar();
						break;
					case 12:
						PersonajeControlador.Listar();
						break;
					case 13:
						PersonajeControlador.Eliminar();
						break;
					case 14:
						PersonajeControlador.ListarPorClase();
						break;
					case 15:
						PersonajeControlador.ListarPorRaza();
						break;
					case 16:
						RazaControlador.Crear();
						break;
					case 17:
						RazaControlador.Modificar();
						break;
					case 18:
						RazaControlador.Listar();
						break;
					case 19:
						RazaControlador.Eliminar();
						break;
					case 20:
						CaracteristicaVariableControlador.Crear();
						break;
					case 21:
						CaracteristicaVariableControlador.Modificar();
						break;
					case 22:
						CaracteristicaVariableControlador.Listar();
						break;
					case 23:
						CaracteristicaVariableControlador.Eliminar();
						break;
					case 24:
						PersonajeControlador.SubirNivel();
						break;
					default:
						Console.WriteLine("La opcion ingresada no es correcta");
						break;
				}
				Console.WriteLine("Presione una tecla para continuar...");
				Console.ReadKey();
			}

		}
	}
}
