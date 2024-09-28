using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Views.Vendedor
{
    public partial class ConfirmarVenta : Form
    {
        public ConfirmarVenta()
        {
            InitializeComponent();
        }

        private void ConfirmarVenta_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BConfirmarCompraFinalizarCompra_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configurar el tamaño de la hoja A4
            float pageWidth = e.MarginBounds.Width;  // Ancho útil
            int margin = 20; // Márgenes

            // Fuentes
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);

            // Brochas
            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush headerBrush = new SolidBrush(Color.LightGray);

            // Logo de la empresa
            g.FillRectangle(Brushes.Blue, margin, margin, 160, 50); // Logo representado como un rectángulo
            g.DrawString("TECNO PUNTA", new Font("Arial", 14, FontStyle.Bold), Brushes.White, margin + 5, margin + 15);

            // Información del cliente
            g.DrawString("Información del Cliente", titleFont, brush, margin, margin + 70);
            g.FillRectangle(headerBrush, new Rectangle(margin, margin + 100, (int)(pageWidth - margin * 2), 30));
            g.DrawString("Nombre", headerFont, brush, margin + 10, margin + 105);
            g.DrawString("Apellido", headerFont, brush, margin + 150, margin + 105);
            g.DrawString("DNI", headerFont, brush, margin + 300, margin + 105);
            g.DrawString("Teléfono", headerFont, brush, margin + 400, margin + 105);

            g.DrawString("Julian", contentFont, brush, margin + 10, margin + 135);
            g.DrawString("Perez", contentFont, brush, margin + 150, margin + 135);
            g.DrawString("37890275", contentFont, brush, margin + 300, margin + 135);
            g.DrawString("3794090344", contentFont, brush, margin + 400, margin + 135);

          

            // Método de pago
            g.DrawString("Método de Pago", titleFont, brush, margin, margin + 230);
            g.FillRectangle(headerBrush, new Rectangle(margin, margin + 260, (int)(pageWidth - margin * 2), 30));
            g.DrawString("Pago", headerFont, brush, margin + 10, margin + 265);
            g.DrawString("Fecha de Facturación", headerFont, brush, margin + 200, margin + 265);

            g.DrawString("Efectivo", contentFont, brush, margin + 10, margin + 295);
            g.DrawString(DateTime.Now.ToShortDateString(), contentFont, brush, margin + 200, margin + 295);

            // Detalle de la compra
            g.DrawString("Detalle de la Compra", titleFont, brush, margin, margin + 320);
            g.FillRectangle(headerBrush, new Rectangle(margin, margin + 350, (int)(pageWidth - margin * 2), 30));
            g.DrawString("Descripción", headerFont, brush, margin + 10, margin + 355);
            g.DrawString("Cantidad", headerFont, brush, margin + 300, margin + 355);
            g.DrawString("Precio", headerFont, brush, margin + 400, margin + 355);

            // Líneas de la factura
            g.DrawLine(Pens.Black, margin, margin + 390, pageWidth - margin, margin + 390);

            // Detalles de productos
            g.DrawString("Producto A", contentFont, brush, margin + 10, margin + 400);
            g.DrawString("2", contentFont, brush, margin + 300, margin + 400);
            g.DrawString("$20.00", contentFont, brush, margin + 400, margin + 400);

            g.DrawString("Producto B", contentFont, brush, margin + 10, margin + 430);
            g.DrawString("1", contentFont, brush, margin + 300, margin + 430);
            g.DrawString("$10.00", contentFont, brush, margin + 400, margin + 430);

            // Línea de separación
            g.DrawLine(Pens.Black, margin, margin + 460, pageWidth - margin, margin + 460);

            // Total
            g.DrawString("Total: $50.00", headerFont, brush, margin + 300, margin + 480);

            // Agrega un pie de página
            g.DrawString("Gracias por su compra!", contentFont, brush, margin + 100, margin + 520);
        
        }
    }
}
