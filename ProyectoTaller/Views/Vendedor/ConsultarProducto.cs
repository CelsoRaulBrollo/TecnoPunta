using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class TConsultarProducto : Form
    {
        private int _dniUsuario;
        private ProductoNegocio productoNegocio;
        private CarritoNegocio carritoNegocio;
        public TConsultarProducto(int dniUsuario)
        {
            _dniUsuario = dniUsuario;
            InitializeComponent();
            cargarProductos();
            cargarEventos();
        }



        public void cargarProductos()
        {
            productoNegocio = new ProductoNegocio();
            List<ProductoDTO> productos = productoNegocio.listarProductosConStock();

            DGProductos.DataSource = productos;
            DGProductos.Columns["Condicion"].Visible = false;
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();
            
            if (ValidacionesConsultaProducto())
            {

             
                List<ProductoDTO> productos = productoNegocio.listarProductosConStock();
                List<ProductoDTO> filtrados = new List<ProductoDTO>();

                // Filtrar los productos según los criterios
                foreach (var producto in productos)
                {
                    bool coinciden = true;

                    if (!string.IsNullOrEmpty(TNombreProducto.Text) &&
                        !producto.Nombre.ToLower().Contains(TNombreProducto.Text.ToLower()))
                    {
                        coinciden = false;
                    }
                    if (!string.IsNullOrEmpty(TModelo.Text) &&
                        !producto.Modelo.ToLower().Contains(TModelo.Text.ToLower()))
                    {
                        coinciden = false;
                    }
                    if (!string.IsNullOrEmpty(TMemoriaRam.Text) &&
                        !producto.Ram.ToLower().Contains(TMemoriaRam.Text.ToLower()))
                    {
                        coinciden = false;
                    }
                    if (!string.IsNullOrEmpty(TAlmacenamiento.Text) &&
                        !producto.Almacenamiento.ToLower().Contains(TAlmacenamiento.Text.ToLower()))
                    {
                        coinciden = false;
                    }
                    if (!string.IsNullOrEmpty(TSistemaOperativo.Text) &&
                        !producto.SistemaOperativo.ToLower().Contains(TSistemaOperativo.Text.ToLower()))
                    {
                        coinciden = false;
                    }

                    // Si coinciden todas las condiciones, se añade a la lista filtrada
                    if (coinciden)
                    {
                        filtrados.Add(producto);
                    }
                }

                // Asignar la lista filtrada al DataGrid
                DGProductos.DataSource = filtrados;

                // Mostrar mensaje si no se encuentran resultados
                if (!filtrados.Any())
                {
                    MessageBox.Show("No se encontraron productos que coincidan con los criterios.");
                }


            }

            else
            {
                ValidacionesConsultaProductoLabel();
            }

        }

        private void BLimpiarFiltros_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea limpiar todos los filtros?",
                "Confirmar Limpiar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                TNombreProducto.Clear();
                TMemoriaRam.Clear();
                TModelo.Clear();
                CBMarca.SelectedIndex = -1;
                TAlmacenamiento.Clear();
                TSistemaOperativo.Clear();

               
                CBPrecioAsc.Checked = false;
                CBPrecioDesc.Checked = false;
                cargarProductos(); 

                MessageBox.Show("Filtros limpios.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarMensajesDeValidacion()
        {
            LValiMarca.Text = string.Empty;
            LValiNombreP.Text = string.Empty;
            LValiModeloP.Text = string.Empty;
            LValiSistOpe.Text = string.Empty;
            LValiAllmac.Text = string.Empty;
            LValiRamp.Text = string.Empty;

        }

        private bool ValidacionesConsultaProducto()
        {
            string marca = CBMarca.SelectedItem?.ToString();
            string nombreProducto = TNombreProducto.Text;
            string modelo = TModelo.Text;
            string sistemaOperativo = TSistemaOperativo.Text;
            string almacenamientoTexto = TAlmacenamiento.Text;
            string ramTexto = TMemoriaRam.Text;

            bool valido = true;

            // Validar Nombre Producto
            if (TNombreProducto.Enabled)
            {
                if (nombreProducto.Length < 5)
                {
                    LValiNombreP.ForeColor = Color.Red;
                    LValiNombreP.Text = "Al menos 5 caracteres.";
                    valido = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[a-zA-Z0-9]"))
                {
                    LValiNombreP.ForeColor = Color.Red;
                    LValiNombreP.Text = "El Nombre debe contener solo letras y números.";
                    valido = false;
                }
            }

            // Validar Modelo
            if (TModelo.Enabled)
            {
                if (modelo.Length < 3 || modelo.Length > 12)
                {
                    LValiModeloP.ForeColor = Color.Red;
                    LValiModeloP.Text = "Modelo de 3 a 12 caracteres.";
                    valido = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(modelo, @"^[a-zA-Z0-9]"))
                {
                    LValiModeloP.ForeColor = Color.Red;
                    LValiModeloP.Text = "El modelo debe contener solo letras y números.";
                    valido = false;
                }
            }

            // Validar Sistema Operativo
            if (TSistemaOperativo.Enabled)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(sistemaOperativo, @"^[a-zA-Z0-9]"))
                {
                    LValiSistOpe.ForeColor = Color.Red;
                    LValiSistOpe.Text = "El S.O debe contener solo letras y números.";
                    valido = false;
                }
                else if (sistemaOperativo.Length < 2 || sistemaOperativo.Length > 20)
                {
                    LValiSistOpe.ForeColor = Color.Red;
                    LValiSistOpe.Text = "S.O de 2 a 20 caracteres.";
                    valido = false;
                }
            }

            // Validar Almacenamiento
            if (TAlmacenamiento.Enabled)
            {
                if (!int.TryParse(almacenamientoTexto, out int almacenamiento))
                {
                    LValiAllmac.ForeColor = Color.Red;
                    LValiAllmac.Text = "El almacenamiento debe ser un número entero.";
                    valido = false;
                }
                else if (almacenamiento <= 32 || almacenamiento > 1024)
                {
                    LValiAllmac.ForeColor = Color.Red;
                    LValiAllmac.Text = "El almacenamiento debe estar entre 32 y 1024 GB.";
                    valido = false;
                }
            }

            // Validar RAM
            if (TMemoriaRam.Enabled)
            {
                if (!int.TryParse(ramTexto, out int ram))
                {
                    LValiRamp.ForeColor = Color.Red;
                    LValiRamp.Text = "La Ram debe ser un número entero.";
                    valido = false;
                }
                else if (ram <= 1 || ram > 32)
                {
                    LValiRamp.ForeColor = Color.Red;
                    LValiRamp.Text = "La Ram debe estar entre 1 y 32 GB.";
                    valido = false;
                }
            }

            return valido;
        }

        private void ValidacionesConsultaProductoLabel()
        {
            string marca = CBMarca.SelectedItem?.ToString();
            string nombreProducto = TNombreProducto.Text;
            string modelo = TModelo.Text;
            string sistemaOperativo = TSistemaOperativo.Text;
            string almacenamientoTexto = TAlmacenamiento.Text;
            string ramTexto = TMemoriaRam.Text;

            // Validar Nombre Producto
            if (TNombreProducto.Enabled) // Solo si el TextBox está habilitado
            {
                if (string.IsNullOrWhiteSpace(nombreProducto))
                {
                    LValiNombreP.Text = string.Empty;
                }
                else if (nombreProducto.Length < 5)
                {
                    LValiNombreP.ForeColor = Color.Red;
                    LValiNombreP.Text = "Al menos 5 caracteres.";
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[a-zA-Z0-9]"))
                {
                    LValiNombreP.ForeColor = Color.Red;
                    LValiNombreP.Text = "El Nombre debe contener solo letras y números.";
                }
            }

            // Validar Modelo
            if (TModelo.Enabled)
            {
                if (string.IsNullOrWhiteSpace(modelo))
                {
                    LValiModeloP.Text = string.Empty;
                }
                else if (modelo.Length < 3 || modelo.Length > 12)
                {
                    LValiModeloP.ForeColor = Color.Red;
                    LValiModeloP.Text = "Modelo de 3 a 12 caracteres.";
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(modelo, @"^[a-zA-Z0-9]"))
                {
                    LValiModeloP.ForeColor = Color.Red;
                    LValiModeloP.Text = "El modelo debe contener solo letras y números.";
                }
            }

            // Validar Sistema Operativo
            if (TSistemaOperativo.Enabled)
            {
                if (string.IsNullOrWhiteSpace(sistemaOperativo))
                {
                    LValiSistOpe.Text = string.Empty;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(sistemaOperativo, @"^[a-zA-Z0-9]"))
                {
                    LValiSistOpe.ForeColor = Color.Red;
                    LValiSistOpe.Text = "El S.O debe contener solo letras y números.";
                }
                else if (sistemaOperativo.Length < 2 || sistemaOperativo.Length > 20)
                {
                    LValiSistOpe.ForeColor = Color.Red;
                    LValiSistOpe.Text = "S.O de 2 a 20 caracteres.";
                }
            }

            // Validar Almacenamiento
            if (TAlmacenamiento.Enabled)
            {
                if (string.IsNullOrWhiteSpace(almacenamientoTexto))
                {
                    LValiAllmac.Text = string.Empty;
                }
                else if (!int.TryParse(almacenamientoTexto, out int almacenamiento))
                {
                    LValiAllmac.ForeColor = Color.Red;
                    LValiAllmac.Text = "El almacenamiento debe ser un número entero.";
                }
                else if (almacenamiento <= 32 || almacenamiento > 1024)
                {
                    LValiAllmac.ForeColor = Color.Red;
                    LValiAllmac.Text = "El almacenamiento debe estar entre 32 y 1024 GB.";
                }
            }

            // Validar RAM
            if (TMemoriaRam.Enabled)
            {
                if (string.IsNullOrWhiteSpace(ramTexto))
                {
                    LValiRamp.Text = string.Empty;
                }
                else if (!int.TryParse(ramTexto, out int ram))
                {
                    LValiRamp.ForeColor = Color.Red;
                    LValiRamp.Text = "La Ram debe ser un número entero.";
                }
                else if (ram <= 1 || ram > 32)
                {
                    LValiRamp.ForeColor = Color.Red;
                    LValiRamp.Text = "La Ram debe estar entre 1 y 32 GB.";
                }
            }
        }

        private void CBEnStock_CheckedChanged(object sender, EventArgs e)
        {
            // Implementacion consulta SQL. Obtener productos en stock.
        }

        private void CBPrecioAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPrecioAsc.Checked)
            {
                CBPrecioDesc.Checked = false; 

                OrdenarAscendente();
            }
            else
            {
                CBPrecioDesc.Enabled = true;
                cargarProductos();
            }
        }

        private void CBPrecioDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPrecioDesc.Checked)
            {
                CBPrecioAsc.Checked = false; 

                OrdenarDescendente();
            }
            else
            {
                CBPrecioAsc.Enabled = true;
                cargarProductos();
            }
        }

        private void OrdenarAscendente()
        {
            productoNegocio = new ProductoNegocio();
            List<ProductoDTO> productos = productoNegocio.listarProductosConStock();
            var listaOrdenada = productos.OrderBy(p => p.Precio).ToList();
            DGProductos.DataSource = listaOrdenada;
        }

        private void OrdenarDescendente()
        {
            productoNegocio = new ProductoNegocio();
            List<ProductoDTO> productos = productoNegocio.listarProductosConStock();
            var listaOrdenada = productos.OrderByDescending(p => p.Precio).ToList();
            DGProductos.DataSource = listaOrdenada;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            // Verificar si hay texto en algún TextBox
            bool isAnyTextBoxFilled = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox != currentTextBox)
                {
                    if (textBox.Text.Length > 0)
                    {
                        isAnyTextBoxFilled = true; // Hay texto en algún TextBox
                    }
                }
            }

            // Si hay texto en algún TextBox, deshabilitar los demás y el ComboBox
            if (isAnyTextBoxFilled || currentTextBox.Text.Length > 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox && textBox != currentTextBox)
                    {
                        textBox.Enabled = false; // Deshabilitar otros TextBox
                    }
                    else if (control is ComboBox)
                    {
                        control.Enabled = false; // Deshabilitar el ComboBox
                    }
                }
            }
            else
            {
                // Habilitar todos los TextBox y el ComboBox si todos están vacíos
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = true; // Habilitar TextBox
                    }
                    else if (control is ComboBox)
                    {
                        control.Enabled = true; // Habilitar ComboBox
                    }
                }
            }
        }

        private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Deshabilitar los TextBox si hay una marca seleccionada
            bool isMarcaSelected = CBMarca.SelectedIndex >= 0;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = !isMarcaSelected; // Habilitar o deshabilitar según la selección
                }
            }
        }

        public void cargarEventos()
        {
            TNombreProducto.TextChanged += TextBox_TextChanged;
            TModelo.TextChanged += TextBox_TextChanged;
            TMemoriaRam.TextChanged += TextBox_TextChanged;
            TAlmacenamiento.TextChanged += TextBox_TextChanged;
            TSistemaOperativo.TextChanged += TextBox_TextChanged;
            CBMarca.SelectedIndexChanged += CBMarca_SelectedIndexChanged;
        }

        private void BAgregarProductoACarrito_Click(object sender, EventArgs e)
        {
            if (DGProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            DataGridViewRow selectedRow = DGProductos.SelectedRows[0];

            DialogResult resultado = MessageBox.Show(
                "¿Desea agregar el producto al carrito?",
                "Confirmar Agregar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                carritoNegocio = new CarritoNegocio();

                bool agregado = carritoNegocio.agregarProducto(selectedRow.Cells["Modelo"].Value.ToString(), _dniUsuario);

                if (agregado)
                {
                    MessageBox.Show("Producto agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             
            }
        }

        private void DGProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
