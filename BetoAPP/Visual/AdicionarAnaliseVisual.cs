using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarAnaliseVisual : Form
    {
        public int GlobalIdSolicitante { get; set; }
        public int GlobalIdAnalise { get; set; }

        public AdicionarAnaliseVisual(string titulo, int idAnalise, string nomeSolicitante)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            GlobalIdAnalise = idAnalise;

            CriarAnaliseOuAdicionarAmostra();
        }

        void CriarAnaliseOuAdicionarAmostra()
        {
            if (txtTitulo.Text == "Adicionar Amostras")
            {
                //Adicionar Amostra
                tabControl1.TabPages.Remove(tabSolicitante);
            }
            else
            {
                //Criar Análise
                tabControl1.TabPages.Remove(tabBasico);
                tabControl1.TabPages.Remove(tabCompleta);
                tabControl1.TabPages.Remove(tabFisica);
                tabControl1.TabPages.Remove(tabOpicional);
                txtNomeAnalise.Focus();
            }
        }

        private void AdicionarAnaliseVisual_Load(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "Adicionar Amostras")
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
            }

            for (int i = 1; i < 5; i++)
            {
                dataGridBasica.Rows.Add("");
                dataGridCompleta.Rows.Add("");
                dataGridFisica.Rows.Add("");
                dataGridOpcional.Rows.Add("");
            }

            var listaTipoAnalise = new TipoAnaliseNegocio().ObterTodosParaAdicinarAmostra();

            for (int i = 0; i < listaTipoAnalise.Count(); i++)
            {
                cbx_Nome_Amostra_1.Items.Add(listaTipoAnalise[i].Nome);
                cbx_Nome_Amostra_2.Items.Add(listaTipoAnalise[i].Nome);
                cbx_Nome_Amostra_3.Items.Add(listaTipoAnalise[i].Nome);
                cbx_Nome_Amostra_4.Items.Add(listaTipoAnalise[i].Nome);
            }

            if (txtTitulo.Text == "Adicionar Amostras")
            {
                var analise = new AnaliseNegocio().ObterUmPorCodigo(GlobalIdAnalise);

                cbx_Nome_Amostra_1.SelectedItem = analise.NomeAmostra1;
                cbx_Nome_Amostra_2.SelectedItem = analise.NomeAmostra2;
                cbx_Nome_Amostra_3.SelectedItem = analise.NomeAmostra3;
                cbx_Nome_Amostra_4.SelectedItem = analise.NomeAmostra4;
            }

        }



        //private void SetLoading(bool displayLoader)
        //{
        //    if (displayLoader)
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = true;
        //            pcbCarregar.BringToFront();
        //            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        //        });
        //    }
        //    else
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = false;
        //            pcbCarregar.SendToBack();
        //            this.Cursor = System.Windows.Forms.Cursors.Default;
        //        });
        //    }
        //}

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Solicitante_DoubleClick(object sender, EventArgs e)
        {
            FormsSelecionarSolicitante();
        }

        private void txt_Solicitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormsSelecionarSolicitante();
            }
        }

        void FormsSelecionarSolicitante()
        {
            using (var form = new BuscarSolicitanteVisual())
            {
                form.ShowDialog();

                if (form.NomeSolicitante != null)
                {
                    txt_Solicitante.Text = form.NomeSolicitante;
                    this.GlobalIdSolicitante = form.IdSolicitante;
                    var locais = new LocalNegocio().ObterUmPorCodigoSolicitante(this.GlobalIdSolicitante);

                    for (int i = 0; i < locais.Count(); i++)
                    {
                        cbxFazenda.Items.Add(locais[i].Fazenda);
                    }
                }
            }
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (txtTitulo.Text)
                {
                    case "Criar Análise":

                        var idAnaliseSalva = new AnaliseNegocio().Salvar(
                        txtNomeAnalise.Text.Trim(),
                        this.GlobalIdSolicitante,
                        cbxFazenda.Text,
                        cbxReferencia.Text,
                        cbxCultura.Text,
                        cbxSolicitacao.Text,
                        cbx_Nome_Amostra_1.Text,
                        cbx_Nome_Amostra_2.Text,
                        cbx_Nome_Amostra_3.Text,
                        cbx_Nome_Amostra_4.Text);

                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        break;

                    case "Adicionar Amostras":

                        AnaliseEntidade analiseSalva = new AnaliseNegocio().ObterUmPorCodigo(GlobalIdAnalise);

                        AnaliseEntidade analiseComNomesDeAmostras = analiseSalva;
                        analiseComNomesDeAmostras.NomeAmostra1 = cbx_Nome_Amostra_1.Text;
                        analiseComNomesDeAmostras.NomeAmostra2 = cbx_Nome_Amostra_2.Text;
                        analiseComNomesDeAmostras.NomeAmostra3 = cbx_Nome_Amostra_3.Text;
                        analiseComNomesDeAmostras.NomeAmostra4 = cbx_Nome_Amostra_4.Text;
                        analiseComNomesDeAmostras.Completa = true;

                        new AnaliseNegocio().EditarNomesDasAmostras(analiseComNomesDeAmostras);

                        List<AmostraEntidade> AmostraSalva = new List<AmostraEntidade>();

                        for (int i = 0; i < 4; i++)
                        {
                            AmostraEntidade amostra;

                            amostra = PreencherAmostra(
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[2].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[3].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[4].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[5].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[6].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[7].Value),
                                    Convert.ToDouble(dataGridBasica.Rows[i].Cells[8].Value),


                                    Convert.ToDouble(dataGridCompleta.Rows[i].Cells[2].Value),
                                    Convert.ToDouble(dataGridCompleta.Rows[i].Cells[3].Value),
                                    Convert.ToDouble(dataGridCompleta.Rows[i].Cells[4].Value),
                                    Convert.ToDouble(dataGridCompleta.Rows[i].Cells[5].Value),


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





                            switch (i)
                            {
                                case 0:
                                    {
                                        amostra.NomeAmostra = cbx_Nome_Amostra_1.Text; break;
                                    }
                                case 1:
                                    {
                                        amostra.NomeAmostra = cbx_Nome_Amostra_2.Text; break;
                                    }
                                case 2:
                                    {
                                        amostra.NomeAmostra = cbx_Nome_Amostra_3.Text; break;
                                    }
                                case 3:
                                    {
                                        amostra.NomeAmostra = cbx_Nome_Amostra_4.Text; break;
                                    }
                                default:
                                    break;
                            }

                            new AmostraNegocio().Salvar(amostra, analiseComNomesDeAmostras.IdAnalise);
                            AmostraSalva.Add(amostra);
                        }

                        var result = new GerarPDF().Gerar(analiseSalva, AmostraSalva);
                        MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private AmostraEntidade PreencherAmostra(
            double pH,
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
            amostra.P = new ProcessamentoConcentracao().ProcessarFosforo(P).ToString();

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

            double sb = Math.Round(k + Ca + mg, 2);
            amostra.SB = sb.ToString();

            double ti = Math.Round(al + sb, 2);
            amostra.ti = ti.ToString();

            double T = Math.Round(alh + sb, 2);
            amostra.T = T.ToString();


            amostra.V = Math.Round(((100 * sb) / T), 2).ToString();
            amostra.m = Math.Round(((100 * al) / ti), 2).ToString();
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
            amostra.TonHa = Math.Round(((0.6 * T - sb) / 10), 2).ToString();

            return amostra;
        }

        private void cbx_Nome_Amostra_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[0].Cells[1].Value = cbx_Nome_Amostra_1.Text;
            dataGridCompleta.Rows[0].Cells[1].Value = cbx_Nome_Amostra_1.Text;
            dataGridFisica.Rows[0].Cells[1].Value = cbx_Nome_Amostra_1.Text;
            dataGridOpcional.Rows[0].Cells[1].Value = cbx_Nome_Amostra_1.Text;
        }

        private void cbx_Nome_Amostra_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[1].Cells[1].Value = cbx_Nome_Amostra_2.Text;
            dataGridCompleta.Rows[1].Cells[1].Value = cbx_Nome_Amostra_2.Text;
            dataGridFisica.Rows[1].Cells[1].Value = cbx_Nome_Amostra_2.Text;
            dataGridOpcional.Rows[1].Cells[1].Value = cbx_Nome_Amostra_2.Text;
        }

        private void cbx_Nome_Amostra_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[2].Cells[1].Value = cbx_Nome_Amostra_3.Text;
            dataGridCompleta.Rows[2].Cells[1].Value = cbx_Nome_Amostra_3.Text;
            dataGridFisica.Rows[2].Cells[1].Value = cbx_Nome_Amostra_3.Text;
            dataGridOpcional.Rows[2].Cells[1].Value = cbx_Nome_Amostra_3.Text;
        }

        private void cbx_Nome_Amostra_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[3].Cells[1].Value = cbx_Nome_Amostra_4.Text;
            dataGridCompleta.Rows[3].Cells[1].Value = cbx_Nome_Amostra_4.Text;
            dataGridFisica.Rows[3].Cells[1].Value = cbx_Nome_Amostra_4.Text;
            dataGridOpcional.Rows[3].Cells[1].Value = cbx_Nome_Amostra_4.Text;
        }
    }
}
