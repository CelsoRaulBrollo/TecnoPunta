using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using ProyectoTaller.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class FormularioInicio : Form
    {
        private UsuarioNegocio UsuarioNegocio;
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
            string nombre = TUsuario.Text;
            string contraseña = TContraseña.Text;
            UsuarioNegocio = new UsuarioNegocio();


            
            LValidaciones.Text = "";

            ValidarLogin(nombre, contraseña);
            Usuario usuario = UsuarioNegocio.autenticacion(nombre, contraseña);

            if (string.IsNullOrWhiteSpace(LValidaciones.Text))
            {
                if (usuario != null && usuario.Estado == "ACTIVO") {

                    MenuPrincipal menu = new MenuPrincipal(this, usuario);
                    menu.Show();

                    this.Hide();


                }
                else
                {
                    if(usuario.Estado != "BAJA")
                    {
                        LValidaciones.Text = "El Usuario ha sido dado de baja.";
                        LValidaciones.ForeColor = Color.Red;
                    }
                    else
                    {
                        LValidaciones.Text = "Usuario o contraseña incorrectos.";
                        LValidaciones.ForeColor = Color.Red;
                    }
                    
                }








                
                
            }
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
