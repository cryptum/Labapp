using Entidade;
using Entidade.DTO;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;

namespace Negocio
{
    public class GerarPDF
    {
        public GerarPDF()
        { }

        public string Gerar(AnaliseEntidade Analise, List<AmostraImpressaoLaudoDTO> Amostra)
        {
            var caminho = ValidarCaminhoPDF(Analise.Proprietarios.Nome);

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                int countAmostra = Amostra.Count;
                var pdfDocument = new PdfDocument(wPdf);
                var document = new Document(pdfDocument, PageSize.A4);

                //while (countAmostra > 0)
                //{
                //    //pdfDocument.AddNewPage();
                //    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                //    document = GerarFolha(pdfDocument, Analise, Amostra);
                //    countAmostra = countAmostra - 4;
                //}
                document = GerarFolha(pdfDocument, Analise, Amostra);

                document.Close();
                pdfDocument.Close();
                return "Laudo Gerado!";
            };
        }


        public Document GerarFolha(PdfDocument pdfDocument, AnaliseEntidade Analise, List<AmostraImpressaoLaudoDTO> Amostra)
        {
            var document = new Document(pdfDocument, PageSize.A4);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            Style tituloCent = new Style();
            tituloCent.SetFont(font).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).SetFontColor(Color.ConvertRgbToCmyk(new DeviceRgb(255, 255, 255))).SetBackgroundColor(Color.ConvertRgbToCmyk(new DeviceRgb(149, 164, 166)));
            Style subTituloCent = new Style();
            subTituloCent.SetFont(font).SetFontSize(12).SetHorizontalAlignment(HorizontalAlignment.CENTER).SetTextAlignment(TextAlignment.CENTER).SetFontColor(Color.ConvertRgbToCmyk(new DeviceRgb(255, 255, 255))).SetBackgroundColor(Color.ConvertRgbToCmyk(new DeviceRgb(149, 164, 166)));

