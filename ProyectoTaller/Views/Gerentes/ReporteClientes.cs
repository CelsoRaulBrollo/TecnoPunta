using ProyectoTaller.CNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteClientes : Form
    {
        private VentaNegocio ventaNegocio;
        public ReporteClientes()
        {
            InitializeComponent();
            cargarCBAÑOS();
            CargarComboBoxNuevoClientes();
            CargarGrafico(2024);
            
            

        }

        private void CBNuevoClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBAÑOS.SelectedItem != null)
            {
                int añoSeleccionado = Convert.ToInt32(CBAÑOS.SelectedItem.ToString());

                if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes")
                {
                    CargarGraficoClientesPorMes(añoSeleccionado);
                    LBReporteCliente.Text = "Nuevos Clientes";
                }
                else if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes por Género")
                {
                    CargarGrafico(añoSeleccionado);
                    LBReporteCliente.Text = "Nuevos Clientes por Género";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un año.");
            }
        }

        private void CargarGrafico(int año)
        {
            
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            LBReporteCliente.Text = "Nuevos Clientes por Género";
            List<Tuple<int, string, int>> informeClientes = clienteNegocio.ObtenerInformeClientesGenero(año);

            
            ChartReporteClientes.Series.Clear();

            
            ChartReporteClientes.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("ChartArea1");
            ChartReporteClientes.ChartAreas.Add(chartArea);

            
            var generos = new List<string> { "Masculino", "Femenino", "Otro" };

            foreach (var genero in generos)
            {
                Series series = new Series(genero)
                {
                    ChartType = SeriesChartType.StackedColumn, 
                    
                    LabelFormat = "#,##0" 
                };

                
                foreach (var item in informeClientes)
                {
                    if (item.Item2 == genero) 
                    {
                        int cantidad = item.Item3;

                        if (cantidad > 0)
                        {
                            
                            series.Points.AddXY(item.Item1, cantidad);
                            series.Points[series.Points.Count - 1].IsValueShownAsLabel = true;
                        }
                        else
                        {
                            
                            series.Points.AddXY(item.Item1, 0);
                            series.Points[series.Points.Count - 1].IsValueShownAsLabel = false;
                          
                        }
                    }
                }

                
                ChartReporteClientes.Series.Add(series);
            }

            
            ChartReporteClientes.ChartAreas[0].AxisX.Title = "Mes";
            ChartReporteClientes.ChartAreas[0].AxisX.Interval = 1;  

           
            ChartReporteClientes.ChartAreas[0].AxisY.Title = "Cantidad de Clientes";

            
            ChartReporteClientes.ChartAreas[0].RecalculateAxesScale();
        }

        private void CargarComboBoxNuevoClientes()
        {

            CBNuevoClientes.SelectedIndexChanged -= CBNuevoClientes_SelectedIndexChanged_1;

          
            CBNuevoClientes.Items.Clear();
            CBNuevoClientes.Items.Add("Nuevos Clientes");
            CBNuevoClientes.Items.Add("Nuevos Clientes por Género");


            CBNuevoClientes.SelectedIndex = 0;

            
            CBNuevoClientes.SelectedIndexChanged += CBNuevoClientes_SelectedIndexChanged_1;
        }

        private void cargarCBAÑOS()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            List<int> años = clienteNegocio.ObtenerAñosDeDatosClientes();

            if (años != null && años.Count > 0)
            {
               
                CBAÑOS.DataSource = años;

            
                CBAÑOS.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron años disponibles.");
            }
        }

        private void CargarGraficoClientesPorMes(int año)
        {
            
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            
            List<Tuple<int, int>> informeClientes = clienteNegocio.ObtenerInformeClientesTotalesPorMes(año);

            LBReporteCliente.Text = "Nuevos Clientes";
            ChartReporteClientes.Series.Clear();

           
            ChartReporteClientes.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("ChartArea1");
            ChartReporteClientes.ChartAreas.Add(chartArea);

            
            Series series = new Series("Nuevos Clientes")
            {
                ChartType = SeriesChartType.Column, 
                IsValueShownAsLabel = true, 
                LabelFormat = "#,##0" 
            };

           
            foreach (var item in informeClientes)
            {
                
                series.Points.AddXY(item.Item1, item.Item2);
            }

           
            ChartReporteClientes.Series.Add(series);

            
            ChartReporteClientes.ChartAreas[0].AxisX.Title = "Mes";
            ChartReporteClientes.ChartAreas[0].AxisX.Interval = 1;  

            
            ChartReporteClientes.ChartAreas[0].AxisY.Title = "Cantidad de Clientes";

         
            ChartReporteClientes.ChartAreas[0].RecalculateAxesScale();
        }

    }
}
