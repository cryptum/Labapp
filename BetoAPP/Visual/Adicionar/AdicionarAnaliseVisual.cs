using Entidade;
using LabAPP.Visual.PaginaUnica;
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
        private int contadorDeLinhas { get; set; }
        private List<AmostraEntidade> listaAmostra = new List<AmostraEntidade>();
        public int GlobalIdProprietario { get; set; }
        public int GlobalIdAnalise { get; set; }
        Environments GlobalEnv;

        public AdicionarAnaliseVisual(Environments env, string titulo, int idAnalise, string nomeProprietario)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            GlobalIdAnalise = idAnalise;
            GlobalEnv = env;

            CriarAnaliseOuAdicionarAmostra();
        }

        void CriarAnaliseOuAdicionarAmostra()
        {
            if (txtTitulo.Text == "Adicionar Amostras")
            {
                //Adicionar Amostra
            }
            else
            {
                //Criar Análise
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


            if (txtTitulo.Text == "Adicionar Amostras")
            {
                var analise = new AnaliseNegocio().ObterUmPorCodigo(GlobalIdAnalise);
            }

        }


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
            LerGrid();
            var idAnalise = new AnaliseNegocio().Salvar(
                       txt_NumeroLaudo.Text.Trim(),
                       this.GlobalIdProprietario,
                       cbx_Fazenda.Text,
                       cbx_TipoAnalise.Text,
                       cbx_Cultura.Text,
                       cbx_Solicitacao.Text);

            //MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            var analiseSalva = new AnaliseNegocio().ObterUmPorCodigo(idAnalise);

            if (listaAmostra.Count == 0)
            {
                MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            new RelatorioNegocio().Gerar(analiseSalva, listaAmostra);
        }

        void AdicionarNaGridLinhas()
        {
            contadorDeLinhas++;
            dataGridView1.Columns.Add("Amostra " + contadorDeLinhas, "Amostra " + contadorDeLinhas);
        }

        void AdicionarNaGridAmostra(AmostraEntidade amostra)
        {
            dataGridView1.Rows[0].Cells[contadorDeLinhas].Value = amostra.NumeroAmostra;
            dataGridView1.Rows[1].Cells[contadorDeLinhas].Value = amostra.NomeAmostra;
            dataGridView1.Rows[2].Cells[contadorDeLinhas].Value = amostra.Ph_Agua;
            dataGridView1.Rows[3].Cells[contadorDeLinhas].Value = amostra.Diluicao;
            dataGridView1.Rows[4].Cells[contadorDeLinhas].Value = amostra.P_Fosforo;
            dataGridView1.Rows[5].Cells[contadorDeLinhas].Value = amostra.K_Potassio;
            dataGridView1.Rows[6].Cells[contadorDeLinhas].Value = amostra.Ca_Calcio;
            dataGridView1.Rows[7].Cells[contadorDeLinhas].Value = amostra.Al_Aluminio;
            dataGridView1.Rows[8].Cells[contadorDeLinhas].Value = amostra.Mg_Magnesio;
            dataGridView1.Rows[9].Cells[contadorDeLinhas].Value = amostra.Alh_AcidezPotencial;
            dataGridView1.Rows[10].Cells[contadorDeLinhas].Value = amostra.Zn_Zinco;
            dataGridView1.Rows[11].Cells[contadorDeLinhas].Value = amostra.Cu_Cobre;
            dataGridView1.Rows[12].Cells[contadorDeLinhas].Value = amostra.Fe_Ferro;
            dataGridView1.Rows[13].Cells[contadorDeLinhas].Value = amostra.Mn_manganes;
            dataGridView1.Rows[14].Cells[contadorDeLinhas].Value = amostra.Argila_Inicio;
            dataGridView1.Rows[15].Cells[contadorDeLinhas].Value = amostra.Argila_Fim;
            dataGridView1.Rows[16].Cells[contadorDeLinhas].Value = amostra.Areia_Inicio;
            dataGridView1.Rows[17].Cells[contadorDeLinhas].Value = amostra.Areia_Fim;
            dataGridView1.Rows[18].Cells[contadorDeLinhas].Value = amostra.Silte_Inicio;
            dataGridView1.Rows[19].Cells[contadorDeLinhas].Value = amostra.Silte_Fim;
            dataGridView1.Rows[20].Cells[contadorDeLinhas].Value = amostra.B_Boro;
            dataGridView1.Rows[21].Cells[contadorDeLinhas].Value = amostra.S_Enxofre;
            dataGridView1.Rows[22].Cells[contadorDeLinhas].Value = amostra.Mo_MateriaOrganica;
        }

        void LerGrid()
        {
            if (contadorDeLinhas > 0)
            {

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    AmostraEntidade amostra = new AmostraEntidade();

                    amostra.NumeroAmostra = Convert.ToString(dataGridView1.Rows[0].Cells[i].Value);
                    amostra.NomeAmostra = Convert.ToString(dataGridView1.Rows[1].Cells[i].Value);
                    amostra.Ph_Agua = Convert.ToString(dataGridView1.Rows[2].Cells[i].Value);
                    amostra.Diluicao = Convert.ToString(dataGridView1.Rows[3].Cells[i].Value);
                    amostra.P_Fosforo = Convert.ToString(dataGridView1.Rows[4].Cells[i].Value);
                    amostra.K_Potassio = Convert.ToString(dataGridView1.Rows[5].Cells[i].Value);
                    amostra.Ca_Calcio = Convert.ToString(dataGridView1.Rows[6].Cells[i].Value);
                    amostra.Al_Aluminio = Convert.ToString(dataGridView1.Rows[7].Cells[i].Value);
                    amostra.Mg_Magnesio = Convert.ToString(dataGridView1.Rows[8].Cells[i].Value);
                    amostra.Alh_AcidezPotencial = Convert.ToString(dataGridView1.Rows[9].Cells[i].Value);
                    amostra.Zn_Zinco = Convert.ToString(dataGridView1.Rows[10].Cells[i].Value);
                    amostra.Cu_Cobre = Convert.ToString(dataGridView1.Rows[11].Cells[i].Value);
                    amostra.Fe_Ferro = Convert.ToString(dataGridView1.Rows[12].Cells[i].Value);
                    amostra.Mn_manganes = Convert.ToString(dataGridView1.Rows[13].Cells[i].Value);
                    amostra.Argila_Inicio = Convert.ToString(dataGridView1.Rows[14].Cells[i].Value);
                    amostra.Argila_Fim = Convert.ToString(dataGridView1.Rows[15].Cells[i].Value);
                    amostra.Areia_Inicio = Convert.ToString(dataGridView1.Rows[16].Cells[i].Value);
                    amostra.Areia_Fim = Convert.ToString(dataGridView1.Rows[17].Cells[i].Value);
                    amostra.Silte_Inicio = Convert.ToString(dataGridView1.Rows[18].Cells[i].Value);
                    amostra.Silte_Fim = Convert.ToString(dataGridView1.Rows[19].Cells[i].Value);
                    amostra.B_Boro = Convert.ToString(dataGridView1.Rows[20].Cells[i].Value);
                    amostra.S_Enxofre = Convert.ToString(dataGridView1.Rows[21].Cells[i].Value);
                    amostra.Mo_MateriaOrganica = Convert.ToString(dataGridView1.Rows[22].Cells[i].Value);

                    listaAmostra.Add(amostra);
                }
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
            
            return amostra;
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

        private void btn_AdicionarAmostra_Click(object sender, EventArgs e)
        {
            using (var form = new AmostraUnicoVisual())
            {
                form.ShowDialog();

                if (form.Amostra != null)
                {
                    AdicionarNaGridLinhas();
                    AdicionarNaGridAmostra(
                        new AmostraEntidade(
                            form.Amostra.NumeroAmostra,
                            form.Amostra.NomeAmostra,
                            form.Amostra.Ph_Agua,
                            form.Amostra.Diluicao,
                            form.Amostra.P_Fosforo,
                            form.Amostra.K_Potassio,
                            form.Amostra.Ca_Calcio,
                            form.Amostra.Al_Aluminio,
                            form.Amostra.Mg_Magnesio,
                            form.Amostra.Alh_AcidezPotencial,
                            form.Amostra.Zn_Zinco,
                            form.Amostra.Cu_Cobre,
                            form.Amostra.Fe_Ferro,
                            form.Amostra.Mn_manganes,
                            form.Amostra.Argila_Inicio,
                            form.Amostra.Argila_Fim,
                            form.Amostra.Areia_Inicio,
                            form.Amostra.Areia_Fim,
                            form.Amostra.Silte_Inicio,
                            form.Amostra.Silte_Fim,
                            form.Amostra.B_Boro,
                            form.Amostra.S_Enxofre,
                            form.Amostra.Mo_MateriaOrganica
                            ));
                }
            }
        }
    }
}