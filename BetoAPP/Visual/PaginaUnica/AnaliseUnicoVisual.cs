using Entidade;
using Entidade.DTO;
using LabAPP.Visual.PaginaUnica;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class AnaliseUnicoVisual : Form
    {
        private int contadorDeLinhas { get; set; }
        private List<AmostraEntidade> listaAmostra = new List<AmostraEntidade>();

        public AnaliseUnicoVisual()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panel1.BringToFront();
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            TipoAnaliseEntidade tipoAnalise = new TipoAnaliseEntidade();
            ////tipoanalise
            if (!cbx_TipoAnalise.Items.Contains(cbx_TipoAnalise.Text))
            {
                new TipoAnaliseNegocio().Salvar(cbx_TipoAnalise.Text);
            }
            tipoAnalise = new TipoAnaliseNegocio().ObterUmPorNome(cbx_TipoAnalise.Text);

            CulturaEntidade cultura = new CulturaEntidade();
            ////cultura
            if (!cbx_Cultura.Items.Contains(cbx_Cultura.Text))
            {
                new CulturaNegocio().Salvar(cbx_Cultura.Text);
            }
            new CulturaNegocio().ObterUmPorNome(cbx_Cultura.Text);

            ConvenioEntidade convenio = new ConvenioEntidade();
            ////Convênio
            if (!cbx_Convenio.Items.Contains(cbx_Convenio.Text))
            {
                new ConvenioNegocio().Salvar(cbx_Convenio.Text);
            }
            new ConvenioNegocio().ObterUmPorNome(cbx_Convenio.Text);


            ProprietarioEntidade proprietario = new ProprietarioEntidade();
            if (!cbx_NomeCliente.Items.Contains(cbx_NomeCliente.Text))
            {

                int idsalvo = new ProprietarioNegocio().Salvar(cbx_NomeCliente.Text, txt_CpfCnpj.Text, txt_Anotacao.Text);
                proprietario = new ProprietarioNegocio().ObterUmPorCodigo(idsalvo); 
            }

            LerGrid();


            var idAnalise = new AnaliseNegocio().Salvar(
                       txt_NumeroLaudo.Text.Trim(),
                       proprietario.IdProprietario,
                       cbx_Fazenda.Text,
                       cbx_TipoAnalise.Text,
                       cbx_Cultura.Text,
                       cbx_Convenio.Text);

            MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            var analiseSalva = new AnaliseNegocio().ObterUmPorCodigo(idAnalise);

            new RelatorioNegocio().Gerar(analiseSalva, listaAmostra);

        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var result = new ProprietarioNegocio().ObterUmPorNome(cbx_NomeCliente.Text);
            if (result.Cpf.Length <= 14)
            {
                //cpf
                cbx_CpfCnpj.SelectedIndex = 0;
            }
            else if (result.Cpf.Length >= 18)
            {
                //cnpj
                cbx_CpfCnpj.SelectedIndex = 1;
            }
            txt_CpfCnpj.Text = result.Cpf;
            txt_Anotacao.Text = result.Observacao;

            if (result.Fazendas != null)
            {
                foreach (var item in result.Fazendas)
                {
                    //cbxNomeCliente.Items.Clear();
                    cbx_Fazenda.Items.Add(item.Fazenda);
                }
            }
        }

        private void cbx_Fazenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = new FazendaNegocio().ObterUmPorNomeEProprietario(cbx_Fazenda.Text, cbx_NomeCliente.Text);
            txt_Municipio.Text = result.Municipio;
        }

        private void cbxNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbx_NomeCliente.Text.Length != 0)
            {
                var result = new ProprietarioNegocio().ObterListaPorNome(cbx_NomeCliente.Text);
                foreach (var item in result)
                {
                    //cbxNomeCliente.Items.Clear();
                    cbx_NomeCliente.Items.Add(item.Nome);
                }
            }

            //if (cbxNomeCliente.Text.Length <= 1 && e.KeyCode == Keys.Back)
            //{
            //    cbxNomeCliente.Text = "";
            //}
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void PaginaUnicaVisual_Load(object sender, EventArgs e)
        {
            cbx_CpfCnpj.Items.Add("CPF");
            cbx_CpfCnpj.Items.Add("CNPJ");
            cbx_CpfCnpj.SelectedIndex = 0;

            var tipoAnalises = new TipoAnaliseNegocio().ObterTodos();
            for (int i = 0; i < tipoAnalises.Count(); i++)
            {
                cbx_TipoAnalise.Items.Add(tipoAnalises[i].Nome);
            }

            var culturas = new CulturaNegocio().ObterTodos();
            for (int i = 0; i < culturas.Count(); i++)
            {
                cbx_Cultura.Items.Add(culturas[i].Nome);
            }

            var convenios = new ConvenioNegocio().ObterTodos();
            for (int i = 0; i < convenios.Count(); i++)
            {
                cbx_Convenio.Items.Add(convenios[i].Nome);
            }


            contadorDeLinhas = 0;
            dataGridView1.Columns.Add("tles", "tres");
            for (int i = 1; i < 24; i++)
            {
                dataGridView1.Rows.Add("");
            }

            AdicionarNaGridAmostra(new AmostraEntidade("Número", "Nome", "pH Água", "Diluição", "Fósforo", "Potássio", "Cálcio", "Alumínio", "Magnésio", "Acidez Potêncial", "Zinco", "Cobre", "Ferro", "Manganes", "Argila I.", "Argila F.", "Areia I.", "Areia F.", "Silte I.", "Silte F.", "Boro", "Enxofre", "Materia Organica"));
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Sair_MouseLeave(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_cinza_24px;
        }

        private void btn_Sair_MouseHover(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_vermelho_24px;
        }

        private void Pagina_3_Left_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void Pagina_2_Left_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void Pagina_2_Right_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void Pagina_1_Left_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void Pagina_1_Right_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
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