            Style normalInfo = new Style();
            normalInfo.SetFont(font).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER);
            Style normalCent = new Style();
            normalCent.SetFont(font).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER);
            Style normal = new Style();
            normal.SetFont(font).SetFontSize(10).SetTextAlignment(TextAlignment.LEFT);

            Style rodape = new Style();
            rodape.SetFont(font).SetFontSize(8).SetTextAlignment(TextAlignment.LEFT);

            var countAmostra = Amostra.Count;
            while (countAmostra > 0)
            {
                while (countAmostra < 3)
                {
                    Amostra.Add(new AmostraImpressaoLaudoDTO());
                    countAmostra++;
                }

                foreach (var item in Amostra)
                {
                    if (item.Nome == null || item.Nome.Trim() == "")
                    {
                        item.Nome = "N/S";
                    }
                }

                document.Add(new Paragraph("\n \n"));

                Table tableNomeLaudo = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableNomeLaudo.AddCell("Laudo").AddStyle(tituloCent).SetBorder(Border.NO_BORDER);
                document.Add(tableNomeLaudo);


                Table tableNomeProprietario = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableNomeProprietario.AddCell("Proprietário: " + Analise.Proprietarios.Nome).AddStyle(normalInfo).SetBorder(Border.NO_BORDER);
                document.Add(tableNomeProprietario);


                Table tableInfoProprietario = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Data: " + Analise.DataCriado).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Solicitante: " + Analise.Convenio).SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Laudo: " + Analise.NomeAnalise).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Cultura: " + Analise.Cultura).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Fazenda: " + Analise.Fazenda).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoProprietario.AddCell("Referência: " + Analise.Referencia).AddStyle(normal).SetBorder(Border.NO_BORDER);
                document.Add(tableInfoProprietario);

                document.Add(new Paragraph("\n"));

                float[] colWidths = new float[] { 6, 4 };
                Table tableSubTitulo = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableSubTitulo.AddCell("Laudo de monitoramento nutricional do solo").AddStyle(subTituloCent).SetBorder(Border.NO_BORDER);
                tableSubTitulo.AddCell("Amostra").AddStyle(subTituloCent).SetBorder(Border.NO_BORDER);
                document.Add(tableSubTitulo);

                colWidths = new float[] { 1, 2, 2, 1, 1, 1, 1, 1 };
                Table tableValores = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Símbolo").AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Metodologia").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Elemento").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Unidade").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("2").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("3").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("4").AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("pH").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Água").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Poten. Hidrogenico").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].PhAgua == null || Amostra[0].PhAgua == "" ? "N/S" : Amostra[0].PhAgua).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].PhAgua == null || Amostra[1].PhAgua == "" ? "N/S" : Amostra[1].PhAgua).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].PhAgua == null || Amostra[2].PhAgua == "" ? "N/S" : Amostra[2].PhAgua).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].PhAgua == null || Amostra[3].PhAgua == "" ? "N/S" : Amostra[3].PhAgua).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("P").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Fósforo").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Fosforo == null ? "N/S" : Amostra[0].Fosforo).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Fosforo == null ? "N/S" : Amostra[1].Fosforo).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Fosforo == null ? "N/S" : Amostra[2].Fosforo).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Fosforo == null ? "N/S" : Amostra[3].Fosforo).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("K").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Potássio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Potassio == null ? "N/S" : Amostra[0].Potassio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Potassio == null ? "N/S" : Amostra[1].Potassio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Potassio == null ? "N/S" : Amostra[2].Potassio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Potassio == null ? "N/S" : Amostra[3].Potassio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Ca").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Cálcio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Calcio == null ? "N/S" : Amostra[0].Calcio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Calcio == null ? "N/S" : Amostra[1].Calcio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Calcio == null ? "N/S" : Amostra[2].Calcio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Calcio == null ? "N/S" : Amostra[3].Calcio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Mg").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Magnésio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Magnesio == null ? "N/S" : Amostra[0].Magnesio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Magnesio == null ? "N/S" : Amostra[1].Magnesio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Magnesio == null ? "N/S" : Amostra[2].Magnesio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Magnesio == null ? "N/S" : Amostra[3].Magnesio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Al").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Alumínio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Aluminio == null ? "N/S" : Amostra[0].Aluminio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Aluminio == null ? "N/S" : Amostra[1].Aluminio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Aluminio == null ? "N/S" : Amostra[2].Aluminio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Aluminio == null ? "N/S" : Amostra[3].Aluminio).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Al + H").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Aceta. Cálcio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Ácid. Potencial").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].AcidezPotencial == null ? "N/S" : Amostra[0].AcidezPotencial).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].AcidezPotencial == null ? "N/S" : Amostra[1].AcidezPotencial).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].AcidezPotencial == null ? "N/S" : Amostra[2].AcidezPotencial).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].AcidezPotencial == null ? "N/S" : Amostra[3].AcidezPotencial).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("SB").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Soma de base").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].SB == null ? "N/S" : Amostra[0].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].SB == null ? "N/S" : Amostra[1].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].SB == null ? "N/S" : Amostra[2].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].SB == null ? "N/S" : Amostra[3].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("t").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("CTC efetiva").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].ti == null ? "N/S" : Amostra[0].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].ti == null ? "N/S" : Amostra[1].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].ti == null ? "N/S" : Amostra[2].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].ti == null ? "N/S" : Amostra[3].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("T").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("CTC pH 7,0").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].T == null ? "N/S" : Amostra[0].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].T == null ? "N/S" : Amostra[1].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].T == null ? "N/S" : Amostra[2].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].T == null ? "N/S" : Amostra[3].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("V").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Satu. Base").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" % ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].V == null ? "N/S" : Amostra[0].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].V == null ? "N/S" : Amostra[1].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].V == null ? "N/S" : Amostra[2].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].V == null ? "N/S" : Amostra[3].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("m").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Satu. Al").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" % ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].m == null ? "N/S" : Amostra[0].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].m == null ? "N/S" : Amostra[1].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].m == null ? "N/S" : Amostra[2].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].m == null ? "N/S" : Amostra[3].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Zn").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Zinco").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Zinco == null ? "N/S" : Amostra[0].Zinco).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Zinco == null ? "N/S" : Amostra[1].Zinco).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Zinco == null ? "N/S" : Amostra[2].Zinco).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Zinco == null ? "N/S" : Amostra[3].Zinco).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Cu").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Cobre").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Cobre == null ? "N/S" : Amostra[0].Cobre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Cobre == null ? "N/S" : Amostra[1].Cobre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Cobre == null ? "N/S" : Amostra[2].Cobre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Cobre == null ? "N/S" : Amostra[3].Cobre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Fe").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Ferro").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Ferro == null ? "N/S" : Amostra[0].Ferro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Ferro == null ? "N/S" : Amostra[1].Ferro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Ferro == null ? "N/S" : Amostra[2].Ferro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Ferro == null ? "N/S" : Amostra[3].Ferro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Mn").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Manganês").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Manganes == null ? "N/S" : Amostra[0].Manganes).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Manganes == null ? "N/S" : Amostra[1].Manganes).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Manganes == null ? "N/S" : Amostra[2].Manganes).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Manganes == null ? "N/S" : Amostra[3].Manganes).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("B").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Água quente").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Boro").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Boro == null ? "N/S" : Amostra[0].Boro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Boro == null ? "N/S" : Amostra[1].Boro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Boro == null ? "N/S" : Amostra[2].Boro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Boro == null ? "N/S" : Amostra[3].Boro).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("S").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Carvão ativado").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Enxofre").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Enxofre == null ? "N/S" : Amostra[0].Enxofre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Enxofre == null ? "N/S" : Amostra[1].Enxofre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Enxofre == null ? "N/S" : Amostra[2].Enxofre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Enxofre == null ? "N/S" : Amostra[3].Enxofre).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("M.O").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Dicromato Na").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Matéria orgânica").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Dag/kg").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].MateriaOrganica == null ? "N/S" : Amostra[0].MateriaOrganica).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].MateriaOrganica == null ? "N/S" : Amostra[1].MateriaOrganica).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].MateriaOrganica == null ? "N/S" : Amostra[2].MateriaOrganica).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].MateriaOrganica == null ? "N/S" : Amostra[3].MateriaOrganica).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Argila").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Argila").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Argila == null ? "N/S" : Amostra[0].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Argila == null ? "N/S" : Amostra[1].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Argila == null ? "N/S" : Amostra[2].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Argila == null ? "N/S" : Amostra[3].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Areia").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Areia").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Areia == null ? "N/S" : Amostra[0].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Areia == null ? "N/S" : Amostra[1].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Areia == null ? "N/S" : Amostra[2].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Areia == null ? "N/S" : Amostra[3].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Silte").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Silte").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Silte == null ? "N/S" : Amostra[0].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Silte == null ? "N/S" : Amostra[1].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Silte == null ? "N/S" : Amostra[2].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Silte == null ? "N/S" : Amostra[3].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                document.Add(tableValores);


                //colWidths = new float[] { 6, 1, 1, 1, 1 };
                //Table tableTonHa = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);

                //tableTonHa.AddCell("Sujestão de necessidade de Calagem (Ton/Ha)").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                //tableTonHa.AddCell(Amostra[0].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                //tableTonHa.AddCell(Amostra[1].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                //tableTonHa.AddCell(Amostra[2].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                //tableTonHa.AddCell(Amostra[3].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                //document.Add(tableTonHa);

                document.Add(new Paragraph("\n"));

                //Table tableRodape = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("Observações: Caso a sujestão de calagem tenha um valor negativo não há a necessidade de calagem.").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("Necessidade  de calagem foi calculada usando a metodologia do livro:Recomendações para o uso de corretivos  e fertilizantes em minas gerais, Pág 52. E V% ideal de 60. Item 8.2.2 \"Método da saturação por base\".").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("A Agro Frutal Laboratórios de análies agrícolas LTDA, não se responsabiliza pela interpretação desta análise.").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //document.Add(tableRodape);


                Table tableLeganda = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableLeganda.AddCell("Legenda das Amostras").AddStyle(tituloCent).SetBorder(Border.NO_BORDER);
                document.Add(tableLeganda);

                colWidths = new float[] { 3, 3, 3, 3 };
                Table tableNomeAmostra = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableNomeAmostra.AddCell("1:" + Amostra[0].Nome == null || Amostra[0].Nome == "" ? "N/S" : Amostra[0].Nome).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableNomeAmostra.AddCell("2:" + Amostra[1].Nome == null || Amostra[1].Nome == "" ? "N/S" : Amostra[1].Nome).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableNomeAmostra.AddCell("3:" + Amostra[2].Nome == null || Amostra[2].Nome == "" ? "N/S" : Amostra[2].Nome).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableNomeAmostra.AddCell("4:" + Amostra[3].Nome == null || Amostra[3].Nome == "" ? "N/S" : Amostra[3].Nome).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                document.Add(tableNomeAmostra);

                document.Add(new Paragraph("\n"));
                document.Add(new Paragraph("\n"));

                Amostra.RemoveRange(0, 3);
                countAmostra = countAmostra - 4;

            }
            
            return document;
        }


        string ValidarCaminhoPDF(string nomeProprietario)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\Laudo";
            var caminhoProprietario = $"{desktop}\\Laudo\\{nomeProprietario}";

            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            if (!Directory.Exists(caminhoProprietario))
            {
                Directory.CreateDirectory(caminhoProprietario);
            }


            caminhoProprietario += MontaNomeArquivoPDF(caminhoProprietario, nomeProprietario);

            return caminhoProprietario;
        }

        string MontaNomeArquivoPDF(string caminhoDestino, string ProprietarioNome)
        {
            bool loop = true;
            string caminho = "";
            int n = 0;
            while (loop)
            {
                caminho = $"\\ {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year} - {ProprietarioNome} - {n} " + ".pdf";

                if (!File.Exists(caminhoDestino + caminho))
                {
                    loop = false;
                }

                n++;
            }

            return caminho;
        }

    }
}
