using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class AdministrarClientes : Form
    {
        public AdministrarClientes()
        {
            InitializeComponent();
        }

        private void AdministrarClientes_Load(object sender, System.EventArgs e)
        {
            DGClientes.Rows.Add("42733217", "Raul", "Brollo", "3624777447", "celsobrollo@gmail.com", "Leon Zorrilla 5260");
            DGClientes.Rows.Add("35525452", "Leon", "Martinez", "887845827", "Correo@gmail.com", "Direccion 474");
            DGClientes.Rows.Add("45872125", "Rawl", "Brol", "3624984588", "Correo@outlook.com", "Direccion 878");
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
