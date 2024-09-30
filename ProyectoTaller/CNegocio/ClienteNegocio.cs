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
            if (dni <= 0)
            {
                throw new ArgumentException("DNI no puede ser menor o igual a cero.");
            }

            clienteDatos.BorrarCliente(dni);
        }

        private bool ValidarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            bool isDniValid = dni > 0;
            bool isNombreValid = !string.IsNullOrEmpty(nombre) && nombre.Length <= 100;
            bool isApellidoValid = !string.IsNullOrEmpty(apellido) && apellido.Length <= 100;
            bool isTelefonoValid = telefono > 0;
            bool isCorreoValid = !string.IsNullOrEmpty(correo) && correo.Length <= 150;
            bool isDireccionValid = !string.IsNullOrEmpty(direccion) && direccion.Length <= 150;

            return isDniValid && isNombreValid && isApellidoValid && isTelefonoValid && isCorreoValid && isDireccionValid;
        }

        public bool EsDNIExistente(int dniCliente)
        {
            ClienteDatos clienteDatos = new ClienteDatos();
            return clienteDatos.VerificarDNIExistente(dniCliente);
        }
    }
}
