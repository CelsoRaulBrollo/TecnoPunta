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
    }
}
