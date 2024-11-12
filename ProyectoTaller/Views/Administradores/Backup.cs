using ProyectoTaller.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Administradores
{
    public partial class Backup : Form
    {
        private BaseDatosNegocio baseDeDatos;
        public Backup()
        {
            InitializeComponent();
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas hacer una restauración?",
                "Confirmar Restauración",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                RealizarRestauracion();
            }
        }

        private void RealizarRestauracion()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak";  
            openFileDialog.Title = "Seleccionar archivo de Restauración";

           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaBackup = openFileDialog.FileName;  

                try
                {
                    
                    baseDeDatos = new BaseDatosNegocio();
                    baseDeDatos.generarRestore(rutaBackup); 

                    
                    MessageBox.Show("La restauración se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Error al restaurar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BBackup_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas hacer un Backup de los datos?",
                "Confirmar Backup",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                RealizarBackup();
            }
        }

        private void RealizarBackup()
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak";  
            saveFileDialog.Title = "Seleccionar ubicación para el Backup";

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string url = saveFileDialog.FileName;  

                try
                {
                   
                    baseDeDatos = new BaseDatosNegocio();
                    baseDeDatos.generarBackUP(url);

                   
                    MessageBox.Show("El Backup se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show($"Error al realizar el backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
