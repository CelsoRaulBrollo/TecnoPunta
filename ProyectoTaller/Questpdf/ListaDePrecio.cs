using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Questpdf
{
    internal class ListaDePrecio : IDocument
    {
        private List<ProductoDTO> listaProducto { get; }

        public ListaDePrecio(List<ProductoDTO> listaProducto)
        {
                this.listaProducto = listaProducto;
        }
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public static Image LogoImage
        {
            get
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string questPdfDirectory = Path.Combine(currentDirectory, "..", "..", "Questpdf");
                string logoPath = Path.Combine(questPdfDirectory, "Logo.png");

                return Image.FromFile(logoPath);
            }
        }


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
                    column.Item().Text($"Lista de Precio").Style(titleStyle);

                    column.Item().Text(text =>
                    {
                        text.Span("Fecha de Emision: ").SemiBold().FontColor(Color.FromHex("026338"));
                        DateTime fechaActual = DateTime.Now;
                        text.Span($"{fechaActual.ToString("dd/MM/yyyy")}");
                    });



                });

                row.ConstantItem(200).Height(70).Image(LogoImage).FitArea();


            });


        }

        public void ComposeContent(IContainer container)
        {
            container.PaddingVertical(5).Column(column =>
            {
                column.Spacing(20);

                column.Item().Element(ComposeTable);

               
            });


        }

        public void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                // step 1
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(70);
                    columns.RelativeColumn(3);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    
                });

                // step 2
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("Cod Producto");
                    header.Cell().Element(CellStyle).Text("Nombre");
                    header.Cell().Element(CellStyle).AlignRight().Text("Marca");
                    header.Cell().Element(CellStyle).AlignRight().Text("Precio");
                    

                    IContainer CellStyle(IContainer myContainer)
                    {
                        return myContainer.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Color.FromHex("026338"));
                    }
                });
                int i = 1;
                // step 3
                foreach (var item in listaProducto)
                {
                    if (item.Stock > 0 && item.Condicion == "ACTIVO")
                    {
                        table.Cell().Element(CellStyle).Text($"{item.Modelo}");
                        table.Cell().Element(CellStyle).Text(" " + item.Nombre);
                        table.Cell().Element(CellStyle).AlignRight().Text(item.Marca);
                        table.Cell().Element(CellStyle).AlignRight().Text($"{item.Precio}$");
                    }


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
