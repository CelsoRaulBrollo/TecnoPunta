using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        bool editando = false;
        private void BEditarCliente_Click(object sender, EventArgs e)
        {
            if (DGClientes.SelectedRows.Count > 0)
            {
                // Cargar la fila seleccionada
                DataGridViewRow fila = DGClientes.SelectedRows[0];

                if (string.IsNullOrWhiteSpace(TNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(TApellidoCliente.Text) ||
                    string.IsNullOrWhiteSpace(TDNICliente.Text) ||
                    string.IsNullOrWhiteSpace(TCorreoCliente.Text) ||
                    string.IsNullOrWhiteSpace(TDireccionCliente.Text) ||
                    string.IsNullOrWhiteSpace(TTelefonoCliente.Text))
                {
                    // Cargar los valores de la fila en los TextBox
                    TNombreCliente.Text = fila.Cells["CNombreCliente"].Value.ToString();
                    TApellidoCliente.Text = fila.Cells["CApellidoCliente"].Value.ToString();
                    TDNICliente.Text = fila.Cells["CDNI"].Value.ToString();
                    TCorreoCliente.Text = fila.Cells["CCorreoCliente"].Value.ToString();
                    TDireccionCliente.Text = fila.Cells["CDireccionCliente"].Value.ToString();
                    TTelefonoCliente.Text = fila.Cells["CTelefonoCliente"].Value.ToString();

                }
                else
                {
                    LimpiarMensajesDeValidacion();
                    if (ValidacionFormulario())
                    {
                        // Actualizar la fila con los datos de los TextBox
                        fila.Cells["CNombreCliente"].Value = TNombreCliente.Text;
                        fila.Cells["CApellidoCliente"].Value = TApellidoCliente.Text;
                        fila.Cells["CDNI"].Value = TDNICliente.Text;
                        fila.Cells["CCorreoCliente"].Value = TCorreoCliente.Text;
                        fila.Cells["CDireccionCliente"].Value = TDireccionCliente.Text;
                        fila.Cells["CTelefonoCliente"].Value = TTelefonoCliente.Text;
                        LRespuestaNuevoCliente.Text = "Editado Exitosamente!";

                    }
                    else
                    {
                        ValidarFormularioLabel();
                    }

                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }

        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();
            if (ValidacionFormulario())
            {
                DGClientes.Rows.Add(
                    TDNICliente.Text,
                    TNombreCliente.Text,
                    TApellidoCliente.Text,
                    TTelefonoCliente.Text,
                    TCorreoCliente.Text,
                    TDireccionCliente.Text

                    );
                LRespuestaNuevoCliente.Text = "Registrado Exitosamente!";
                TNombreCliente.Clear();
                TApellidoCliente.Clear();
                TDNICliente.Clear();
                TTelefonoCliente.Clear();
                TCorreoCliente.Clear();
                TDireccionCliente.Clear();
                LimpiarMensajesDeValidacion();


            }
            else
            {
                ValidarFormularioLabel();
            }
        }
        private void BBorrar_Click(object sender, EventArgs e)
        {
            TNombreCliente.Clear();
            TApellidoCliente.Clear();
            TDNICliente.Clear();
            TTelefonoCliente.Clear();
            TCorreoCliente.Clear();
            TDireccionCliente.Clear();
            TBuscarCliente.Clear();
            LimpiarMensajesDeValidacion();

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

        private bool ValidacionFormulario()
        {
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
        }


        private void ValidarFormularioLabel()
        {
            String nombreCliente = TNombreCliente.Text;
            String appellidosCliente = TApellidoCliente.Text;
            String dniCliente = TDNICliente.Text;
            String telefonoCliente = TTelefonoCliente.Text;
            String correoCliente = TCorreoCliente.Text;
            String direccionCliente = TDireccionCliente.Text;

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

            if (string.IsNullOrEmpty(dniCliente))
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese el DNI del cliente.";
            }
            else if (!int.TryParse(dniCliente, out int almacenamiento))
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese un numero.";
            }
            else if (dniCliente.Length > 9)
            {
                LValidDNI.ForeColor = Color.Red;
                LValidDNI.Text = "Ingrese un numero menor a 9 caracteres.";
            }
            else
            {
                LValidDNI.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(telefonoCliente))
            {
                LValiTelefono.ForeColor = Color.Red;

                LValiTelefono.Text = "Ingrese el Telefono del cliente ";
            }
            else if (!int.TryParse(telefonoCliente, out int almacenamiento))
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un numero.";
            }
            else if (telefonoCliente.Length > 12)
            {
                LValiTelefono.ForeColor = Color.Red;
                LValiTelefono.Text = "Ingrese un numero menor a 12caracteres.";
            }
            else
            {
                LValiTelefono.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(correoCliente))
            {

                LValiCorreo.ForeColor = Color.Red;
                LValiCorreo.Text = "Ingrese el correo electronico del Cliente";
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
                LValiDireccionCliente.Text = "Ingrese la direccion del Cliente";
            }
            else if (direccionCliente.Length > 200)
            {
                LValiDireccionCliente.Text = "Ingrese una direccion con menos caracteres";
            }
            else
            {
                LValiDireccionCliente.Text = string.Empty;
            }

        }

        private void LTituloAgregar_Click(object sender, EventArgs e)
        {

        }

        private void LNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            string dniBuscado = TBuscarCliente.Text.Trim();
            DGClientes.ClearSelection();

            if (!int.TryParse(dniBuscado, out int almacenamiento))
            {
                LValiBuscarCliente.Text = "Ingrese un numero";
            }
            else
            {
                foreach (DataGridViewRow fila in DGClientes.Rows)
                {
                    var dniCellValue = fila.Cells["CDNI"].Value;
                    // Comparar el DNI en la fila con el DNI buscado
                    if (dniCellValue != null && dniCellValue.ToString().Equals(dniBuscado, StringComparison.OrdinalIgnoreCase))
                    {

                        // Seleccionar la fila encontrada
                        fila.Selected = true;
                        fila.Cells["CDNI"].Selected = true; // Para resaltar la celda también
                        DGClientes.FirstDisplayedScrollingRowIndex = fila.Index; // Desplazar la vista
                        return; // Salir del método después de encontrar el DNI
                    }
                }

                // Si no se encontró el DNI, mostrar un mensaje
                MessageBox.Show("DNI no encontrado.");
            }
        }
    }

}
