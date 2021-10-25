using Entidade;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
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
        {

        }

        public string Gerar(AnaliseEntidade Analise, List<AmostraEntidade> Amostra)
        {
            var caminho = ValidarCaminhoPDF(Analise.Solicitantes.Nome);
            caminho += $"\\{Analise.Solicitantes.Nome} - " + DateTime.Now.Month + "-" + DateTime.Now.Year + ".pdf";

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);
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


                document.Add(new Paragraph("\n \n"));

                Table tableNomeLaudo = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableNomeLaudo.AddCell("Laudo").AddStyle(tituloCent).SetBorder(Border.NO_BORDER);
                document.Add(tableNomeLaudo);


                Table tableNomeSolicitante = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableNomeSolicitante.AddCell("Proprietário: " + Analise.Solicitantes.Nome).AddStyle(normalInfo).SetBorder(Border.NO_BORDER);
                document.Add(tableNomeSolicitante);


                Table tableInfoSolicitante = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Data: " + Analise.DataCriado).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Solicitante: " + Analise.TipoSolicitacao).SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Laudo: " + Analise.IdAnalise).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Cultura: " + Analise.Cultura).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Fazenda: " + Analise.Local).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tableInfoSolicitante.AddCell("Referência: " + Analise.Referencia).AddStyle(normal).SetBorder(Border.NO_BORDER);
                document.Add(tableInfoSolicitante);

                document.Add(new Paragraph("\n"));

                float[] colWidths = new float[] { 4, 1 };
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
                tableValores.AddCell("Poten. Hidrogen.").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].pH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].pH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].pH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].pH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("P").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Fósforo").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].P).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].P).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].P).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].P).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("K").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Potássio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].K).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].K).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].K).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].K).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Ca").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Cálcio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Ca).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Ca).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Ca).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Ca).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Mg").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Magnésio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Mg).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Mg).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Mg).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Mg).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Al").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("KCI").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Alumínio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Al).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Al).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Al).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Al).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Al + H").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Aceta. Cálcio").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Ácid. Potencial").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].AlH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].AlH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].AlH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].AlH).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("SB").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Soma de base").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].SB).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("t").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("CTC efetiva").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].ti).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("T").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("CTC pH 7,0").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mmol/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].T).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("V").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Satu. Base").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" % ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].V).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("m").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" - ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Satu. Al").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(" % ").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].m).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Zn").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Zinco").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Zn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Zn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Zn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Zn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Cu").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Cobre").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Cu).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Cu).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Cu).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Cu).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Fe").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Ferro").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Fe).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Fe).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Fe).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Fe).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Mn").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Mehlich-1").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Manganês").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Mn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Mn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Mn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Mn).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("B").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Água quente").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Boro").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].B).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].B).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].B).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].B).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("S").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Carvão ativado").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Enxofre").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("mg/dm³").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].S).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].S).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].S).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].S).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("M.O").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Dicromato Na").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Matéria orgânica").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Dag/kg").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].MO).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].MO).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].MO).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].MO).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Argila").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Argila").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Argila).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Areia").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Areia").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Areia).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Silte").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("NaOH 1,0 mol").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("Silte").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell("%").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[0].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[1].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[2].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableValores.AddCell(Amostra[3].Silte).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                document.Add(tableValores);


                colWidths = new float[] { 6, 1, 1, 1, 1 };
                Table tableTonHa = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);

                tableTonHa.AddCell("Sujestão de necessidade de Calagem (Ton/Ha)").AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableTonHa.AddCell(Amostra[0].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableTonHa.AddCell(Amostra[1].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableTonHa.AddCell(Amostra[2].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);
                tableTonHa.AddCell(Amostra[3].TonHa).AddStyle(normalCent).SetBorder(Border.NO_BORDER);

                document.Add(tableTonHa);

                document.Add(new Paragraph("\n"));

                //Table tableRodape = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("Observações: Caso a sujestão de calagem tenha um valor negativo não há a necessidade de calagem.").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("Necessidade  de calagem foi calculada usando a metodologia do livro:Recomendações para o uso de corretivos  e fertilizantes em minas gerais, Pág 52. E V% ideal de 60. Item 8.2.2 \"Método da saturação por base\".").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //tableRodape.AddCell("A Agro Frutal Laboratórios de análies agrícolas LTDA, não se responsabiliza pela interpretação desta análise.").AddStyle(rodape).SetBorder(Border.NO_BORDER);
                //document.Add(tableRodape);

                document.Close();
                pdfDocument.Close();
                return "Laudo Gerado!";
            };
        }
        string ValidarCaminhoPDF(string nomeSolicitante)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\Laudo";
            var caminhoSolicitante = $"{desktop}\\Laudo\\{nomeSolicitante}";

            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }

            if (!Directory.Exists(caminhoSolicitante))
            {
                Directory.CreateDirectory(caminhoSolicitante);
            }

            return caminhoSolicitante;
        }
    }
}
