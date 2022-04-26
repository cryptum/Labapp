using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace LabAPP.Visual
{
    public partial class AdicionarAnaliseVisual : Form
    {
        public int GlobalIdProprietario { get; set; }
        public int GlobalIdAnalise { get; set; }
        Environments GlobalEnv;

        public AdicionarAnaliseVisual(Environments env, string titulo, int idAnalise, string nomeProprietario)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            GlobalIdAnalise = idAnalise;
            GlobalEnv = env;

            switch (env)
            {
                case Environments.preisser:
                    tabControl1.TabPages.Remove(tabFisica);
                    break;
                case Environments.preisserInMemory:
                    tabControl1.TabPages.Remove(tabFisica);
                    break;
                default:
                    break;
            }

            CriarAnaliseOuAdicionarAmostra();
        }

        void CriarAnaliseOuAdicionarAmostra()
        {
            if (txtTitulo.Text == "Adicionar Amostras")
            {
                //Adicionar Amostra
                tabControl1.TabPages.Remove(tabSolicitação);
            }
            else
            {
                //Criar Análise
                tabControl1.TabPages.Remove(tabBasico);
                tabControl1.TabPages.Remove(tabCompleta);
                tabControl1.TabPages.Remove(tabFisica);
                tabControl1.TabPages.Remove(tabOpicional);
                txt_NumeroLaudo.Focus();
            }
        }

        private void AdicionarAnaliseVisual_Load(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "Adicionar Amostras")
            {
                var nomesTipoAnalise = new TipoAnaliseNegocio().ObterTodos();

                for (int i = 0; i < nomesTipoAnalise.Count(); i++)
                {
                    cbx_TipoAnalise.Items.Add(nomesTipoAnalise[i].Nome);
                }

                var nomesCultura = new CulturaNegocio().ObterTodos();
                for (int i = 0; i < nomesCultura.Count(); i++)
                {
                    cbx_Cultura.Items.Add(nomesCultura[i].Nome);
                }

                var nomesSolicitacao = new ConvenioNegocio().ObterTodos();
                for (int i = 0; i < nomesSolicitacao.Count(); i++)
                {
                    cbx_Solicitacao.Items.Add(nomesSolicitacao[i].Nome);
                }
            }

            for (int i = 1; i < 5; i++)
            {
                dataGridBasica.Rows.Add("");
                dataGridCompleta.Rows.Add("");
                dataGridFisica.Rows.Add("");
                dataGridOpcional.Rows.Add("");
            }

            if (txtTitulo.Text == "Adicionar Amostras")
            {
                var analise = new AnaliseNegocio().ObterUmPorCodigo(GlobalIdAnalise);

                //Nome_Amostra_2.Text = analise.NomeAmostra2;
                //Nome_Amostra_3.Text = analise.NomeAmostra3;
                //Nome_Amostra_1.Text = analise.NomeAmostra1;
                //Nome_Amostra_4.Text = analise.NomeAmostra4;
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


        void FormsSelecionarProprietario()
        {
            using (var form = new BuscarProprietarioVisual())
            {
                form.ShowDialog();

                if (form.NomeProprietario != null)
                {
                    txt_Proprietario.Text = form.NomeProprietario;
                    this.GlobalIdProprietario = form.IdProprietario;
                    var locais = new FazendaNegocio().ObterUmPorCodigoDeProprietario(this.GlobalIdProprietario);

                    for (int i = 0; i < locais.Count(); i++)
                    {
                        cbx_Fazenda.Items.Add(locais[i].Fazenda);
                    }
                }
            }
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    switch (txtTitulo.Text)
            //    {
            //        case "Criar Análise":

            //            var idAnaliseSalva = new AnaliseNegocio().Salvar(
            //            txt_NumeroLaudo.Text.Trim(),
            //            this.GlobalIdProprietario,
            //            cbx_Fazenda.Text,
            //            cbx_TipoAnalise.Text,
            //            cbx_Cultura.Text,
            //            cbx_Solicitacao.Text,
            //            Nome_Amostra_1.Text,
            //            Numero_Amostra_1.Text,
            //            Nome_Amostra_2.Text,
            //            Numero_Amostra_2.Text,
            //            Nome_Amostra_3.Text,
            //            Numero_Amostra_3.Text,
            //            Nome_Amostra_4.Text,
            //            Numero_Amostra_4.Text);

            //            MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //            break;

            //        case "Adicionar Amostras":

            //            AnaliseEntidade analiseSalva = new AnaliseNegocio().ObterUmPorCodigo(GlobalIdAnalise);

            //            AnaliseEntidade analiseComNomesDeAmostras = analiseSalva;
            //            analiseComNomesDeAmostras.NomeAmostra1 = Nome_Amostra_1.Text;
            //            analiseComNomesDeAmostras.NumeroAmostra1 = Numero_Amostra_1.Text;
            //            analiseComNomesDeAmostras.NomeAmostra2 = Nome_Amostra_2.Text;
            //            analiseComNomesDeAmostras.NumeroAmostra2 = Numero_Amostra_2.Text;
            //            analiseComNomesDeAmostras.NomeAmostra3 = Nome_Amostra_3.Text;
            //            analiseComNomesDeAmostras.NumeroAmostra3 = Numero_Amostra_3.Text;
            //            analiseComNomesDeAmostras.NomeAmostra4 = Nome_Amostra_4.Text;
            //            analiseComNomesDeAmostras.NumeroAmostra4 = Numero_Amostra_4.Text;
            //            analiseComNomesDeAmostras.Finalizada = true;

            //            new AnaliseNegocio().EditarNomesDasAmostras(analiseComNomesDeAmostras);

            //            List<AmostraEntidade> AmostraSalva = new List<AmostraEntidade>();

            //            for (int i = 0; i < 4; i++)
            //            {
            //                AmostraEntidade amostra = new();

            //                amostra = PreencherAmostra(
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[2].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[3].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[4].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[5].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[6].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[7].Value),
            //                        Convert.ToDouble(dataGridBasica.Rows[i].Cells[8].Value),


            //                        Convert.ToDouble(dataGridCompleta.Rows[i].Cells[2].Value),
            //                        Convert.ToDouble(dataGridCompleta.Rows[i].Cells[3].Value),
            //                        Convert.ToDouble(dataGridCompleta.Rows[i].Cells[4].Value),
            //                        Convert.ToDouble(dataGridCompleta.Rows[i].Cells[5].Value),


            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[2].Value),
            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[3].Value),
            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[4].Value),
            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[5].Value),
            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[6].Value),
            //                        Convert.ToDouble(dataGridFisica.Rows[i].Cells[7].Value),


            //                        Convert.ToDouble(dataGridOpcional.Rows[i].Cells[2].Value),
            //                        Convert.ToDouble(dataGridOpcional.Rows[i].Cells[3].Value),
            //                        Convert.ToDouble(dataGridOpcional.Rows[i].Cells[4].Value)

            //                        );
            //                amostra.Analises = analiseSalva;





            //                switch (i)
            //                {
            //                    case 0:
            //                        {
            //                            amostra.NomeAmostra = Nome_Amostra_1.Text; break;
            //                        }
            //                    case 1:
            //                        {
            //                            amostra.NomeAmostra = Nome_Amostra_2.Text; break;
            //                        }
            //                    case 2:
            //                        {
            //                            amostra.NomeAmostra = Nome_Amostra_3.Text; break;
            //                        }
            //                    case 3:
            //                        {
            //                            amostra.NomeAmostra = Nome_Amostra_4.Text; break;
            //                        }
            //                    default:
            //                        break;
            //                }

            //                new AmostraNegocio().Salvar(amostra, analiseComNomesDeAmostras.IdAnalise);
            //                AmostraSalva.Add(amostra);
            //            }

            //            var result = new GerarPDF().Gerar(analiseSalva, AmostraSalva);
            //            MessageBox.Show(result, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            break;
            //        default:
            //            break;
            //    }

            //    this.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
            //amostra.Basica = true;
            //amostra.pH = new MotorDeCalculo().ProcessarPH(pH).ToString();
            //amostra.P = new MotorDeCalculo().ProcessarFosforo(P).ToString();

            //double k = new MotorDeCalculo().ProcessarPotassio(K);
            //amostra.K = k.ToString();

            //double ca = new MotorDeCalculo().ProcessarCalcio(Ca);
            //amostra.Ca = ca.ToString();

            //double mg = new MotorDeCalculo().ProcessarMagnesio(Mg);
            //amostra.Mg = mg.ToString();

            //double al = new MotorDeCalculo().ProcessarAluminio(Al);
            //amostra.Al = al.ToString();

            //double alh = new MotorDeCalculo().ProcessarAcidoPotencial(AlH);
            //amostra.AlH = alh.ToString();

            //double sb = Math.Round(k + Ca + mg, 2);
            //amostra.SB = sb.ToString();

            //double ti = Math.Round(al + sb, 2);
            //amostra.ti = ti.ToString();

            //double T = Math.Round(alh + sb, 2);
            //amostra.T = T.ToString();

            //amostra.V = Math.Round(((100 * sb) / T), 2).ToString();
            //amostra.m = Math.Round(((100 * al) / ti), 2).ToString();


            //amostra.Zn = Zn == 0 ? "N/S" : new MotorDeCalculo().ProcessarZinco(Zn).ToString();
            //amostra.Cu = Cu == 0 ? "N/S" : new MotorDeCalculo().ProcessarCobre(Cu).ToString();
            //amostra.Fe = Cu == 0 ? "N/S" : new MotorDeCalculo().ProcessarFerro(Fe).ToString();
            //amostra.Mn = Mn == 0 ? "N/S" : new MotorDeCalculo().ProcessarManganes(Mn).ToString();

            //amostra.Completa = Zn == 0 && Cu == 0 && Fe == 0 && Mn == 0 ? false : true;


            //amostra.Argila = ArgilaInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarArgila(ArgilaInicial, ArgilaFinal).ToString();
            //amostra.Areia = AreiaInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarAreia(AreiaInicial, AreiaFinal).ToString();
            //amostra.Silte = SilteInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarSilte(SilteInicial, SilteFinal).ToString();

            //amostra.Fisica = ArgilaInicial == 0 && ArgilaFinal == 0 && AreiaInicial == 0 && AreiaFinal == 0 && SilteInicial == 0;

            //amostra.S = S == 0 ? "N/S" : new MotorDeCalculo().ProcessarEnxofre(S).ToString();
            //amostra.B = B == 0 ? "N/S" : new MotorDeCalculo().ProcessarBoro(B).ToString();
            //amostra.MO = MO == 0 ? "N/S" : new MotorDeCalculo().ProcessarMateriaOrganica(MO).ToString();

            //amostra.Opcional = S == 0 && B == 0 && MO == 0 ? false : true;


            //amostra.TonHa = Math.Round(((0.6 * T - sb) / 10), 2).ToString();

            return amostra;
        }

        private void cbx_Nome_Amostra_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[0].Cells[1].Value = Nome_Amostra_1.Text;
            dataGridCompleta.Rows[0].Cells[1].Value = Nome_Amostra_1.Text;
            dataGridFisica.Rows[0].Cells[1].Value = Nome_Amostra_1.Text;
            dataGridOpcional.Rows[0].Cells[1].Value = Nome_Amostra_1.Text;
        }

        private void cbx_Nome_Amostra_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[1].Cells[1].Value = Nome_Amostra_2.Text;
            dataGridCompleta.Rows[1].Cells[1].Value = Nome_Amostra_2.Text;
            dataGridFisica.Rows[1].Cells[1].Value = Nome_Amostra_2.Text;
            dataGridOpcional.Rows[1].Cells[1].Value = Nome_Amostra_2.Text;
        }

        private void cbx_Nome_Amostra_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[2].Cells[1].Value = Nome_Amostra_3.Text;
            dataGridCompleta.Rows[2].Cells[1].Value = Nome_Amostra_3.Text;
            dataGridFisica.Rows[2].Cells[1].Value = Nome_Amostra_3.Text;
            dataGridOpcional.Rows[2].Cells[1].Value = Nome_Amostra_3.Text;
        }

        private void cbx_Nome_Amostra_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[3].Cells[1].Value = Nome_Amostra_4.Text;
            dataGridCompleta.Rows[3].Cells[1].Value = Nome_Amostra_4.Text;
            dataGridFisica.Rows[3].Cells[1].Value = Nome_Amostra_4.Text;
            dataGridOpcional.Rows[3].Cells[1].Value = Nome_Amostra_4.Text;
        }

        private void btn_Salvar_MouseHover(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void btn_Cancelar_MouseHover(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void btn_Salvar_MouseEnter(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            txt_NumeroLaudo.Focus();
        }

        private void txt_Proprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormsSelecionarProprietario();
            }
        }

        private void txt_Proprietario_DoubleClick(object sender, EventArgs e)
        {
            FormsSelecionarProprietario();
        }

        private void Amostra_1_TextChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[0].Cells[1].Value = $"{Numero_Amostra_1.Text} - {Nome_Amostra_1.Text}";
            dataGridCompleta.Rows[0].Cells[1].Value = $"{Numero_Amostra_1.Text} - {Nome_Amostra_1.Text}";
            dataGridFisica.Rows[0].Cells[1].Value = $"{Numero_Amostra_1.Text} - {Nome_Amostra_1.Text}";
            dataGridOpcional.Rows[0].Cells[1].Value = $"{Numero_Amostra_1.Text} - {Nome_Amostra_1.Text}";
        }

        private void Amostra_2_TextChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[1].Cells[1].Value = $"{Numero_Amostra_2.Text} - {Nome_Amostra_2.Text}";
            dataGridCompleta.Rows[1].Cells[1].Value = $"{Numero_Amostra_2.Text} - {Nome_Amostra_2.Text}";
            dataGridFisica.Rows[1].Cells[1].Value = $"{Numero_Amostra_2.Text} - {Nome_Amostra_2.Text}";
            dataGridOpcional.Rows[1].Cells[1].Value = $"{Numero_Amostra_2.Text} - {Nome_Amostra_2.Text}";
        }

        private void Amostra_3_TextChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[2].Cells[1].Value = $"{Numero_Amostra_3.Text} - {Nome_Amostra_3.Text}";
            dataGridCompleta.Rows[2].Cells[1].Value = $"{Numero_Amostra_3.Text} - {Nome_Amostra_3.Text}";
            dataGridFisica.Rows[2].Cells[1].Value = $"{Numero_Amostra_3.Text} - {Nome_Amostra_3.Text}";
            dataGridOpcional.Rows[2].Cells[1].Value = $"{Numero_Amostra_3.Text} - {Nome_Amostra_3.Text}";
        }

        private void Amostra_4_TextChanged(object sender, EventArgs e)
        {
            dataGridBasica.Rows[2].Cells[1].Value = $"{Numero_Amostra_4.Text} - {Nome_Amostra_4.Text}";
            dataGridCompleta.Rows[2].Cells[1].Value = $"{Numero_Amostra_4.Text} - {Nome_Amostra_4.Text}";
            dataGridFisica.Rows[2].Cells[1].Value = $"{Numero_Amostra_4.Text} - {Nome_Amostra_4.Text}";
            dataGridOpcional.Rows[2].Cells[1].Value = $"{Numero_Amostra_4.Text} - {Nome_Amostra_4.Text}";
        }
    }
}