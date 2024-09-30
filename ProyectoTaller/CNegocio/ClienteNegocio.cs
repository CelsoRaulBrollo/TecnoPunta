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
