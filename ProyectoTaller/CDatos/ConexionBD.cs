using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoTaller.CDatos
{
    public class ConexionBD
    {
        public string cadenaConexion = ConfigurationManager.ConnectionStrings["TecnoPuntaDB"].ConnectionString;

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public void RealizarBackup(string rutaBackup)
        {
            try
            {
                
                using (SqlConnection connection = ObtenerConexion())  
                {
                    connection.Open();  

                    
                    string backupQuery = $"BACKUP DATABASE [TecnoPuntaBD] TO DISK = '{rutaBackup}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery(); 
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception($"Error al realizar el backup: {ex.Message}");
            }
        }

        public void RealizarRestore(string rutaBackup)
        {
            try
            {
                // Usar la cadena de conexión para conectarse a la base de datos "master"
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-TVROUOE;Database=master;Integrated Security=True"))
                {
                    connection.Open();  // Abrir la conexión

                    // Desconectar todas las conexiones activas a la base de datos TecnoPuntaBD
                    string disconnectQuery = @"
                    DECLARE @sql NVARCHAR(MAX) = N'';
                    SELECT @sql = @sql + 'KILL ' + CAST(spid AS NVARCHAR(10)) + ';'
                    FROM sys.sysprocesses WHERE dbid = DB_ID('TecnoPuntaBD');
                    EXEC sp_executesql @sql;
                ";

                    using (SqlCommand disconnectCommand = new SqlCommand(disconnectQuery, connection))
                    {
                        disconnectCommand.ExecuteNonQuery(); // Desconectar todas las sesiones activas
                    }

                    // Cambiar la base de datos TecnoPuntaBD a modo de un solo usuario
                    string query = $@"
                    ALTER DATABASE [TecnoPuntaBD] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                    RESTORE DATABASE [TecnoPuntaBD] FROM DISK = '{rutaBackup}' WITH REPLACE;
                    ALTER DATABASE [TecnoPuntaBD] SET MULTI_USER;
                ";

                    // Ejecutar el comando SQL para restaurar la base de datos
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery(); // Realizar la restauración
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al restaurar el backup: {ex.Message}");
            }
        }
    }
}