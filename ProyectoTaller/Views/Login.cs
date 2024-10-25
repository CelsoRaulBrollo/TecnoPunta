using ProyectoTaller.CNegocio;
using ProyectoTaller.Views;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BInicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TUsuario.Text;
            string contraseña = TContraseña.Text;

            LValidaciones.Text = "";

            ValidarLogin(nombreUsuario, contraseña);

            if (string.IsNullOrWhiteSpace(LValidaciones.Text))
            {
                string rolUsuario = ObtenerRolUsuario(nombreUsuario, contraseña);
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                int dniVendedor = usuarioNegocio.ObtenerDNIDelUsuario(nombreUsuario, contraseña);

                if (!string.IsNullOrEmpty(rolUsuario) && dniVendedor != -1)
                {
                    MenuPrincipal menu = new MenuPrincipal(this, rolUsuario, dniVendedor);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    LValidaciones.Text = "Usuario o contraseña incorrectos.";
                    LValidaciones.ForeColor = Color.Red;
                }
            }
        }

        public string ObtenerRolUsuario(string nombreUsuario, string contraseña)
        {
            int rolId = -1;
            string rolNombre = string.Empty;
            string query = "SELECT Rol_Usuario FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

            string connectionString = "Server=CELSOBRO\\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            rolId = Convert.ToInt32(result);
                        }
                    }

                    switch (rolId)
                    {
                        case 1:
                            rolNombre = "Admin";
                            break;
                        case 2:
                            rolNombre = "Gerente";
                            break;
                        case 3:
                            rolNombre = "Vendedor";
                            break;
                        default:
                            rolNombre = string.Empty;
                            break;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de conexión: {ex.Message}");
                }
            }

            return rolNombre;
        }


        public void ValidarLogin(string nombre, string contraseña)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(contraseña))
            {
                LValidaciones.Text = "Por favor, ingrese su nombre y contraseña.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                LValidaciones.Text = "Por favor, ingrese su nombre.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                LValidaciones.Text = "Por favor, ingrese su contraseña.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            // Validar longitud mínima
            if (nombre.Length < 5)
            {
                LValidaciones.Text = "Nombre de usuario de al menos 5 caract.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            if (contraseña.Length < 5)
            {
                LValidaciones.Text = "Contraseña de al menos 5 caracteres.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            // Validar que no haya espacios en blanco
            if (nombre.Contains(" "))
            {
                LValidaciones.Text = "El Usuario debe ser sin espacios.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            if (contraseña.Contains(" "))
            {
                LValidaciones.Text = "La contraseña debe ser sin espacios.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }

            // Validar que la contraseña tenga al menos un número
            if (!TieneNumero(contraseña))
            {
                LValidaciones.Text = "La contraseña debe tener al menos un número.";
                LValidaciones.ForeColor = Color.Red;
                return;
            }
        }

        public bool TieneNumero(string input)
        {
            return input.Any(char.IsDigit);
        }

        public bool TieneMayuscula(string input)
        {
            return input.Any(char.IsUpper);
        }

        public void TUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void TContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
