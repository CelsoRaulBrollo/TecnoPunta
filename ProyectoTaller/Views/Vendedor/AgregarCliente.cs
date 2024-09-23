using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();
            if (ValidacionFormulario())
            {
                //Implementacion SQL.CREATE 
            }
            else
            {
                ValidarFormularioLabel();
            }
        }
        private void BBorrar_Click(object sender, EventArgs e)
        {
            TNombreCliente.Clear();
            TApellidosCliente.Clear(); 
            TDNICliente.Clear();
            TTelefonoCliente.Clear();
            TCorreoCliente.Clear();
            LimpiarMensajesDeValidacion();

        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiAppelidoCliente.Text = string.Empty;
            LValiCorreo.Text = string.Empty;
            LValiNombre.Text = string.Empty;
            LValiTelefono.Text = string.Empty;
            LValidDNI.Text = string.Empty;
           
        }

        private bool ValidacionFormulario() {
            {
                String nombreCliente = TNombreCliente.Text;
                String appellidosCliente = TApellidosCliente.Text;
                String dniCliente = TDNICliente.Text;
                String telefonoCliente = TTelefonoCliente.Text;
                String correoCliente = TCorreoCliente.Text;

                bool respuesta = true;

                if (string.IsNullOrEmpty(nombreCliente))
                {
                    respuesta = false;
                }
                else if (nombreCliente.Length < 30)
                {
                    respuesta = false;
                }


                if (string.IsNullOrEmpty(appellidosCliente))
                {
                    respuesta = false;
                }
                else if (nombreCliente.Length < 30)
                {
                    respuesta = false;
                }


                if (string.IsNullOrEmpty(dniCliente))
                {
                    respuesta = false;
                }
                else if (!int.TryParse(dniCliente, out int almacenamiento))
                {
                    respuesta = false;
                }
                else if (dniCliente.Length < 9)
                {
                    respuesta = false;
                }


                if (string.IsNullOrEmpty(telefonoCliente))
                {
                    respuesta = false;
                }
                else if (!int.TryParse(telefonoCliente, out int almacenamiento))
                {
                    respuesta = false;
                }
                else if (telefonoCliente.Length < 12)
                {
                    respuesta = false;
                }


                if (string.IsNullOrEmpty(correoCliente))
                {

                    respuesta = false;
                }
                else if (correoCliente.Length < 100)
                {
                    respuesta = false;
                }

                return respuesta;
            }
        }


        private void ValidarFormularioLabel()
        {
            String nombreCliente = TNombreCliente.Text;
            String appellidosCliente = TApellidosCliente.Text;
            String dniCliente = TDNICliente.Text;
            String telefonoCliente = TTelefonoCliente.Text;
            String correoCliente = TCorreoCliente.Text;

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
                LValiAppelidoCliente.ForeColor = Color.Red;
                LValiAppelidoCliente.Text = "Ingrese el apellido del cliente.";
            }
            else if (appellidosCliente.Length > 30)
            {
                LValiAppelidoCliente.ForeColor = Color.Red;
                LValiAppelidoCliente.Text = "Ingrese menos de 30 caracteres.";
            }
            else
            {
                LValiAppelidoCliente.Text = string.Empty;
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

        }

        private void LTituloAgregar_Click(object sender, EventArgs e)
        {

        }

        private void LNombreProducto_Click(object sender, EventArgs e)
        {

        }

        
    }
}
