using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entity;
namespace InfraStructure
{
    public class GenerarFactura
    {
        public void GuardarPdf(Factura factura)
        {
            FileStream fs = new FileStream("factura.pdf", FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);

            document.AddTitle("ITextSharp");
            document.AddCreator("sebastian Ochoa");

            document.Open();

            document.Add(new Paragraph($"FACTURA N° {factura.CodigoFactura}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"fecha {factura.FechaFactura}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Cliente° {factura.cliente.PrimerNombre} CC: {factura.cliente.Cedula}"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(factura.DetalleFacturas));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Subtotal° {factura.Subtotal}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"TotalIva° {factura.TotalIva}"));
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"total a Pagar° {factura.Total}"));
            document.Add(new Paragraph("\n"));
            document.Close();
        }
        private PdfPTable LlenarTabla(List<DetalleFactura> detalleFacturas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Codigo"));
            tabla.AddCell(new Paragraph("Descripcion"));
            tabla.AddCell(new Paragraph("vrUniratario"));
            tabla.AddCell(new Paragraph("iva"));
            tabla.AddCell(new Paragraph("Total"));

            foreach (var item in detalleFacturas)
            {
                tabla.AddCell(item.iddetallefactura);
                tabla.AddCell(item.Productos.Nombre);
                tabla.AddCell(item.Productos.ValorUnitario.ToString());
                tabla.AddCell(item.Iva.ToString());
                tabla.AddCell(item.Total.ToString());

            }
            return tabla;
        }
    }
}
