﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo
{
	public class Clase
	{
		public int Id;
		public string Nombre;
		public String Descripcion;
		public List<Personaje> personajes { get; set; }
		public List<HabilidadEspecial> habilidadesEspeciales { get; set; }
	}
}
