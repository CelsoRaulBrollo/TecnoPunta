using System;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteInformeGeneral : Form
    {
        public ReporteInformeGeneral()
        {
            InitializeComponent();
        }

        private void LTituloReporteVentas_Click(object sender, System.EventArgs e)
        {

        }

        private void CBOXAnual_CheckedChanged(object sender, System.EventArgs e)
        {
            if (CBOXAnual.Checked)
            {
                CBOXMensual.Enabled = false;
                CBOXDiario.Enabled = false;
            }
            else
            {
                CBOXMensual.Enabled = true;
                CBOXDiario.Enabled = true;
            }
        }

        private void CBOXMensual_CheckedChanged(object sender, System.EventArgs e)
        {
            if (CBOXMensual.Checked)
            {
                CBOXAnual.Enabled = false;
                CBOXDiario.Enabled = false;
            }
            else
            {
                CBOXAnual.Enabled = true;
                CBOXDiario.Enabled = true;
            }
        }

        private void CBOXDiario_CheckedChanged(object sender, System.EventArgs e)
        {
            if (CBOXDiario.Checked)
            {
                CBOXAnual.Enabled = false;
                CBOXMensual.Enabled = false;
            }
            else
            {
                CBOXAnual.Enabled = true;
                CBOXMensual.Enabled = true;
            }
        }

        private void CBReporteStock_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void CBReporteProducto_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void CBReporteVentas_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void CBReporteCliente_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void BImprimir_Click(object sender, System.EventArgs e)
        {

        }

        private void BLimpiar_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea limpiar todos los filtros?", "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CBOXAnual.Checked = false;
                CBOXMensual.Checked = false;
                CBOXDiario.Checked = false;

                CBReporteStock.Checked = false;
                CBReporteProducto.Checked = false;
                CBReporteVentas.Checked = false;
                CBReporteCliente.Checked = false;

                CBOXAnual.Enabled = true;
                CBOXMensual.Enabled = true;
                CBOXDiario.Enabled = true;

                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

                MessageBox.Show("Los filtros han sido limpiados.", "Filtros Restablecidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
