﻿using proyecto_final_yo.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.daos
{
	public class ClasesDAO : ClaseInterfaz
	{

		private static int contadorId = 1;


		public  void crear(Clase clase)
		{
			clase.Id = contadorId++;
			Datos.clases.Add(clase);

		}
		public  void modificar(Clase clase)
		{

		}
		public  List<Clase> listar()
		{
			return Datos.clases;
		}
		public  void eliminar(Clase clase)
		{
			Datos.clases.Remove(clase);
		}
		public  Clase obtener(int id)
		{
			foreach (Clase item in Datos.clases)
			{
				if (item.Id == id) return item;
			}
			return null;
		}
		public  Clase obtenerPorIdPersonaje(int id)
		{
			foreach (Clase item in Datos.clases)
			{
				foreach (Personaje p in item.personajes) {
					if (p.Id == id) return item;
				}
			}
			return null;
		}
	}
}
