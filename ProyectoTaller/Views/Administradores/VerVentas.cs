using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using ProyectoTaller.Questpdf;
using ProyectoTaller.Views.Vendedor;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class VerVentas : Form
    {
        private VentaNegocio ventaNegocio;
        public VerVentas()
        {
            InitializeComponent();
        }

        private void VerVentas_Load(object sender, System.EventArgs e)
        {
            ventaNegocio = new VentaNegocio();
            DGVentas.DataSource = ventaNegocio.obtenerTodasLasVentas();
            DGVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TBuscarVentas_TextChanged(object sender, System.EventArgs e)
        {
            string searchText = TBuscarVentas.Text.ToLower();

            foreach (DataGridViewRow row in DGVentas.Rows)
            {
                bool isVisible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
                DGVentas.CurrentCell = null;
                row.Visible = isVisible;
            }
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BVerDetalle_Click(object sender, System.EventArgs e)
        {
            if (DGVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para ver el detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow filaSeleccionada = DGVentas.SelectedRows[0];
            var valor = filaSeleccionada.Cells["CodigoVenta"].Value;
            int idVenta = Convert.ToInt32(valor);
            VentaDetalles detalleForm = new VentaDetalles(idVenta);

            detalleForm.ShowDialog();
        }

        private void BVerFactura_Click(object sender, System.EventArgs e)
        {
            if (DGVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para ver la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ventaNegocio = new VentaNegocio();
            DataGridViewRow filaSeleccionada = DGVentas.SelectedRows[0];
            var valor = filaSeleccionada.Cells["CodigoVenta"].Value;
            int idVenta = Convert.ToInt32(valor);
            var venta = ventaNegocio.buscarVentaPorId(idVenta);
            var document = new InvoiceDocument(venta);
            document.crearDocumento();
        }

        private void CBEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBEfectivo.Checked)
            {
                CBTarjeta.Checked = false;
                CBTransferencia.Checked = false;
            }
            FiltrarPorMedioPago();
        }

        private void CBTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTarjeta.Checked)
            {
                CBEfectivo.Checked = false;
                CBTransferencia.Checked = false;
            }
            FiltrarPorMedioPago();
        }

        private void CBTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTransferencia.Checked)
            {
                CBEfectivo.Checked = false;
                CBTarjeta.Checked = false;
            }
            FiltrarPorMedioPago();
        }

        private void FiltrarPorMedioPago()
        {
            foreach (DataGridViewRow fila in DGVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    bool mostrarFila = true;

                    if (CBEfectivo.Checked && fila.Cells["MetodoDePago"].Value.ToString() != "Efectivo")
                    {
                        mostrarFila = false;
                    }
                    

                    if ((CBTarjeta.Checked && fila.Cells["MetodoDePago"].Value.ToString() != "Tarjeta De Debito" )
                        && (CBTarjeta.Checked && fila.Cells["MetodoDePago"].Value.ToString() != "Tarjeta De Credito"))
                    {
                        mostrarFila = false;
                    }

                    if (CBTransferencia.Checked && fila.Cells["MetodoDePago"].Value.ToString() != "Billetera Virtual")
                    {
                        mostrarFila = false;
                    }
                    DGVentas.CurrentCell = null;
                    fila.Visible = mostrarFila;
                }
            }
        }

        private void DTPDesde_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFecha();
        }

        private void DTPHasta_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFecha();
        }

        private void FiltrarPorFecha()
        {
            DateTime fechaDesde = DTPDesde.Value.Date;
            DateTime fechaHasta = DTPHasta.Value.Date.AddDays(1).AddTicks(-1);

            foreach (DataGridViewRow fila in DGVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    DateTime fecha = Convert.ToDateTime(fila.Cells["FechaDeFacturacion"].Value);

                    if (fecha >= fechaDesde && fecha <= fechaHasta)
                    {

                        fila.Visible = true;
                    }
                    else
                    {
         
                        DGVentas.CurrentCell = null;
                        fila.Visible = false;
                    }
                }
            }
        }

        private void BReiniciar_Click(object sender, EventArgs e)
        {
            // Reiniciar ambos Date a la fecha actual
            DTPDesde.Value = DateTime.Now;
            DTPHasta.Value = DateTime.Now;

            FiltrarPorFecha();
        }
    }
}
