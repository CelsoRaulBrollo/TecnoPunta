using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class VerVentas : Form
    {
        public VerVentas()
        {
            InitializeComponent();
        }

        private void VerVentas_Load(object sender, System.EventArgs e)
        {
            DGVentas.Columns["CFecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DGVentas.Rows.Add("1", "Raul Brollo", "06/09/2024", "Tarjeta", "iPhone 13 Pro Max", "Leon Zorrilla 5260");
            DGVentas.Rows.Add("2", "Leon Martinez", "10/12/2022", "Efectivo", "Samsung S24 Ultra", "Direccion 474");
            DGVentas.Rows.Add("3", "Rawl Brol", "02/08/2024", "Tarjeta", "iPhone 16 Pro Max", "Direcc 878");
            DGVentas.Rows.Add("3", "Maria Cande", "07/08/2024", "Transferencia", "iPhone 13 Pro Max", "Diagonal Eva 2377");
        }

        private void TBuscarVentas_TextChanged(object sender, System.EventArgs e)
        {
            string searchText = TBuscarVentas.Text.ToLower();

            foreach (DataGridViewRow row in DGVentas.Rows)
            {
                bool isVisible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));

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
        }

        private void BVerFactura_Click(object sender, System.EventArgs e)
        {
            if (DGVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para ver la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CBEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorMedioPago();
        }

        private void CBTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorMedioPago();
        }

        private void CBTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorMedioPago();
        }

        private void FiltrarPorMedioPago()
        {
            foreach (DataGridViewRow fila in DGVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    bool mostrarFila = true;

                    if (CBEfectivo.Checked && fila.Cells["CMedioPago"].Value.ToString() != "Efectivo")
                    {
                        mostrarFila = false;
                    }

                    if (CBTarjeta.Checked && fila.Cells["CMedioPago"].Value.ToString() != "Tarjeta")
                    {
                        mostrarFila = false;
                    }

                    if (CBTransferencia.Checked && fila.Cells["CMedioPago"].Value.ToString() != "Transferencia")
                    {
                        mostrarFila = false;
                    }

                    fila.Visible = mostrarFila;
                }
            }
        }

        private void FiltrarPorMetodoPago()
        {
            foreach (DataGridViewRow fila in DGVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if (CBEfectivo.Checked && fila.Cells["CMedioPago"].Value.ToString() == "Efectivo")
                    {
                        fila.Visible = true;
                    }
                    else if (CBTarjeta.Checked && fila.Cells["CMedioPago"].Value.ToString() == "Tarjeta")
                    {
                        fila.Visible = true;
                    }
                    else if (CBTransferencia.Checked && fila.Cells["CMedioPago"].Value.ToString() == "Transferencia")
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
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
            DateTime fechaHasta = DTPHasta.Value.Date;

            foreach (DataGridViewRow fila in DGVentas.Rows)
            {
                if (!fila.IsNewRow)
                {
                    DateTime fecha = Convert.ToDateTime(fila.Cells["CFecha"].Value);

                    if (fecha >= fechaDesde && fecha <= fechaHasta)
                    {
                        fila.Visible = true;
                    }
                    else
                    {
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
