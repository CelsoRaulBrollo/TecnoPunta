using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;

namespace ProyectoTaller.CNegocio
{
    public class ClienteNegocio
    {
        private  ClienteDatos clienteDatos;

        public ClienteNegocio()
        {
            clienteDatos = new ClienteDatos();
        }

        

        public List<Clientes> ObtenerClientes() {
            ClienteDatos clienteDatos = new ClienteDatos();
            //tengo que hacer clientedto
            return clienteDatos.listaDeClientes();
        }

        public void registrarCliente(Clientes cliente)
        {
            clienteDatos = new ClienteDatos();
            clienteDatos.AgregarCliente(cliente);

        }

        public void editarCliente(Clientes cliente)
        {
            clienteDatos = new ClienteDatos();
            clienteDatos.EditarCliente(cliente);
        }

        public bool EsDNIExistente(int dniCliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            return clienteDatos.VerificarDNIExistente(dniCliente);
        }

        public bool EsTelefonoExistente(string telefono)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            return clienteDatos.VerificarTelefono(telefono);
        }

        public bool EsCorreoExistente(string correo)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            return clienteDatos.VerificarCorreo(correo);
        }

        public  Clientes buscarCliente (int dniCliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            return clienteDatos.buscarCliente(dniCliente);
        }

        public void altaCliente(int dniCliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.altaCliente(dniCliente);
        }

        public void bajaCliente(int dniCliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            clienteDatos.bajaCliente(dniCliente);
        }

        public List<Tuple<string, int>> GenerarInformeClientes(DateTime desde, DateTime hasta)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            DataTable dtClientes = clienteDatos.GenerarInformeClientes(desde, hasta);

           
            List<Tuple<string, int>> listaInforme = new List<Tuple<string, int>>();

            
            foreach (DataRow row in dtClientes.Rows)
            {
                string estado = row["Estado"].ToString();
                int cantidad = Convert.ToInt32(row["Cantidad"]);

                
                listaInforme.Add(new Tuple<string, int>(estado, cantidad));
            }

            return listaInforme;
        }

        public List<Tuple<int, string, int>> ObtenerInformeClientesGenero(int año)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            DataTable dtClientes = clienteDatos.ObtenerInformeClientesGenero();

            List<Tuple<int, string, int>> informeClientes = new List<Tuple<int, string, int>>();

            
            List<int> meses = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            
            List<string> generos = new List<string> { "Masculino", "Femenino", "Otro" };

            
            foreach (int mes in meses)
            {
                foreach (string genero in generos)
                {
                    
                    var fila = dtClientes.AsEnumerable()
                        .FirstOrDefault(row => Convert.ToInt32(row["Año"]) == año &&
                                               Convert.ToInt32(row["Mes"]) == mes &&
                                               row["genero"].ToString() == genero);

                    
                    int cantidad = fila != null ? Convert.ToInt32(fila["Cantidad_Clientes"]) : 0;

                    
                    informeClientes.Add(new Tuple<int, string, int>(mes, genero, cantidad));
                }
            }

            return informeClientes;
        }

        public List<Tuple<int, int>> ObtenerInformeClientesTotalesPorMes(int año)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            DataTable dtClientes = clienteDatos.ObtenerInformeClientesGenero();

            List<Tuple<int, int>> informeClientes = new List<Tuple<int, int>>();

        
            List<int> meses = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            
            foreach (int mes in meses)
            {
                
                var filasMes = dtClientes.AsEnumerable()
                    .Where(row => Convert.ToInt32(row["Año"]) == año &&
                                 Convert.ToInt32(row["Mes"]) == mes);

                
                int cantidadTotal = filasMes.Sum(row => Convert.ToInt32(row["Cantidad_Clientes"]));

               
                informeClientes.Add(new Tuple<int, int>(mes, cantidadTotal));
            }

            return informeClientes;
        }

        public List<int> ObtenerAñosDeDatosClientes()
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            DataTable dtClientes = clienteDatos.ObtenerInformeClientesGenero();
            List<int> años = new List<int>();

            
            foreach (DataRow row in dtClientes.Rows)
            {
                int año = Convert.ToInt32(row["Año"]);

                
                if (!años.Contains(año))
                {
                    años.Add(año);
                }
            }
            return años;
        }


    }
}
