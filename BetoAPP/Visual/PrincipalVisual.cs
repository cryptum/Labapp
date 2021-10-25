using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BetoAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        public PrincipalVisual(int IdUsuarioLogado, String Usuariologado)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = Usuariologado;
            tipoAnaliseToolStripMenuItem.Visible = false;
            colaboradoresToolStripMenuItem.Visible = false;
            relatórioToolStripMenuItem.Visible = false;

            //AnaliseEntidade analise = new AnaliseEntidade();

            //analise.Solicitantes = new SolicitanteNegocio().ObterUmPorCodigo(1);
            //analise.Local = "Fazenda São Critovão";
            //analise.Municipio = "Frutal";
            //analise.Referencia = "Referência";
            //analise.Cultura = "Cultura";
            //analise.TipoSolicitacao = "Particular";
            //analise.DataCriado = DateTime.Now;

            //List<AmostraEntidade> listaamostra = new List<AmostraEntidade>();
            //AmostraEntidade amostra = new AmostraEntidade();
            //AmostraEntidade amostra2 = new AmostraEntidade();
            //AmostraEntidade amostra3 = new AmostraEntidade();
            //AmostraEntidade amostra4 = new AmostraEntidade();

            //amostra.IdAmostras = 1;
            //amostra.pH = "1";
            //amostra.P = "2";
            //amostra.K = "3";
            //amostra.Ca = "4";
            //amostra.Mg = "5";
            //amostra.Al = "6";
            //amostra.AlH = "7";
            //amostra.SB = "8";
            //amostra.ti = "9";
            //amostra.T = "10";
            //amostra.V = "11";
            //amostra.m = "12";
            //amostra.Zn = "13";
            //amostra.Cu = "14";
            //amostra.Fe = "15";
            //amostra.Mn = "16";
            //amostra.B = "17";
            //amostra.S = "18";
            //amostra.MO = "19";
            //amostra.Argila = "20";
            //amostra.Areia = "21";
            //amostra.Silte = "22";
            //amostra.TonHa = "23";
            //listaamostra.Add(amostra);

            //amostra2.IdAmostras = 2;
            //amostra2.pH = "10";
            //amostra2.P = "20";
            //amostra2.K = "30";
            //amostra2.Ca = "40";
            //amostra2.Mg = "50";
            //amostra2.Al = "60";
            //amostra2.AlH = "70";
            //amostra2.SB = "80";
            //amostra2.ti = "90";
            //amostra2.T = "100";
            //amostra2.V = "110";
            //amostra2.m = "120";
            //amostra2.Zn = "130";
            //amostra2.Cu = "140";
            //amostra2.Fe = "150";
            //amostra2.Mn = "160";
            //amostra2.B = "170";
            //amostra2.S = "180";
            //amostra2.MO = "190";
            //amostra2.Argila = "200";
            //amostra2.Areia = "210";
            //amostra2.Silte = "220";
            //amostra2.TonHa = "230";
            //listaamostra.Add(amostra2);

            //amostra3.IdAmostras = 3;
            //amostra3.pH = "1000";
            //amostra3.P = "200";
            //amostra3.K = "300";
            //amostra3.Ca = "400";
            //amostra3.Mg = "500";
            //amostra3.Al = "600";
            //amostra3.AlH = "700";
            //amostra3.SB = "800";
            //amostra3.ti = "900";
            //amostra3.T = "1000";
            //amostra3.V = "1100";
            //amostra3.m = "1200";
            //amostra3.Zn = "1300";
            //amostra3.Cu = "1400";
            //amostra3.Fe = "1500";
            //amostra3.Mn = "1600";
            //amostra3.B = "1700";
            //amostra3.S = "1800";
            //amostra3.MO = "190";
            //amostra3.Argila = "2000";
            //amostra3.Areia = "2100";
            //amostra3.Silte = "220";
            //amostra3.TonHa = "230";
            //listaamostra.Add(amostra3);

            //amostra4.IdAmostras = 4;
            //amostra4.pH = "01";
            //amostra4.P = "02";
            //amostra4.K = "03";
            //amostra4.Ca = "04";
            //amostra4.Mg = "05";
            //amostra4.Al = "06";
            //amostra4.AlH = "07";
            //amostra4.SB = "08";
            //amostra4.ti = "09";
            //amostra4.T = "010";
            //amostra4.V = "011";
            //amostra4.m = "012";
            //amostra4.Zn = "013";
            //amostra4.Cu = "014";
            //amostra4.Fe = "015";
            //amostra4.Mn = "016";
            //amostra4.B = "017";
            //amostra4.S = "018";
            //amostra4.MO = "019";
            //amostra4.Argila = "020";
            //amostra4.Areia = "021";
            //amostra4.Silte = "22";
            //amostra4.TonHa = "23";
            //listaamostra.Add(amostra4);

            //new GerarPDF().Gerar(analise, listaamostra);
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void analiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliseVisual View = AnaliseVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitanteVisual View = SolicitanteVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVisual View = RelatorioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioVisual View = UsuarioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void culturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CulturaVisual View = CulturaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void referenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenciaVisual View = ReferenciaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoAnaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnaliseVisual View = TipoAnaliseVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoSolicitacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSolicitacaoVisual View = TipoSolicitacaoVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliseEntidade analise = new AnaliseEntidade();

            analise.Solicitantes = new SolicitanteNegocio().ObterUmPorCodigo(1);
            analise.Local = "Fazenda louca";
            analise.Municipio = "São Charlis";
            analise.Referencia = "referencia";
            analise.Cultura = "cultura";
            analise.TipoSolicitacao = "particular";
            analise.DataCriado = DateTime.Now;

            List<AmostraEntidade> listaamostra = new List<AmostraEntidade>();
            AmostraEntidade amostra = new AmostraEntidade();
            AmostraEntidade amostra2 = new AmostraEntidade();
            AmostraEntidade amostra3 = new AmostraEntidade();
            AmostraEntidade amostra4 = new AmostraEntidade();

            amostra.IdAmostras = 1;
            amostra.pH = "1";
            amostra.P = "2";
            amostra.K = "3";
            amostra.Ca = "4";
            amostra.Mg = "5";
            amostra.Al = "6";
            amostra.AlH = "7";
            amostra.SB = "8";
            amostra.ti = "9";
            amostra.T = "10";
            amostra.V = "11";
            amostra.m = "12";
            amostra.Zn = "13";
            amostra.Cu = "14";
            amostra.Fe = "15";
            amostra.Mn = "16";
            amostra.B = "17";
            amostra.S = "18";
            amostra.MO = "19";
            amostra.Argila = "20";
            amostra.Areia = "21";
            amostra.Silte = "22";
            amostra.TonHa = "23";
            listaamostra.Add(amostra);

            amostra2.IdAmostras = 2;
            amostra2.pH = "1";
            amostra2.P = "2";
            amostra2.K = "3";
            amostra2.Ca = "4";
            amostra2.Mg = "5";
            amostra2.Al = "6";
            amostra2.AlH = "7";
            amostra2.SB = "8";
            amostra2.ti = "9";
            amostra2.T = "10";
            amostra2.V = "11";
            amostra2.m = "12";
            amostra2.Zn = "13";
            amostra2.Cu = "14";
            amostra2.Fe = "15";
            amostra2.Mn = "16";
            amostra2.B = "17";
            amostra2.S = "18";
            amostra2.MO = "19";
            amostra2.Argila = "20";
            amostra2.Areia = "21";
            amostra2.Silte = "22";
            amostra2.TonHa = "23";
            listaamostra.Add(amostra2);

            amostra3.IdAmostras = 3;
            amostra3.pH = "1";
            amostra3.P = "2";
            amostra3.K = "3";
            amostra3.Ca = "4";
            amostra3.Mg = "5";
            amostra3.Al = "6";
            amostra3.AlH = "7";
            amostra3.SB = "8";
            amostra3.ti = "9";
            amostra3.T = "10";
            amostra3.V = "11";
            amostra3.m = "12";
            amostra3.Zn = "13";
            amostra3.Cu = "14";
            amostra3.Fe = "15";
            amostra3.Mn = "16";
            amostra3.B = "17";
            amostra3.S = "18";
            amostra3.MO = "19";
            amostra3.Argila = "20";
            amostra3.Areia = "21";
            amostra3.Silte = "22";
            amostra3.TonHa = "23";
            listaamostra.Add(amostra3);

            amostra4.IdAmostras = 4;
            amostra4.pH = "1";
            amostra4.P = "2";
            amostra4.K = "3";
            amostra4.Ca = "4";
            amostra4.Mg = "5";
            amostra4.Al = "6";
            amostra4.AlH = "7";
            amostra4.SB = "8";
            amostra4.ti = "9";
            amostra4.T = "10";
            amostra4.V = "11";
            amostra4.m = "12";
            amostra4.Zn = "13";
            amostra4.Cu = "14";
            amostra4.Fe = "15";
            amostra4.Mn = "16";
            amostra4.B = "17";
            amostra4.S = "18";
            amostra4.MO = "19";
            amostra4.Argila = "20";
            amostra4.Areia = "21";
            amostra4.Silte = "22";
            amostra4.TonHa = "23";
            listaamostra.Add(amostra4);

            new GerarPDF().Gerar(analise, listaamostra);
        }
    }
}
