﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo
{
	public class PersonajeCaracteristica
	{
		public int Id { get; set; }
		public int Valor { get; set; }
		public CaracteristicaVariable caracteristicaVariable { get; set; }
		public Personaje personaje { get; set; }

	}
}
