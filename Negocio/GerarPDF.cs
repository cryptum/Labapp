using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;

namespace Negocio
{
    public class GerarPDF
    {
        public GerarPDF(){}

        public void Gerar()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\recibo.pdf";

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Isso é um parágrafo do PDF"));
                document.Close();

                pdfDocument.Close();

            };
        }
        
    }
}
