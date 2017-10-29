using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_yo.database
{
	public class ProductoDA
	{
		//Esto está puesto aquí de forma provisoria, vamos a ver donde es conveniente colocar el connection string.
		static string _connectionString;

		public static int Add(Clase p)
		{
			int result = -1;

			using (SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProyectoFinal;Data Source=."))
			{
				string query = "INSERT INTO Productos (Nombre, Precio, Cantidad) VALUES (@Nombre, @Precio, @Cantidad)";
				SqlCommand command = new SqlCommand(query, connection);

				command.Parameters.AddWithValue("@Nombre", p.Nombre);

				connection.Open();

				result = command.ExecuteNonQuery();

				connection.Close();
			}

			return result;
		}

		public static List<Clase> GetAll()
		{
			List<Clase> result = null;

			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				string query = "SELECT ID, Nombre, Precio, Cantidad FROM Productos";
				SqlCommand command = new SqlCommand(query, connection);

				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					if (result == null)
					{
						result = new List<Clase>();
					}

					Clase p = new Clase();

					p.Id = (int)reader["ID"];
					p.Nombre = reader["ID"].ToString();
					/*p.Precio = (reader.IsDBNull(reader.GetOrdinal("Precio")) ? null : (double?)reader["Precio"]);
					p.Cantidad = (int)reader["Cantidad"];*/

					result.Add(p);
				}
			}

			return result;
		}
	}
}
