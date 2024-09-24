using ProyectoTaller.Views.Administradores;
using ProyectoTaller.Views.Vendedor;
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

        public static Form FormularioActivo;

        public MenuPrincipal(FormularioInicio formularioInicio, string rolUsuario)
        {
            InitializeComponent();
            _formularioInicio = formularioInicio;
            _rolUsuario = rolUsuario;

            FormularioActivo = null;

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
               BProductos.Visible = true;
               BVentas.Visible = true;
               BConsultas.Visible = true;
            }
            else if (_rolUsuario == "Vendedor")
            {
                BCliente.Visible = true;
                BCarrito.Visible = true;
                BConsultarProd.Visible = true;
            }
            else if (_rolUsuario == "Gerente")
            {
                BGraficos.Visible = true;
                BUsuarios.Visible = true;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
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

        private void BMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                _formularioInicio.Show();
            }
        }

        private void MostrarFormularioEnPanel(Form formulario)
        {
            // Si hay un formulario activo, ciérralo
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;

            // Configura el formulario para que se muestre dentro del panel
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Limpia el contenido anterior del panel y añade el nuevo formulario
            PContenedor.Controls.Clear();
            PContenedor.Controls.Add(formulario);

            formulario.Show();
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            Form agregarProductoForm = new AgregarProducto();

            MostrarFormularioEnPanel(agregarProductoForm);
        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            PContenedor.Controls.Clear();

            PContenedor.Visible = true;
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            Form ventasForm = new VerVentas();

            MostrarFormularioEnPanel(ventasForm);
        }

        private void BConsultas_Click(object sender, EventArgs e)
        {
            Form consultasForm = new AdministrarConsultas();

            MostrarFormularioEnPanel(consultasForm);
        }

        private void BCliente_Click(object sender, EventArgs e)
        {
            Form agregarClienteForm = new AgregarCliente();

            MostrarFormularioEnPanel(agregarClienteForm);
        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            Form carritoForm = new Carrito();

            MostrarFormularioEnPanel(carritoForm);
        }

        private void BConsultarProd_Click(object sender, EventArgs e)
        {
            Form consultarProductoForm = new TConsultarProducto();
         

            MostrarFormularioEnPanel(consultarProductoForm);
        }
    }
}
