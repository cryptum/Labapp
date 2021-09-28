using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GerarQuardriculado
    {

        public void Gerar()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\quadriculado\\quadriculado.pdf";

            if (!Directory.Exists($"{desktop}\\quadriculado"))
            {
                Directory.CreateDirectory($"{desktop}\\quadriculado");
            }

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);
                var document = new Document(pdfDocument, PageSize.A4.Rotate());
                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
                Style titulo = new Style();
                titulo.SetFont(font).SetFontSize(24).SetTextAlignment(TextAlignment.CENTER);
                Style normal = new Style();
                normal.SetFont(font).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER);

                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();

                document.Add(new Paragraph($"Quadriculado Analise química de Rotnina AA e CF ____/ {mes} / {ano}").AddStyle(normal));

                Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

                table.AddCell("Nº \n amostras").AddStyle(normal);
                table.AddCell("Potássio \n (K)").AddStyle(normal);
                table.AddCell("Cálcio \n (Ca)").AddStyle(normal);
                table.AddCell("Magnésio \n (Mg)").AddStyle(normal);
                table.AddCell("Zinco \n (Zn)").AddStyle(normal);
                table.AddCell("Cobre \n (Cu)").AddStyle(normal);
                table.AddCell("Ferro \n (Fe)").AddStyle(normal);
                table.AddCell("Maganês \n (Mn)").AddStyle(normal);

                for (int i = 0; i < 40; i++)
                {
                    table.AddCell("\n \n \n ");
                }

                document.Add(table);
                document.Close();
                pdfDocument.Close();
            };
        }
    }
}
