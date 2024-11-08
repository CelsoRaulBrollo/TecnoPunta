using ProyectoTaller.CModelos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using QuestPDF;
using System.IO;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Web.UI.WebControls.WebParts;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Diagnostics;


namespace ProyectoTaller.Questpdf
{
    public class InvoiceDocument: IDocument
    {
        private Venta venta { get; }
        public static Image LogoImage { get {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string questPdfDirectory = Path.Combine(currentDirectory, "..", "..", "Questpdf");
                string logoPath = Path.Combine(questPdfDirectory, "Logo.png");
           
                return Image.FromFile(logoPath);
            } } 

        public InvoiceDocument(Venta venta)
        {
            this.venta = venta;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void crearDocumento()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                 
                    using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        Document.Create(container =>
                        {
                            container
                                .Page(page =>
                                {
                                    page.Margin(50);

                                    page.Header().Element(ComposeHeader);
                                    page.Content().Element(ComposeContent);
                                 
                                    page.Footer().AlignCenter().Text(x =>
                                    {
                                        x.CurrentPageNumber();
                                        x.Span(" / ");
                                        x.TotalPages();
                                    });
                                });
                        }).GeneratePdf(stream); // Guarda el PDF en el archivo seleccionado
                    }

                    MessageBox.Show($"PDF guardado en: {filePath}");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true // Necesario para abrir el archivo con la aplicación predeterminada
                    });
                }
            }
        }
        public void Compose(IDocumentContainer container)
        {

            container
            .Page(page =>
            {
                page.Margin(50);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
           

                page.Footer().AlignCenter().Text(x =>
                {
                    x.CurrentPageNumber();
                    x.Span(" / ");
                    x.TotalPages();
                });
            });



        }

      
        public void ComposeHeader(IContainer container)
        {
            var titleStyle = TextStyle.Default.FontSize(20).SemiBold().FontColor(Color.FromHex("085d38"));

            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text($"ID Factura #{venta.idVenta}").Style(titleStyle);

                    column.Item().Text(text =>
                    {
                        text.Span("Fecha de Emision: ").SemiBold().FontColor(Color.FromHex("026338"));
                        text.Span($"{venta.fechaDeVenta:d}");
                    });
                    
                    column.Item().Text($"Calle Falsa 1234 nº1212; Corrientes Capital");
                    column.Item().Text($"Telefono: 3794-432201");
                    column.Item().Text($"Correo: cliente@tecnopunta.com");


                });
             
                row.ConstantItem(200).Height(70).Image(LogoImage).FitArea();

              
            });
           

        }

        public void ComposeContent(IContainer container)
        {
            container.PaddingVertical(5).Column(column =>
            {
                column.Spacing(20);

                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(x =>
                    {
                      

                        x.Item().Text(text =>
                        {
                            text.Span("Cliente: ").SemiBold().FontColor(Color.FromHex("026338"));
                            text.Span($"{venta.cliente.Nombre_Cliente} {venta.cliente.Apellido_Cliente}");
                        });


                        x.Item().Text(text =>
                        {
                            text.Span("DNI: ").SemiBold().FontColor(Color.FromHex("026338"));
                            text.Span($"{venta.cliente.DNI_Cliente:d}");
                        });
                        x.Item().Text(text =>
                        {
                            text.Span("Correo: ").SemiBold().FontColor(Color.FromHex("026338"));
                            text.Span($"{venta.cliente.Correo_Cliente:d}");
                        });

                      


                    });

                });

            column.Item().Element(ComposeTable);

            column.Item().AlignRight().Text($"TOTAL: {venta.total}$").FontSize(14);

                column.Item().Element(ComposeComments);
            });

            
        }
        void ComposeComments(IContainer container)
        {
            container.Background(Color.FromHex("b0d1c2")).Padding(10).Column(column =>
            {

                column.Spacing(5);
                column.Item().Text("Atencion").FontSize(14);
                column.Item().Text("\r\nPara realizar una devolución, el producto debe estar en su estado original, sin uso y con etiquetas. Tienes un plazo de 30 días a partir de la fecha de compra para solicitarla. Para iniciar el proceso, asegúrate de conservar el recibo de compra. Puedes comunicarte con nuestro servicio al cliente al 3794-432201 de lunes a viernes, de 9:00 a 18:00 horas, o enviar un correo electrónico a cliente@tecnopunta.com.").Justify();
            });
        }

        public void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                // step 1
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                // step 2
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Producto");
                    header.Cell().Element(CellStyle).AlignRight().Text("Precio Unitario");
                    header.Cell().Element(CellStyle).AlignRight().Text("Cantidad");
                    header.Cell().Element(CellStyle).AlignRight().Text("Subtotal");

                     IContainer CellStyle(IContainer myContainer)
                    {
                        return myContainer.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Color.FromHex("026338"));
                    }
                });
                int i = 1;
                // step 3
                foreach (var item in venta.detalles)
                {
                    table.Cell().Element(CellStyle).Text($"{i}");
                    table.Cell().Element(CellStyle).Text(item.producto.Nombre_Producto);
                    table.Cell().Element(CellStyle).AlignRight().Text($"{ item.subtotal /item.cantidad}$");
                    table.Cell().Element(CellStyle).AlignRight().Text(item.cantidad);
                    table.Cell().Element(CellStyle).AlignRight().Text($"{item.subtotal}$");

                     IContainer CellStyle(IContainer myContainer)
                    {
                        return myContainer.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
                    }

                    i = i + 1;
                }
            });
        }

    
    }
}
