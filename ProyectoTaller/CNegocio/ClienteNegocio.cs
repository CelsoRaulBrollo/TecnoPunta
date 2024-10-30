using System;
using System.Collections.Generic;
using System.Data;
using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;

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

        public List<Clientes> ObtenerClientes() {
            ClienteDatos clienteDatos = new ClienteDatos();
            //tengo que hacer clientedto
            return clienteDatos.listaDeClientes();
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
    }
}
