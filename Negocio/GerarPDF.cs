using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.IO;

namespace Negocio
{
    public class GerarPDF
    {
        public GerarPDF(){}

        public void Gerar()
        {
            var caminho = ValidarCaminhoPDF();
            caminho += "\\Laudo.pdf";

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                var document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Isso é um parágrafo do PDF"));
                document.Close();

                pdfDocument.Close();

            };
        }
        string ValidarCaminhoPDF()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\Laudo";

            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            return caminho;
        }
    }
}
