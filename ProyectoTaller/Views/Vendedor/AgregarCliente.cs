using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProyectoTaller.CDatos;
using ProyectoTaller.CNegocio;

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
                using (var contexto = new TecnoPuntaBDEntities())
                {
                    var clientes = contexto.Clientes.ToList();

                    DGClientes.Rows.Clear();

                    foreach (var cliente in clientes)
                    {
                        DGClientes.Rows.Add(
                            cliente.DNI_Cliente,
                            cliente.Nombre_Cliente,
                            cliente.Apellido_Cliente,
                            cliente.Telefono_Cliente,
                            cliente.Correo_Cliente,
                            cliente.Direccion_Cliente
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
                    using (var contexto = new TecnoPuntaBDEntities())
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
                    using (var contexto = new TecnoPuntaBDEntities())
                    {
                        var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.DNI_Cliente == cliente.DNI_Cliente);
                        if (clienteExistente != null)
                        {
                            clienteExistente.Nombre_Cliente = cliente.Nombre_Cliente;
                            clienteExistente.Apellido_Cliente = cliente.Apellido_Cliente;
                            clienteExistente.Telefono_Cliente = cliente.Telefono_Cliente;
                            clienteExistente.Correo_Cliente = cliente.Correo_Cliente;
                            clienteExistente.Direccion_Cliente = cliente.Direccion_Cliente;

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
                    using (var contexto = new TecnoPuntaBDEntities())
                    {
                        var cliente = contexto.Clientes.FirstOrDefault(c => c.DNI_Cliente == dni);
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
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            if (ValidacionFormulario())
            {
                int dniCliente;

                if (!editando && int.TryParse(TDNICliente.Text, out dniCliente))
                {
                    if (clienteNegocio.EsDNIExistente(dniCliente))
                    {
                        LValidDNI.ForeColor = Color.Red;
                        LValidDNI.Text = "El DNI ya existe.";
                        return;
                    }
                }

                Clientes cliente = new Clientes
                {
                    DNI_Cliente = int.Parse(TDNICliente.Text),
                    Nombre_Cliente = TNombreCliente.Text,
                    Apellido_Cliente = TApellidoCliente.Text,
                    Telefono_Cliente = TTelefonoCliente.Text,
                    Correo_Cliente = TCorreoCliente.Text,
                    Direccion_Cliente = TDireccionCliente.Text
                };

                string mensaje = editando ? "¿Está seguro que desea modificar este cliente?" : "¿Está seguro que desea agregar este cliente?";
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (editando)
                    {
                        if (clienteDatos.ActualizarCliente(cliente))
                        {
                            DataGridViewRow fila = DGClientes.SelectedRows[0];
                            fila.Cells["CDNI"].Value = cliente.DNI_Cliente;
                            fila.Cells["CNombreCliente"].Value = cliente.Nombre_Cliente;
                            fila.Cells["CApellidoCliente"].Value = cliente.Apellido_Cliente;
                            fila.Cells["CTelefonoCliente"].Value = cliente.Telefono_Cliente;
                            fila.Cells["CCorreoCliente"].Value = cliente.Correo_Cliente;
                            fila.Cells["CDireccionCliente"].Value = cliente.Direccion_Cliente;
                            LValido.Text = "Cliente editado exitosamente!";
                            LimpiarCampos();
                            editando = false;
                            BAgregar.Enabled = true;

                            TDNICliente.ReadOnly = false;
                            TDNICliente.BackColor = Color.White;

                            BAgregar.Text = "Agregar";
                        }
                        else
                        {
                            LValido.Text = "Error al editar el cliente.";
                        }
                    }
                    else
                    {
                        if (clienteDatos.AgregarCliente(cliente))
                        {
                            DGClientes.Rows.Add(
                                cliente.DNI_Cliente,
                                cliente.Nombre_Cliente,
                                cliente.Apellido_Cliente,
                                cliente.Telefono_Cliente,
                                cliente.Correo_Cliente,
                                cliente.Direccion_Cliente
                            );
                            LValido.Text = "Cliente registrado exitosamente!";
                            LimpiarCampos();
                        }
                        else
                        {
                            LValido.Text = "Error al registrar el cliente.";
                        }
                    }

                    LimpiarCampos();
                }
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
                var result = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LimpiarMensajesDeValidacion();
                    LValido.Text = string.Empty;
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
                MessageBox.Show("Datos Borrados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrEmpty(TDNICliente.Text) || !TDNICliente.Text.All(char.IsDigit) || TDNICliente.Text.Length < 7 || TDNICliente.Text.Length > 8)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TNombreCliente.Text) || TNombreCliente.Text.Length > 30 || !System.Text.RegularExpressions.Regex.IsMatch(TNombreCliente.Text, @"^[a-zA-Z]+$"))
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TApellidoCliente.Text) || TApellidoCliente.Text.Length > 30 || !System.Text.RegularExpressions.Regex.IsMatch(TApellidoCliente.Text, @"^[a-zA-Z]+$"))
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TTelefonoCliente.Text) || !TTelefonoCliente.Text.All(char.IsDigit) || TTelefonoCliente.Text.Length < 10 || TTelefonoCliente.Text.Length > 12)
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TCorreoCliente.Text) || !TCorreoCliente.Text.Contains("@") || !TCorreoCliente.Text.Contains(".") || TCorreoCliente.Text.Length > 100)
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
            string nombreCliente = TNombreCliente.Text.Trim();
            string apellidoCliente = TApellidoCliente.Text.Trim();
            string dniCliente = TDNICliente.Text;
            string telefonoCliente = TTelefonoCliente.Text;
            string correoCliente = TCorreoCliente.Text;
            string direccionCliente = TDireccionCliente.Text;

            if (string.IsNullOrEmpty(dniCliente) || !dniCliente.All(char.IsDigit))
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese un DNI válido (solo números).";
            }
            else if (dniCliente.Length < 7 || dniCliente.Length > 8)
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "El DNI debe tener entre 7 y 8 caracteres.";
            }
            else
            {
                LValidDNI.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(telefonoCliente) || !telefonoCliente.All(char.IsDigit))
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un teléfono válido (solo números).";
            }
            else if (telefonoCliente.Length < 10 || telefonoCliente.Length > 12)
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "El teléfono debe tener entre 10 y 12 caracteres.";
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
            else if (correoCliente.Contains(" "))
            {
                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "El correo no debe contener espacios.";
            }
            else if (!correoCliente.Contains("@") || !correoCliente.Contains("."))
            {
                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "El correo debe contener '@' y '.'.";
            }
            else if (correoCliente.Length > 100)
            {
                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "El correo debe tener menos de 100 caracteres.";
            }
            else
            {
                LValiCorreo.Text = string.Empty;
            }

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
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreCliente, @"^[a-zA-Z]+$"))
            {
                LValiNombre.ForeColor = Color.Red;
                LValiNombre.Text = "El nombre solo debe contener letras.";
            }
            else
            {
                LValiNombre.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(apellidoCliente))
            {
                LValiApellidoCliente.ForeColor = Color.Red;
                LValiApellidoCliente.Text = "Ingrese el apellido del cliente.";
            }
            else if (apellidoCliente.Length > 30)
            {
                LValiApellidoCliente.ForeColor = Color.Red;
                LValiApellidoCliente.Text = "Ingrese menos de 30 caracteres.";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(apellidoCliente, @"^[a-zA-Z]+$"))
            {
                LValiApellidoCliente.ForeColor = Color.Red;
                LValiApellidoCliente.Text = "El apellido solo debe contener letras.";
            }
            else
            {
                LValiApellidoCliente.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(direccionCliente))
            {
                LValiDireccionCliente.ForeColor = Color.Red;
                LValiDireccionCliente.Text = "Ingrese la dirección del cliente.";
            }
            else if (direccionCliente.Length > 200)
            {
                LValiDireccionCliente.ForeColor = Color.Red;
                LValiDireccionCliente.Text = "La dirección debe tener menos de 200 caracteres.";
            }
            else
            {
                LValiDireccionCliente.Text = string.Empty;
            }
        }
    }
}