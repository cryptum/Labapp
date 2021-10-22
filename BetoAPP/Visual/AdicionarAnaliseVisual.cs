﻿using BetoAPP.Util;
using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarAnaliseVisual : Form
    {
        public SolicitanteEntidade GlobalSolicitante { get; set; }
        public AdicionarAnaliseVisual(string titulo, int idAmostra, string nomeSolicitante)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pcbCarregar.Visible = true;
                    pcbCarregar.BringToFront();
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pcbCarregar.Visible = false;
                    pcbCarregar.SendToBack();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Solicitante_DoubleClick(object sender, EventArgs e)
        {
            using (var form = new BuscarSolicitanteVisual())
            {
                form.ShowDialog();

                if (form.NomeSolicitante != null)
                {
                    txt_Solicitante.Text = form.NomeSolicitante;
                    this.GlobalSolicitante = RecuperarSolicitante(Convert.ToInt32(form.IdSolicitante));
                    var locais = new LocalNegocio().ObterUmPorCodigoSolicitante(this.GlobalSolicitante.IdSolicitante);

                    for (int i = 0; i < locais.Count(); i++)
                    {
                        cbxFazenda.Items.Add(locais[i].Fazenda);
                    }
                }
            }
        }

        private SolicitanteEntidade RecuperarSolicitante(int idSolicitante)
        {
            return new SolicitanteNegocio().ObterUmPorCodigo(idSolicitante);
        }

        private void AdicionarAnaliseVisual_Load(object sender, EventArgs e)
        {
            var nomesReferencias = new ReferenciaNegocio().ObterTodos();

            for (int i = 0; i < nomesReferencias.Count(); i++)
            {
                cbxReferencia.Items.Add(nomesReferencias[i].Nome);
            }

            var nomesCultura = new CulturaNegocio().ObterTodos();
            for (int i = 0; i < nomesCultura.Count(); i++)
            {
                cbxCultura.Items.Add(nomesCultura[i].Nome);
            }

            var nomesSolicitacao = new TipoSolicitacaoNegocio().ObterTodos();
            for (int i = 0; i < nomesSolicitacao.Count(); i++)
            {
                cbxSolicitacao.Items.Add(nomesSolicitacao[i].Nome);
            }

            for (int i = 1; i < 5; i++)
            {
                dataGridPrincipal.Rows.Add("", "Nº " + i);
                dataGridAdicional.Rows.Add("", "Nº " + i);
                dataGridFisica.Rows.Add("", "Nº " + i);
                dataGridOpcional.Rows.Add("", "Nº " + i);
            }

            //((Control)this.tabPrincipal).Enabled = false;
            //((Control)this.tabAdicional).Enabled = false;
            //((Control)this.tabFisica).Enabled = false;
            //((Control)this.tabOpicional).Enabled = false;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txt_Solicitante.Text == null ||
                cbxFazenda.SelectedItem == null ||
                cbxReferencia.SelectedItem == null ||
                cbxCultura.SelectedItem == null ||
                cbxSolicitacao.SelectedItem == null)
            {
                MessageBox.Show(Mensagem.AnaliseCamposVazios.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ((Control)this.tabPrincipal).Enabled = true;
                ((Control)this.tabAdicional).Enabled = true;
                ((Control)this.tabFisica).Enabled = true;
                ((Control)this.tabOpicional).Enabled = true;
                ((Control)this.tabSolicitante).Enabled = false;
                tabControl1.SelectedTab = tabPrincipal;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInput = new Thread(x =>
                {
                    SetLoading(true);

                    var idAnaliseSalva = new AnaliseNegocio().Salvar(
                    this.GlobalSolicitante,
                    cbxFazenda.Text,
                    cbxReferencia.Text,
                    cbxCultura.Text,
                    cbxSolicitacao.Text);

                    AnaliseEntidade analiseSalva = new AnaliseNegocio().ObterUmPorCodigo(idAnaliseSalva);
                    List<AmostraEntidade> AmostraSalva = new List<AmostraEntidade>();

                    for (int i = 0; i < 4; i++)
                    {
                        AmostraEntidade amostra;

                        amostra = PreencherAmostra(
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[2].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[4].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[5].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[6].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[7].Value),
                                Convert.ToDouble(dataGridPrincipal.Rows[i].Cells[8].Value),


                                Convert.ToDouble(dataGridAdicional.Rows[i].Cells[2].Value),
                                Convert.ToDouble(dataGridAdicional.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridAdicional.Rows[i].Cells[4].Value),
                                Convert.ToDouble(dataGridAdicional.Rows[i].Cells[5].Value),
                                Convert.ToDouble(dataGridAdicional.Rows[i].Cells[6].Value),


                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[2].Value),
                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[4].Value),
                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[5].Value),
                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[6].Value),
                                Convert.ToDouble(dataGridFisica.Rows[i].Cells[7].Value),


                                Convert.ToDouble(dataGridOpcional.Rows[i].Cells[2].Value),
                                Convert.ToDouble(dataGridOpcional.Rows[i].Cells[3].Value),
                                Convert.ToDouble(dataGridOpcional.Rows[i].Cells[4].Value)

                                );

                        amostra.Analises = analiseSalva;

                        new AmostraNegocio().Salvar(amostra);
                        AmostraSalva.Add(amostra);
                    }

                    var result = new GerarPDF().Gerar(analiseSalva, AmostraSalva);
                    MessageBox.Show(result);

                    SetLoading(false);
                }
                    );
                threadInput.Start();

            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private AmostraEntidade PreencherAmostra(
            double pH,
            double DiluicaoP,
            double P,
            double K,
            double Ca,
            double Mg,
            double Al,
            double AlH,
            double Zn,
            double Cu,
            double Fe,
            double Mn,
            double ArgilaInicial,
            double ArgilaFinal,
            double AreiaInicial,
            double AreiaFinal,
            double SilteInicial,
            double SilteFinal,
            double B,
            double S,
            double MO
            )
        {
            AmostraEntidade amostra = new AmostraEntidade();
            amostra.pH = new ProcessamentoConcentracao().ProcessarPH(pH).ToString();
            amostra.P = new ProcessamentoConcentracao().ProcessarFosforo(P, DiluicaoP).ToString();

            double k = new ProcessamentoConcentracao().ProcessarPotassio(K);
            amostra.K = k.ToString();

            double ca = new ProcessamentoConcentracao().ProcessarCalcio(Ca);
            amostra.Ca = ca.ToString();

            double mg = new ProcessamentoConcentracao().ProcessarMagnesio(Mg);
            amostra.Mg = mg.ToString();

            double al = new ProcessamentoConcentracao().ProcessarAluminio(Al);
            amostra.Al = al.ToString();

            double alh = new ProcessamentoConcentracao().ProcessarAcidoPotencial(AlH);
            amostra.AlH = alh.ToString();

            double sb = k + Ca + mg;
            amostra.SB = sb.ToString();

            double ti = al + sb;
            amostra.ti = ti.ToString();

            double T = alh +  sb;
            amostra.T = T.ToString();


            amostra.V = ((100 * sb) / T).ToString();
            amostra.m = ((100 * al) / ti).ToString();
            amostra.Zn = new ProcessamentoConcentracao().ProcessarZinco(Zn).ToString();
            amostra.Cu = new ProcessamentoConcentracao().ProcessarCobre(Cu).ToString();
            amostra.Fe = new ProcessamentoConcentracao().ProcessarFerro(Fe).ToString();
            amostra.Mn = new ProcessamentoConcentracao().ProcessarManganes(Mn).ToString();
            amostra.B = new ProcessamentoConcentracao().ProcessarBoro(B).ToString();
            amostra.S = new ProcessamentoConcentracao().ProcessarEnxofre(S).ToString();
            amostra.MO = new ProcessamentoConcentracao().ProcessarMateriaOrganica(MO).ToString();
            amostra.Argila = new ProcessamentoConcentracao().ProcessarArgila(ArgilaInicial, ArgilaFinal).ToString();
            amostra.Areia = new ProcessamentoConcentracao().ProcessarAreia(AreiaInicial, AreiaFinal).ToString();
            amostra.Silte = new ProcessamentoConcentracao().ProcessarSilte(SilteInicial, SilteFinal).ToString();
            amostra.TonHa = ((0.6 * T - sb) / 10).ToString();

            return amostra;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
