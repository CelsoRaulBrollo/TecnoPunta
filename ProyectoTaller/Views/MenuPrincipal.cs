﻿using ProyectoTaller.Views.Administradores;
using ProyectoTaller.Views.Gerentes;
using ProyectoTaller.Views.Vendedor;
using System;
using System.Drawing;
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
                BCliente.Visible = true;
                BUsuarios.Visible = true;
                BInformes.Visible = true;
                BBackup.Visible = true;
            }
            else if (_rolUsuario == "Vendedor")
            {
                BProductos.Visible = true;
                BCliente.Visible = true;
                BCarrito.Visible = true;
                BVentas.Visible = true;
            }
            else if (_rolUsuario == "Gerente")
            {
                BProductos.Visible = true;
                BVentas.Visible = true;
                BCliente.Visible = true;
                BStock.Visible = true;
                BInformes.Visible = true;
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
            if (_rolUsuario == "Admin")
            {
                Form agregarProductoForm = new AgregarProducto();

                MostrarFormularioEnPanel(agregarProductoForm);
            }
            else if (_rolUsuario == "Vendedor")
            {
                Form consultarProductoForm = new TConsultarProducto();

                MostrarFormularioEnPanel(consultarProductoForm);
            }
            else if (_rolUsuario == "Gerente")
            {
                Form reporteProductos = new ReporteProductos();

                MostrarFormularioEnPanel(reporteProductos);
            }
        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            PContenedor.Controls.Clear();

            PContenedor.Visible = true;
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            if (_rolUsuario == "Admin")
            {
                Form ventasAdmin = new VerVentas();

                MostrarFormularioEnPanel(ventasAdmin);
            }
            else if (_rolUsuario == "Vendedor")
            {
                Form ventasVendedor = new GestionVentas();

                MostrarFormularioEnPanel(ventasVendedor);
            }
            else if (_rolUsuario == "Gerente")
            {
                Form reporteVentas = new ReporteVentas();

                MostrarFormularioEnPanel(reporteVentas);
            }
        }

        private void BCliente_Click(object sender, EventArgs e)
        {
            if (_rolUsuario == "Admin")
            {
                Form AdminClientes = new AdministrarClientes();

                MostrarFormularioEnPanel(AdminClientes);
            }
            else if (_rolUsuario == "Vendedor")
            {
                Form agregarClienteForm = new AgregarCliente();

                MostrarFormularioEnPanel(agregarClienteForm);
            }
            else if (_rolUsuario == "Gerente")
            {
                Form reporteClientes = new ReporteClientes();

                MostrarFormularioEnPanel(reporteClientes);
            }
        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            Form carritoForm = new Carrito();

            MostrarFormularioEnPanel(carritoForm);
        }

        private void BGraficos_Click(object sender, EventArgs e)
        {
            Form Estadisticas = new EstadisticasGraficas();

            MostrarFormularioEnPanel(Estadisticas);
        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            Form UsuariosGestion = new GestionUsuarios();

            MostrarFormularioEnPanel(UsuariosGestion);
        }

        private void BInformes_Click(object sender, EventArgs e)
        {
            if (_rolUsuario == "Admin")
            {
                Form informeAdmin = new InformesAdministrador();

                MostrarFormularioEnPanel(informeAdmin);
            }
            else if (_rolUsuario == "Gerente")
            {
                Form informeGerente = new ReporteInformeGeneral();

                MostrarFormularioEnPanel(informeGerente);
            }
        }

        private void BBackup_Click(object sender, EventArgs e)
        {
            Form restaurarBaseDatos = new Backup();

            MostrarFormularioEnPanel(restaurarBaseDatos);
        }
    }
}
