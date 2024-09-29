using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProyectoTaller.CDatos;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class AgregarCliente : Form
    {
        private ClienteDatos clienteDatos;

        public AgregarCliente()
        {
            InitializeComponent();
            clienteDatos = new ClienteDatos();
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                using (var contexto = new BaseTecnoPuntaEntities())
                {
                    var clientes = contexto.Clientes.ToList();

                    DGClientes.Rows.Clear();

                    foreach (var cliente in clientes)
                    {
                        DGClientes.Rows.Add(
                            cliente.DNI,
                            cliente.Nombre,
                            cliente.Apellido,
                            cliente.Telefono,
                            cliente.Correo,
                            cliente.Direccion
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public class ClienteDatos
        {
            public bool AgregarCliente(Clientes cliente)
            {
                try
                {
                    using (var contexto = new BaseTecnoPuntaEntities())
                    {
                        contexto.Clientes.Add(cliente);
                        contexto.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }

            internal bool ActualizarCliente(Clientes cliente)
            {
                try
                {
                    using (var contexto = new BaseTecnoPuntaEntities())
                    {
                        var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.DNI == cliente.DNI);
                        if (clienteExistente != null)
                        {
                            clienteExistente.Nombre = cliente.Nombre;
                            clienteExistente.Apellido = cliente.Apellido;
                            clienteExistente.Telefono = cliente.Telefono;
                            clienteExistente.Correo = cliente.Correo;
                            clienteExistente.Direccion = cliente.Direccion;

                            contexto.SaveChanges();
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }

            internal bool EliminarCliente(int dni)
            {
                try
                {
                    using (var contexto = new BaseTecnoPuntaEntities())
                    {
                        var cliente = contexto.Clientes.FirstOrDefault(c => c.DNI == dni);
                        if (cliente != null)
                        {
                            contexto.Clientes.Remove(cliente);
                            contexto.SaveChanges();
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }
        }

        private bool editando = false;

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();

            if (ValidacionFormulario())
            {
                Clientes cliente = new Clientes
                {
                    DNI = int.Parse(TDNICliente.Text),
                    Nombre = TNombreCliente.Text,
                    Apellido = TApellidoCliente.Text,
                    Telefono = int.Parse(TTelefonoCliente.Text),
                    Correo = TCorreoCliente.Text,
                    Direccion = TDireccionCliente.Text
                };

                if (editando)
                {
                    if (clienteDatos.ActualizarCliente(cliente))
                    {
                        DataGridViewRow fila = DGClientes.SelectedRows[0];
                        fila.Cells["CDNI"].Value = cliente.DNI;
                        fila.Cells["CNombreCliente"].Value = cliente.Nombre;
                        fila.Cells["CApellidoCliente"].Value = cliente.Apellido;
                        fila.Cells["CTelefonoCliente"].Value = cliente.Telefono;
                        fila.Cells["CCorreoCliente"].Value = cliente.Correo;
                        fila.Cells["CDireccionCliente"].Value = cliente.Direccion;
                        LRespuestaNuevoCliente.Text = "Editado Exitosamente!";
                        LimpiarCampos();
                        editando = false;
                        BAgregar.Enabled = true;

                        TDNICliente.ReadOnly = false;
                        TDNICliente.BackColor = Color.White;

                        BAgregar.Text = "Agregar";
                    }
                    else
                    {
                        LRespuestaNuevoCliente.Text = "Error al editar el cliente.";
                    }
                }
                else
                {
                    if (clienteDatos.AgregarCliente(cliente))
                    {
                        DGClientes.Rows.Add(
                            cliente.DNI,
                            cliente.Nombre,
                            cliente.Apellido,
                            cliente.Telefono,
                            cliente.Correo,
                            cliente.Direccion
                        );
                        LRespuestaNuevoCliente.Text = "Registrado Exitosamente!";
                        LimpiarCampos();
                    }
                    else
                    {
                        LRespuestaNuevoCliente.Text = "Error al registrar el cliente.";
                    }
                }

                LimpiarMensajesDeValidacion();
                LimpiarCampos();
            }
            else
            {
                ValidarFormularioLabel();
            }
        }

        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            if (DGClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = DGClientes.SelectedRows[0];

                TDNICliente.Text = fila.Cells["CDNI"].Value.ToString();
                TNombreCliente.Text = fila.Cells["CNombreCliente"].Value.ToString();
                TApellidoCliente.Text = fila.Cells["CApellidoCliente"].Value.ToString();
                TTelefonoCliente.Text = fila.Cells["CTelefonoCliente"].Value.ToString();
                TCorreoCliente.Text = fila.Cells["CCorreoCliente"].Value.ToString();
                TDireccionCliente.Text = fila.Cells["CDireccionCliente"].Value.ToString();

                BAgregar.Enabled = true;
                TDNICliente.ReadOnly = true;
                TDNICliente.BackColor = Color.LightGray;
                editando = true;

                BAgregar.Text = "Modificar";
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar todos los datos?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { 
                LimpiarCampos();
                LimpiarMensajesDeValidacion();
            }
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiApellidoCliente.Text = string.Empty;
            LValiCorreo.Text = string.Empty;
            LValiNombre.Text = string.Empty;
            LValiTelefono.Text = string.Empty;
            LValidDNI.Text = string.Empty;
            LValiDireccionCliente.Text = string.Empty;
            LRespuestaNuevoCliente.Text = string.Empty;
        }

        private void LimpiarCampos()
        {
            if (editando)
            {
                TNombreCliente.Clear();
                TApellidoCliente.Clear();
                TTelefonoCliente.Clear();
                TCorreoCliente.Clear();
                TDireccionCliente.Clear();
            }
            else
            {
                TDNICliente.Clear();
                TNombreCliente.Clear();
                TApellidoCliente.Clear();
                TTelefonoCliente.Clear();
                TCorreoCliente.Clear();
                TDireccionCliente.Clear();
            }

            LimpiarMensajesDeValidacion();
        }

        private bool ValidacionFormulario()
        {
            bool respuesta = true;

            if (string.IsNullOrEmpty(TNombreCliente.Text) || TNombreCliente.Text.Length > 30)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TApellidoCliente.Text) || TApellidoCliente.Text.Length > 30)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TDNICliente.Text) || !int.TryParse(TDNICliente.Text, out _) || TDNICliente.Text.Length > 9)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TTelefonoCliente.Text) || !int.TryParse(TTelefonoCliente.Text, out _) || TTelefonoCliente.Text.Length > 12)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TCorreoCliente.Text) || TCorreoCliente.Text.Length > 100)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TDireccionCliente.Text) || TDireccionCliente.Text.Length > 200)
            {
                respuesta = false;
            }

            return respuesta;
        }

        private void ValidarFormularioLabel()
        {
            string nombreCliente = TNombreCliente.Text;
            string appellidosCliente = TApellidoCliente.Text;
            string dniCliente = TDNICliente.Text;
            string telefonoCliente = TTelefonoCliente.Text;
            string correoCliente = TCorreoCliente.Text;
            string direccionCliente = TDireccionCliente.Text;

            if (string.IsNullOrEmpty(nombreCliente))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Ingrese el nombre del cliente.";
            }
            else if (nombreCliente.Length > 30)
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "Ingrese menos de 30 caracteres.";
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(appellidosCliente))
            {
                LValiApellidoCliente.ForeColor = Color.Red;
                LValiApellidoCliente.Text = "Ingrese el apellido del cliente.";
            }
            else if (appellidosCliente.Length > 30)
            {
                LValiApellidoCliente.ForeColor = Color.Red;
                LValiApellidoCliente.Text = "Ingrese menos de 30 caracteres.";
            }
            else
            {
                LValiApellidoCliente.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(dniCliente) || !int.TryParse(dniCliente, out _))
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese un DNI válido.";
            }
            else if (dniCliente.Length > 9)
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese menos de 9 caracteres.";
            }
            else
            {
                LValidDNI.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(telefonoCliente) || !int.TryParse(telefonoCliente, out _))
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un teléfono válido.";
            }
            else if (telefonoCliente.Length > 12)
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese menos de 12 caracteres.";
            }
            else
            {
                LValiTelefono.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(correoCliente))
            {
                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "Ingrese un correo.";
            }
            else if (correoCliente.Length > 100)
            {
                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "Ingrese menos de 100 caracteres.";
            }
            else
            {
                LValiCorreo.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(direccionCliente))
            {
                LValiDireccionCliente.ForeColor = Color.Red;
                LValiDireccionCliente.Text = "Ingrese la dirección del cliente.";
            }
            else if (direccionCliente.Length > 200)
            {
                LValiDireccionCliente.ForeColor = Color.Red;
                LValiDireccionCliente.Text = "Ingrese menos de 200 caracteres.";
            }
            else
            {
                LValiDireccionCliente.Text = string.Empty;
            }
        }
    }
}
