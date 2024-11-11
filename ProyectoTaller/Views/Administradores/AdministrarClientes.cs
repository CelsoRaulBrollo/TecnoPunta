using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using System;
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
           
            if (DGClientes.Rows[e.RowIndex].Cells["Estado"].Value != null &&
                DGClientes.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "BAJA")
            {
               
                DGClientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#b11963");
            }
            else
            {
                
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
                DGClientes.CurrentCell = null;
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
                clienteNegocio = new ClienteNegocio();
                int dniCliente = Convert.ToInt32(DGClientes.SelectedRows[0].Cells["DNI_Cliente"].Value);

                clienteNegocio.bajaCliente(dniCliente);

                cargarClientes();



                MessageBox.Show("Cliente borrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BActivarCliente_Click(object sender, EventArgs e)
        {
            if (DGClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de Alta al cliente seleccionado?", "Confirmar Alta Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteNegocio = new ClienteNegocio();
                int dniCliente = Convert.ToInt32(DGClientes.SelectedRows[0].Cells["DNI_Cliente"].Value);

                clienteNegocio.altaCliente(dniCliente);

                cargarClientes();



                MessageBox.Show("Cliente borrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
