using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.CNegocio;
using ProyectoTaller.DTO;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class VentaDetalles : Form
    {
        private VentaNegocio ventaNegocio;

        
        public VentaDetalles(int idVenta)
        {
            InitializeComponent();
            cargarVenta(idVenta);
        }

        public void cargarVenta(int idVenta) 
        {
            ventaNegocio = new VentaNegocio();
            LNombreCompraVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.Nombre_Cliente;
            LApellidosVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.Apellido_Cliente;
            LDNIVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.DNI_Cliente.ToString();
            LTelefonoVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.Telefono_Cliente;
            LDireccionVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.Direccion_Cliente;
            LCorreoVenta.Text = ventaNegocio.buscarVentaPorId(idVenta).cliente.Correo_Cliente;
            LIDVenta.Text = idVenta.ToString();
            LTotalVista.Text= ventaNegocio.buscarVentaPorId(idVenta).total.ToString();



            List<CarritoDetalleDTO> detalleVenta = new List<CarritoDetalleDTO>();

            foreach (VentaDetalle item in ventaNegocio.buscarVentaPorId(idVenta).detalles)
            {
                
                CarritoDetalleDTO carritoVenta = new CarritoDetalleDTO
                {
                    Modelo = item.producto.Modelo_Producto,
                    Descripcion = "Nombre: " + item.producto.Nombre_Producto + " Sistema Operativo: " + item.producto.SistemaOperativo_Producto + " Ram: " + item.producto.Ram_Producto + " Almacenamiento: " + item.producto.Almacenamiento_Producto,
                    cantidad = item.cantidad,
                    precio = item.subtotal / item.cantidad,
                };
                detalleVenta.Add(carritoVenta);
            }

            DGVentaDetalle.DataSource = detalleVenta;
            DGVentaDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarMetodoPago(ventaNegocio.buscarVentaPorId(idVenta).metodoDePago.nombre.ToString());
        }

        public void cargarMetodoPago(string metodo)
        {
            CBTarjetaDeCredito.Enabled = false;
            CBTarjetaDeCredito.Checked = false;
            CBTarjetaDeDebito.Enabled = false;
            CBTarjetaDeDebito.Checked = false;
            CBBilleteraVirtual.Enabled = false;
            CBBilleteraVirtual.Checked = false;
            CBEfectivo.Enabled = false;
            CBEfectivo.Checked = false;

            // Habilitar solo el checkbox correspondiente
            switch (metodo)
            {
                case "Tarjeta De Credito":
                    
                    CBTarjetaDeCredito.Checked = true; 
                    break;
                case "Tarjeta De Debito":
                  
                    CBTarjetaDeDebito.Checked = true;
                    break;
                case "Billetera Virtual":
                   
                    CBBilleteraVirtual.Checked = true;
                    break;
                case "Efectivo":
     
                    CBEfectivo.Checked = true;
                    break;
                default:
                   
                    break;
            }
        }
        
        private void CBBilleteraVirtual_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void BImprimirDetalle_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        private void GenerarPDF()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "ReporteVentas.pdf";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.Title = "Guardar Reporte de Ventas";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var document = Document.Create(container =>
                    {
                        container
                            .Page(page =>
                            {
                                page.Content().Column(column =>
                                {
                                    column.Item().Text("Reporte de Ventas").FontSize(20).Bold();
                                    column.Item().PaddingVertical(10);
                                    column.Item().Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn(2);
                                            columns.RelativeColumn(1);
                                            columns.RelativeColumn(1);
                                        });

                                        table.Header(header =>
                                        {
                                            header.Cell().Text("Producto").Bold();
                                            header.Cell().Text("Cantidad").Bold();
                                            header.Cell().Text("Precio").Bold();
                                        });

                                        
                                        
                                            table.Cell().Text("venta.Producto");
                                            table.Cell().Text("2");
                                            table.Cell().Text("2333");
                                        
                                    });
                                });
                            });
                    });

                    document.GeneratePdf(saveFileDialog.FileName);
                    MessageBox.Show($"PDF generado en: {saveFileDialog.FileName}");
                }
            }
        }
    }
}

