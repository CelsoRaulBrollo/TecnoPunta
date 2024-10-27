using ProyectoTaller.CNegocio;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class AdministrarClientes : Form
    {
        private ClienteNegocio clienteNegocio;
        public AdministrarClientes()
        {
            InitializeComponent();
            cargarClientes();
            DGClientes.RowPrePaint += DGClientes_RowPrePaint;
        }

        public void cargarClientes()
        {
            clienteNegocio = new ClienteNegocio();
            DGClientes.DataSource = clienteNegocio.ObtenerClientes();
            DGClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           


        }

        private void DGClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Verifica si la celda de la columna "Estado" contiene "BAJA"
            if (DGClientes.Rows[e.RowIndex].Cells["Estado"].Value != null &&
                DGClientes.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "BAJA")
            {
                // Cambia el color de fondo de toda la fila a rojo
                DGClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#b11963");
            }
            else
            {
                // Restablecer a su color original si no es "BAJA"
                DGClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
            }
        }


        private void DGClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBuscarCliente_TextChanged(object sender, System.EventArgs e)
        {
            string searchText = TBuscarCliente.Text.ToLower();

            foreach (DataGridViewRow row in DGClientes.Rows)
            {
                bool isVisible = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));

                row.Visible = isVisible;
            }
        }

        private void BBorrarCliente_Click(object sender, System.EventArgs e)
        {
            if (DGClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar al cliente seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DGClientes.Rows.RemoveAt(DGClientes.SelectedRows[0].Index);
                MessageBox.Show("Cliente borrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
