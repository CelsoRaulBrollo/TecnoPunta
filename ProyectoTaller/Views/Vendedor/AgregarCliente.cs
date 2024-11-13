using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class AgregarCliente : Form
    {
        private ClienteDatos clienteDatos;
        private ClienteNegocio clienteNegocio;
        private readonly ConexionBD conexion = new ConexionBD();

        public AgregarCliente()
        {
            InitializeComponent();
            ClienteDatos clienteDatos = new ClienteDatos();
            ClienteNegocio clienteNegocios = new ClienteNegocio();
            CargarClientes();
        }

        private void CargarClientes()
        {
            clienteNegocio = new ClienteNegocio();
            DGClientes.DataSource = clienteNegocio.ObtenerClientes();

        }

        

        private bool editando = false;

        private void BAgregar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            ClienteDatos clienteDatos = new ClienteDatos();

            if (ValidacionFormulario())
            {
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
                    ClienteNegocio clientesNegocio = new ClienteNegocio();

                    if (!editando)
                    {
                        string correo = TCorreoCliente.Text;
                        string dni = TDNICliente.Text;

                        if (clienteNegocio.EsDNIExistente(int.Parse(dni)))
                        {
                            LValidDNI.ForeColor = Color.Red;
                            LValidDNI.Text = "El DNI ya está en uso.";
                            return;
                        }

                        if (clienteNegocio.EsCorreoExistente(correo))
                        {
                            LValiCorreo.ForeColor = Color.Red;
                            LValiCorreo.Text = "El correo ya está en uso.";
                            return;
                        }
                    }

                    if (editando)
                    {
                        TDNICliente.ReadOnly = false;
                        TDNICliente.BackColor = Color.White;
                        TCorreoCliente.ReadOnly = false;
                        TCorreoCliente.BackColor = Color.White;

                        clienteNegocio = new ClienteNegocio();

                        Clientes clienteEditar = new Clientes
                        {
                            DNI_Cliente = int.Parse(TDNICliente.Text),
                            Nombre_Cliente = TNombreCliente.Text,
                            Apellido_Cliente = TApellidoCliente.Text,
                            Telefono_Cliente = TTelefonoCliente.Text,
                            Correo_Cliente = TCorreoCliente.Text,
                            Direccion_Cliente = TDireccionCliente.Text,
                            Genero = CBGeneroCliente.SelectedItem.ToString()

                        };
                        clienteNegocio.editarCliente(clienteEditar);
                        LValido.Text = "Cliente editado exitosamente!";
                    }
                    else
                    {
                        try
                        {
                            clienteNegocio = new ClienteNegocio();

                            Clientes clienteRegistrar = new Clientes {
                                DNI_Cliente = int.Parse(TDNICliente.Text),
                                Nombre_Cliente = TNombreCliente.Text,
                                Apellido_Cliente = TApellidoCliente.Text,
                                Telefono_Cliente = TTelefonoCliente.Text,
                                Correo_Cliente = TCorreoCliente.Text,
                                Direccion_Cliente = TDireccionCliente.Text,
                                Genero = CBGeneroCliente.SelectedItem.ToString()

                            };
                            clienteNegocio.registrarCliente( clienteRegistrar );
                            LValido.Text = "Cliente registrado exitosamente!";


                        }
                        catch (Exception ex)
                        {
                            LValido.Text = $"Se produjo un error: {ex.Message}";
                        }
                    }
                    CargarClientes();
                    LimpiarCampos();
                    editando = false;
                    BAgregar.Text = "Agregar";
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

                    TDNICliente.Text = fila.Cells["DNI_Cliente"].Value.ToString();
                    TNombreCliente.Text = fila.Cells["Nombre_Cliente"].Value.ToString();
                    TApellidoCliente.Text = fila.Cells["Apellido_Cliente"].Value.ToString();
                    TTelefonoCliente.Text = fila.Cells["Telefono_Cliente"].Value.ToString();
                    TCorreoCliente.Text = fila.Cells["Correo_Cliente"].Value.ToString();
                    TDireccionCliente.Text = fila.Cells["Direccion_Cliente"].Value.ToString();
                    string genero = fila.Cells["Genero"].Value.ToString();
                    if (CBGeneroCliente.Items.Contains(genero))
                    {
                        CBGeneroCliente.SelectedItem = genero;
                    }
                    else
                    {
                        CBGeneroCliente.SelectedIndex = -1; 
                    }

                    BAgregar.Enabled = true;
                    TDNICliente.ReadOnly = true;
                    TDNICliente.BackColor = Color.LightGray;
                    TCorreoCliente.ReadOnly = true;
                    TCorreoCliente.BackColor = Color.LightGray;
                    editando = true;

                    BAgregar.Text = "Modificar";
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TDNICliente.Clear();
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

            if (string.IsNullOrEmpty(TNombreCliente.Text) || TNombreCliente.Text.Length > 30 || !System.Text.RegularExpressions.Regex.IsMatch(TNombreCliente.Text, @"^[a-zA-ZÀ-ÿ\s,]+$"))
            {
                respuesta = false;
            }

            if (string.IsNullOrEmpty(TApellidoCliente.Text) || TApellidoCliente.Text.Length > 30 || !System.Text.RegularExpressions.Regex.IsMatch(TApellidoCliente.Text, @"^[a-zA-ZÀ-ÿ\s,]+$"))
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
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreCliente, @"^[a-zA-ZÀ-ÿ\s,]+$"))
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
            else if (!System.Text.RegularExpressions.Regex.IsMatch(apellidoCliente, @"^[a-zA-ZÀ-ÿ\s,]+$"))
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

        private void TBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes(TBuscarCliente.Text);
        }

        private void FiltrarClientes(string buscarTexto)
        {
            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                bool rowVisible =
                    row.Cells["DNI_Cliente"].Value.ToString().IndexOf(buscarTexto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    row.Cells["Nombre_Cliente"].Value.ToString().IndexOf(buscarTexto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    row.Cells["Apellido_Cliente"].Value.ToString().IndexOf(buscarTexto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    row.Cells["Telefono_Cliente"].Value.ToString().IndexOf(buscarTexto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    row.Cells["Correo_Cliente"].Value.ToString().IndexOf(buscarTexto, StringComparison.OrdinalIgnoreCase) >= 0;
                DGClientes.CurrentCell = null;
                row.Visible = rowVisible;
            }
        }
    }
}