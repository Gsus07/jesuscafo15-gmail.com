using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entity;
namespace infra
{
    public class GenerarPdf
    {
        //    public void GuardarPdf(List<Persona> personas)
        //    {
        //        FileStream fs = new FileStream("Personas.pdf", FileMode.Create);
        //        Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
        //        PdfWriter pw = PdfWriter.GetInstance(document, fs);

        //        document.AddTitle("ITextSharp");
        //        document.AddCreator("sebastian Ochoa");

        //        document.Open();

        //        document.Add(new Paragraph("Lista de Personas registradas"));
        //        document.Add(new Paragraph("\n"));
        //        document.Add(LlenarTabla(personas));
        //        document.Close();
        //    }
        //    private PdfPTable LlenarTabla(List<Persona> personas)
        //    {
        //        PdfPTable tabla = new PdfPTable(5);
        //        tabla.AddCell(new Paragraph("Identificacion"));
        //        tabla.AddCell(new Paragraph("Nombre"));
        //        tabla.AddCell(new Paragraph("Edad"));
        //        tabla.AddCell(new Paragraph("Sexo"));
        //        tabla.AddCell(new Paragraph("Pulsacion"));

        //        foreach (var item in personas)
        //        {
        //            tabla.AddCell(item.Identificacion);
        //            tabla.AddCell(item.Nombre);
        //            tabla.AddCell(item.Edad.ToString());
        //            tabla.AddCell(item.Sexo);
        //            tabla.AddCell(item.Pulsacion.ToString());

        //        }
        //        return tabla;
        //    }
        }
    
    
}
