using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class MetodoDePagoDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public MetodoDePagoModel BuscarMetodoDePagoPorId(int idMetodoDePago)
        {
            MetodoDePagoModel metodoDePago = null;

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM MetodoDePago WHERE Id_MetodoDePago = @idMetodoDePago";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idMetodoDePago", idMetodoDePago);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            metodoDePago = new MetodoDePagoModel
                            {
                                id_MetodoDePago = Convert.ToInt32(reader["Id_MetodoDePago"]),
                                nombre = reader["Descripcion_MetodoDePago"].ToString()
                            };
                        }
                    }
                }
            }

            return metodoDePago;
        }
    }
}
