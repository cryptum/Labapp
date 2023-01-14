using Entidade.DTO;
using iText.IO.Font.Constants;
using iText.IO.Image;
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
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class OrdemServico : Form
    {
        private static OrdemServico aForm = null;
        public static OrdemServico Instance()
        {
            if (aForm == null)
            {
                aForm = new OrdemServico();
            }
            return aForm;
        }
        public OrdemServico()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_DataDaEntrada_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OrdemServicoDTO ordem = new();
            ordem.Numero = txt_Numero.Text;
            ordem.CNPJ = txt_CNPJ.Text;
            ordem.Cliente = txt_Cliente.Text;
            ordem.Endereco = txt_Endereco.Text;
            ordem.Contato = txt_Contato.Text;
            ordem.Fone = txt_Fone.Text;
            ordem.Email = txt_Email.Text;
            ordem.NumeroOrdemDeCompra = txt_NOrdemDeCompra.Text;

            ordem.ValorTotalDaPrestacao = txt_ValorTotalDaPrestacao.Text;
            ordem.EntreguePor = txt_EntreguePor.Text;
            ordem.DataEntrada = txt_DataDaEntrada.Text;
            ordem.HoraEntrada = txt_HoraEntrada.Text;
            ordem.DataResultado = txt_DataResultado.Text;
            ordem.HoraResultado = txt_HoraResultado.Text;
            ordem.ReponsavelRecebimento = txt_ResponsavelRecebimento.Text;

            List<DataGridOrdemServicoDTO> ListaDataOrdem = new List<DataGridOrdemServicoDTO>();
            //percorre o DataGridView
            for (int i = 0; i < dataGridOrdemCompra.Rows.Count; i++)
            {
                DataGridOrdemServicoDTO dataOrdem = new DataGridOrdemServicoDTO();

                dataOrdem.NAmostra = dataGridOrdemCompra.Rows[i].Cells[0].Value.ToString();
                dataOrdem.IdCliente = dataGridOrdemCompra.Rows[i].Cells[1].Value.ToString();
                dataOrdem.TipoDeAmostra = dataGridOrdemCompra.Rows[i].Cells[2].Value.ToString();
                dataOrdem.AnalideSolicitadas = dataGridOrdemCompra.Rows[i].Cells[3].Value.ToString();
                dataOrdem.ValorDoPreparo = dataGridOrdemCompra.Rows[i].Cells[4].Value.ToString();
                dataOrdem.ValorDaAnalise = dataGridOrdemCompra.Rows[i].Cells[5].Value.ToString();
                dataOrdem.ValorTotal = dataGridOrdemCompra.Rows[i].Cells[6].Value.ToString();

                ListaDataOrdem.Add(dataOrdem);
            }
            MessageBox.Show(Gerar(ordem, ListaDataOrdem), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public string Gerar(OrdemServicoDTO Ordem, List<DataGridOrdemServicoDTO> Amostra)
        {
            var caminho = ValidarCaminhoPDF(Ordem.Cliente);

            using (PdfWriter wPdf = new PdfWriter(caminho, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);
                var document = new Document(pdfDocument, PageSize.A4);

                PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
                Style tituloCent = new Style();
                tituloCent.SetFont(font)
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                    .SetVerticalAlignment(VerticalAlignment.TOP);

                Style normalInfo = new Style();
                normalInfo.SetFont(font)
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.CENTER);
                Style normalCent = new Style();
                normalCent.SetFont(font)
                    .SetFontSize(10)
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                Style normalCentGrid = new Style();
                normalCent.SetFont(font)
                    .SetFontSize(10).SetBold()
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                Style normal = new Style();
                normal.SetFont(font).SetFontSize(10)
                    .SetTextAlignment(TextAlignment.LEFT);
                Style minimoInfo = new Style();
                minimoInfo.SetFont(font).SetFontSize(8)
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                Style rodape = new Style();
                rodape.SetFont(font).SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT);


                ImageData imageData = ImageDataFactory.Create(ImageToByteArray(Properties.Resources.LogoPreisser));

                Image image = new Image(imageData).ScaleAbsolute(160, 40);


                float[] colWidths = new float[] { 4, 5, 3 };
                Table tabTitulo = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth();
                tabTitulo.AddCell(image).SetBackgroundColor(ColorConstants.WHITE);
                tabTitulo.AddCell($"\n" + label1.Text).AddStyle(tituloCent);
                tabTitulo.AddCell($"\nNº" + Ordem.Numero).AddStyle(tituloCent);
                document.Add(tabTitulo);


                Table tabEndereco = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabEndereco.AddCell(txt_EnderecoLaboratorio.Text).AddStyle(minimoInfo).SetBorder(Border.NO_BORDER);
                document.Add(tabEndereco);

                Table tabInfoCliente1 = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabInfoCliente1.AddCell(txt_InfoCliente.Text).AddStyle(normalInfo).SetBorder(Border.NO_BORDER);
                document.Add(tabInfoCliente1);

                colWidths = new float[] { 6, 4 };
                Table tabInfoCliente2 = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabInfoCliente2.AddCell("Cliente: " + Ordem.Cliente).AddStyle(normal);
                tabInfoCliente2.AddCell("CNPJ: " + Ordem.CNPJ).AddStyle(normal);
                document.Add(tabInfoCliente2);

                Table tabInfoCliente3 = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabInfoCliente3.AddCell("Endereço: " + Ordem.Endereco).AddStyle(normal);
                document.Add(tabInfoCliente3);

                colWidths = new float[] { 3, 2, 3 };
                Table tabInfoCliente4 = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabInfoCliente4.AddCell("Contato: " + Ordem.Contato).AddStyle(normal);
                tabInfoCliente4.AddCell("Fone: " + Ordem.Fone).AddStyle(normal).SetBorder(Border.NO_BORDER);
                tabInfoCliente4.AddCell("Email: " + Ordem.Email).AddStyle(normal).SetBorder(Border.NO_BORDER);
                document.Add(tabInfoCliente4);

                Table tabInfoCliente5 = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabInfoCliente5.AddCell("Nº ORDEM DE COMPRA CLIENTE: " + Ordem.NumeroOrdemDeCompra).AddStyle(normal);
                document.Add(tabInfoCliente5);


                document.Add(new Paragraph("\n"));



                colWidths = new float[] { 1, 1, 2, 2, 1, 1, 1 };
                Table tableValores = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);

                tableValores.AddCell("Nº Amostra").AddStyle(normalCentGrid);
                tableValores.AddCell("ID Cliente").AddStyle(normalCentGrid);
                tableValores.AddCell("Tipo de Amostra").AddStyle(normalCentGrid);
                tableValores.AddCell("Análises Solicitadas").AddStyle(normalCentGrid);
                tableValores.AddCell("Valor do Preparo (R$)").AddStyle(normalCentGrid);
                tableValores.AddCell("Valor da Análise (R$)").AddStyle(normalCentGrid);
                tableValores.AddCell("Valor Total (R$)").AddStyle(normalCentGrid);


                foreach (DataGridOrdemServicoDTO dataOrdem in Amostra)
                {

                    tableValores.AddCell(dataOrdem.NAmostra).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.IdCliente).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.TipoDeAmostra).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.AnalideSolicitadas).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.ValorDoPreparo).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.ValorDaAnalise).AddStyle(normal);
                    tableValores.AddCell(dataOrdem.ValorTotal).AddStyle(normal);
                }

                document.Add(tableValores);



                Table tabValorTotal = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabValorTotal.AddCell(label7.Text + "  " + Ordem.ValorTotalDaPrestacao).AddStyle(normal).SetTextAlignment(TextAlignment.LEFT).SetBorder(new SolidBorder(ColorConstants.BLACK, 0));
                document.Add(tabValorTotal);

                colWidths = new float[] { 3, 1, 1, 1, 1, 3 };
                Table tabrodape1 = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabrodape1.AddCell("Entregue por:").AddStyle(normal);
                tabrodape1.AddCell("Data da Entrada").AddStyle(normal);
                tabrodape1.AddCell("Hora:").AddStyle(normal);
                tabrodape1.AddCell("Entrega do Resultado:").AddStyle(normal);
                tabrodape1.AddCell("Hora:").AddStyle(normal);
                tabrodape1.AddCell("Responsável pelo Recebimento:").AddStyle(normal);

                document.Add(tabrodape1);

                colWidths = new float[] { 3, 1, 1, 1, 1, 3 };
                Table tabrodape2 = new Table(UnitValue.CreatePercentArray(colWidths)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tabrodape2.AddCell(Ordem.EntreguePor).AddStyle(normal);
                tabrodape2.AddCell(Ordem.DataEntrada).AddStyle(normal);
                tabrodape2.AddCell(Ordem.HoraEntrada).AddStyle(normal);
                tabrodape2.AddCell(Ordem.DataResultado).AddStyle(normal);
                tabrodape2.AddCell(Ordem.HoraResultado).AddStyle(normal);
                tabrodape2.AddCell(Ordem.ReponsavelRecebimento).AddStyle(normal);

                document.Add(tabrodape2);



                Table tableLeganda = new Table(UnitValue.CreatePercentArray(1)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                tableLeganda.AddCell("1ª Via: Cliente  2ª Via: Laboratório  3ª Via: Amostragem").AddStyle(tituloCent).SetBorder(Border.NO_BORDER);
                document.Add(tableLeganda);

                document.Close();
                pdfDocument.Close();
                return "Ordem Gerada!";
            };
        }
        string ValidarCaminhoPDF(string nomeProprietario)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var caminho = $"{desktop}\\OrdemDeServiço";
            var caminhoProprietario = $"{desktop}\\OrdemDeServiço\\{nomeProprietario}";

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

        string MontaNomeArquivoPDF(string caminhoDestino, string proprietarioNome)
        {
            bool loop = true;
            string caminho = "";
            int n = 0;
            while (loop)
            {
                caminho = $"\\ {DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year} - {proprietarioNome} - {n} " + ".pdf";

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
