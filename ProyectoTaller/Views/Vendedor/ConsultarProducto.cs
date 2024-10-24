﻿using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class TConsultarProducto : Form
    {
        private ProductoNegocio productoNegocio;
        private CarritoNegocio carritoNegocio;
        public TConsultarProducto()
        {
            InitializeComponent();
            cargarProductos();
        }



        public void cargarProductos()
        {
            productoNegocio = new ProductoNegocio();
            List<ProductoDTO> productos = productoNegocio.listarProductos();
            DGProductos.DataSource = productos;
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            LimpiarMensajesDeValidacion();
            if (ValidacionesConsultaProducto())
            {
                //IMPLEMENTACION CONSULTA SQL
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

                CBEnStock.Checked = false;
                CBPrecioAsc.Checked = false;
                CBPrecioDesc.Checked = false;

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

            if (nombreProducto.Length < 5)
            {

                valido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[a-zA-Z0-9]"))
            {

                valido = false;
            }

            if (modelo.Length < 3 || modelo.Length > 12)
            {


                valido = false;

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(modelo, @"^[a-zA-Z0-9]"))
            {

                valido = false;

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(sistemaOperativo, @"^[a-zA-Z0-9]"))
            {


                valido = false;


            }
            else if (sistemaOperativo.Length < 2 || sistemaOperativo.Length > 20)
            {

                valido = false;


            }
            if (!int.TryParse(almacenamientoTexto, out int almacenamiento))
            {


                valido = false;
            }
            else if (almacenamiento <= 32 || almacenamiento > 1024)
            {

                valido = false;
            }
            if (!int.TryParse(ramTexto, out int ram))
            {

                valido = false;
            }
            else if (ram <= 1 || ram > 32)
            {

                valido = false;
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

        private void CBEnStock_CheckedChanged(object sender, EventArgs e)
        {
            // Implementacion consulta SQL. Obtener productos en stock.
        }

        private void CBPrecioAsc_CheckedChanged(object sender, EventArgs e)
        {
            // Implementacion. Ordenar menor a mayor segun precio.
        }

        private void CBPrecioDesc_CheckedChanged(object sender, EventArgs e)
        {
            // Implementacion. Ordenar mayor a menor segun precio.
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

                bool agregado = carritoNegocio.agregarProducto(selectedRow.Cells["Modelo"].Value.ToString(), 41008591);

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
    }
}
