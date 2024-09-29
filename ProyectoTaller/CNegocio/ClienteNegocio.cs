using System;
using System.Data;
using ProyectoTaller.CDatos;

namespace ProyectoTaller.CNegocio
{
    public class ClienteNegocio
    {
        private readonly ClienteDatos clienteDatos;

        public ClienteNegocio()
        {
            clienteDatos = new ClienteDatos();
        }

        public DataTable ObtenerClientes()
        {
            return clienteDatos.ObtenerClientes();
        }

        public void AgregarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            if (ValidarCliente(dni, nombre, apellido, telefono, correo, direccion))
            {
                clienteDatos.AgregarCliente(dni, nombre, apellido, telefono, correo, direccion);
            }
            else
            {
                throw new ArgumentException("Los datos del cliente no son válidos.");
            }
        }

        public void EditarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            if (ValidarCliente(dni, nombre, apellido, telefono, correo, direccion))
            {
                clienteDatos.EditarCliente(dni, nombre, apellido, telefono, correo, direccion);
            }
            else
            {
                throw new ArgumentException("Los datos del cliente no son válidos.");
            }
        }

        public void BorrarCliente(int dni)
        {
            clienteDatos.BorrarCliente(dni);
        }

        private bool ValidarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            return dni > 0 && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido);
        }
    }
}

