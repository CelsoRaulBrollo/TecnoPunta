using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
