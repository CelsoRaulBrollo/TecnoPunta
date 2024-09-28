using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTaller.Views.Gerentes
{
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
            CargarDatosNuevosClientes();

            CBNuevoClientes.Items.Clear();

            // Agregar opciones al ComboBox
            CBNuevoClientes.Items.Add("Nuevos Clientes");
            CBNuevoClientes.Items.Add("Nuevos Clientes Según Género");

            // Seleccionar el primer elemento (opcional)
            CBNuevoClientes.SelectedIndex = 0;

            CBGeneroReporte.Items.Add("Clientes según género");
            CBGeneroReporte.Items.Add("Ventas anuales según género");
            CBGeneroReporte.SelectedIndexChanged += CBGeneroReporte_SelectedIndexChanged;
            CBGeneroReporte.SelectedIndex = 0; 
            MostrarGraficoVentasAnualesSegunGenero();
        }

        private void CBGeneroReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBGeneroReporte.SelectedItem.ToString() == "Clientes según género")
            {
                MostrarGraficoClientesSegunGenero();
            }
            else if (CBGeneroReporte.SelectedItem.ToString() == "Ventas anuales según género")
            {
                MostrarGraficoVentasAnualesSegunGenero();
            }
        }

        private void MostrarGraficoClientesSegunGenero()
        {
            var datosClientes = new Dictionary<string, int>
    {
        { "Masculino", 30 }, // Cambia estos valores según tus datos reales
        { "Femenino", 20 }   // Cambia estos valores según tus datos reales
    };

            // Limpiar el gráfico anterior
            ChartGeneroCliente.Series.Clear();
            ChartGeneroCliente.ChartAreas.Clear();

            // Configurar el área del gráfico
            ChartArea area = new ChartArea();
            ChartGeneroCliente.ChartAreas.Add(area);

            // Crear la serie para el gráfico de torta
            Series serie = new Series
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            foreach (var dato in datosClientes)
            {
                serie.Points.AddXY(dato.Key, dato.Value);
            }

           
            ChartGeneroCliente.Series.Add(serie);

          
            Legend leyenda = new Legend
            {
                Docking = Docking.Right, 
                Alignment = StringAlignment.Center 
            };
            ChartGeneroCliente.Legends.Add(leyenda);

            
            foreach (var point in serie.Points)
            {
                point.LegendText = point.AxisLabel; 
            } 
        }

        private void MostrarGraficoVentasAnualesSegunGenero()
        {
            // Simulación de datos de ventas anuales por género
            var datosVentas = new Dictionary<string, Dictionary<string, int>>
        {
            { "Enero", new Dictionary<string, int> { { "Masculino", 2000 }, { "Femenino", 1500 } } },
            { "Febrero", new Dictionary<string, int> { { "Masculino", 1800 }, { "Femenino", 1200 } } },
            // Agrega más meses según sea necesario
        };

            ChartGeneroCliente.Series.Clear();
            ChartGeneroCliente.ChartAreas.Clear();
            ChartArea area = new ChartArea();
            ChartGeneroCliente.ChartAreas.Add(area);

            // Crear series para cada género
            Series serieMasculino = new Series
            {
                Name = "Masculino",
                ChartType = SeriesChartType.Bar
            };
            Series serieFemenino = new Series
            {
                Name = "Femenino",
                ChartType = SeriesChartType.Bar
            };

            foreach (var mes in datosVentas)
            {
                serieMasculino.Points.AddXY(mes.Key, mes.Value["Masculino"]);
                serieFemenino.Points.AddXY(mes.Key, mes.Value["Femenino"]);
            }

            ChartGeneroCliente.Series.Add(serieMasculino);
            ChartGeneroCliente.Series.Add(serieFemenino);
            ChartGeneroCliente.Legends.Clear(); // Opcional, para limpiar leyendas
        }

        private void CBNuevoClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica qué opción se seleccionó en el ComboBox
            if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes")
            {
                CargarDatosNuevosClientes();
            }
            else if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes Según Género")
            {
                CargarDatosNuevosClientesSegunGenero();
            }
        }

        private void CargarDatosNuevosClientes()
        {
            // Ejemplo de datos de nuevos clientes por mes
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int[] nuevosClientes = { 10, 15, 20, 25, 3, 1, 30, 15, 9, 25, 31, 39 };

            // Configura el gráfico
            ChartNuevosClientes.Series.Clear();
            Series serie = new Series("Nuevos Clientes");
            serie.ChartType = SeriesChartType.Line; 

            // Agrega los datos al gráfico
            for (int i = 0; i < meses.Length; i++)
            {
                serie.Points.AddXY(meses[i], nuevosClientes[i]);
            }

            ChartNuevosClientes.Series.Add(serie);

            // Configura los títulos
            ChartNuevosClientes.Titles.Add("Nuevos Clientes por Mes");
            ChartNuevosClientes.ChartAreas[0].AxisX.Title = "Meses";
            ChartNuevosClientes.ChartAreas[0].AxisY.Title = "Nuevos Clientes";
            ChartNuevosClientes.Legends[0].Enabled = false;
        }

        private void CargarDatosNuevosClientesSegunGenero()
        {
            // Ejemplo de datos mensuales por género
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int[] nuevosClientesMasculinos = { 10, 12, 15, 20, 25, 18, 22, 30, 28, 35, 40, 45 };
            int[] nuevosClientesFemeninos = { 8, 10, 12, 15, 18, 20, 25, 30, 35, 28, 22, 20 };

            // Configura el gráfico
            ChartNuevosClientes.Series.Clear();

            // Serie para Masculinos
            Series serieMasculinos = new Series("Masculinos");
            serieMasculinos.ChartType = SeriesChartType.Column; // Cambia a columna para diferenciar
            for (int i = 0; i < meses.Length; i++)
            {
                serieMasculinos.Points.AddXY(meses[i], nuevosClientesMasculinos[i]);
            }
            ChartNuevosClientes.Series.Add(serieMasculinos);

            // Serie para Femeninos
            Series serieFemeninos = new Series("Femeninos");
            serieFemeninos.ChartType = SeriesChartType.Column; // Cambia a columna para diferenciar
            for (int i = 0; i < meses.Length; i++)
            {
                serieFemeninos.Points.AddXY(meses[i], nuevosClientesFemeninos[i]);
            }
            ChartNuevosClientes.Series.Add(serieFemeninos);

            // Configura los títulos
            ChartNuevosClientes.Titles.Clear(); // Limpiar títulos anteriores
            ChartNuevosClientes.Titles.Add("Nuevos Clientes Según Género (Mensual)");
            ChartNuevosClientes.ChartAreas[0].AxisX.Title = "Mes";
            ChartNuevosClientes.ChartAreas[0].AxisY.Title = "Nuevos Clientes";
            ChartNuevosClientes.Legends[0].Enabled = true; // Habilitar leyenda para distinguir entre géneros
        }

        private void CBNuevoClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes")
            {
                CargarDatosNuevosClientes();
            }
            else if (CBNuevoClientes.SelectedItem.ToString() == "Nuevos Clientes Según Género")
            {
                CargarDatosNuevosClientesSegunGenero();
            }
        }
    }
}
