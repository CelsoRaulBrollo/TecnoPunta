using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Views
{
    public partial class MenuPrincipal : Form
    {
        bool mouseDown;
        private Point offset;

        private FormularioInicio _formularioInicio;
        private string _rolUsuario;

        public MenuPrincipal(FormularioInicio formularioInicio, string rolUsuario)
        {
            InitializeComponent();
            _formularioInicio = formularioInicio;
            _rolUsuario = rolUsuario;

            BotonesMenu();
        }

        private void BotonesMenu()
        {
            foreach (ToolStripItem item in MMenuOpciones.Items)
            {
                item.Visible = false;
            }

            if (_rolUsuario == "Admin")
            {
               BAgregar.Visible = true;
               BEditar.Visible = true;
               BEliminar.Visible = true;
               BVentas.Visible = true;
               BConsultas.Visible = true;
               BUsuarios.Visible = true;
            }
            else if (_rolUsuario == "Vendedor")
            {

            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BAgregar_Click(object sender, EventArgs e)
        {

        }

        private void mouseDown_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X; 
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_event(object sender, MouseEventArgs e)
        {
            mouseDown = false; 
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas Salir de la aplicación?",
                "Salir de la aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de mensaje para confirmar la acción
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();  // Cerrar el formulario MenuPrincipal

                _formularioInicio.Show();
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
