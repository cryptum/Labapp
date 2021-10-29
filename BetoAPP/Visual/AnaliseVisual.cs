using BetoAPP.Util;
using Negocio;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AnaliseVisual : Form
    {
        private static AnaliseVisual aForm = null;
        public static AnaliseVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new AnaliseVisual();
            }
            return aForm;
        }
        public AnaliseVisual()
        {
            InitializeComponent();
            btn_Edita.Visible = false;
            cbx_Pesquisa.Items.Add("Nome do Cliente");
            cbx_Pesquisa.Items.Add("CPF do Cliente");
            cbx_Pesquisa.SelectedIndex = 0;
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

        void AlinharGrid()
        {
            dataGridAnalise.Columns[0].Width = 100;
            dataGridAnalise.Columns[1].Width = 300;
            dataGridAnalise.Columns[2].Width = 195;
            dataGridAnalise.Columns[3].Width = 120;
            dataGridAnalise.Columns[4].Width = 120;
            dataGridAnalise.Columns[5].Width = 150;
        }

        public void RecarregarGrid()
        {
            dataGridAnalise.DataSource = new AnaliseNegocio().ObterTodos();
            AlinharGrid();
        }

        public void Buscar(string nomeOuCpf)
        {
            switch (cbx_Pesquisa.SelectedItem)
            {
                case "Nome do Cliente":
                    {
                        dataGridAnalise.DataSource = new AnaliseNegocio().ObterListaPorSolicitanteNome(nomeOuCpf);
                        AlinharGrid();
                        break;
                    }
                case "CPF do Cliente":
                    {
                        dataGridAnalise.DataSource = new AnaliseNegocio().ObterListaPorSolicitanteCpf(nomeOuCpf);
                        AlinharGrid();
                        break;
                    }
                default:
                    break;
            }

        }

        private void AnaliseVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdicionarAnaliseVisual View = new AdicionarAnaliseVisual("Adicionar Análise", 0, "");
            View.ShowDialog();
            this.Visible = true;
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());
            //    string nameSelecionada = dataGridAnalise.CurrentRow.Cells[1].Value.ToString();

            //    if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        AdicionarCulturaVisual View = new AdicionarCulturaVisual("Editar Análise", idSelecionada, nameSelecionada);
            //        View.ShowDialog();
            //        RecarregarGrid();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btn_Exclui_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridAnalise.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new AmostraNegocio().Excluir(idSelecionada);
                    int result = new AnaliseNegocio().Excluir(idSelecionada);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        RecarregarGrid();
                    }
                    else
                    {
                        RecarregarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_ImprimeQuadriculado_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInput = new Thread(x =>
                {
                    SetLoading(true);

                    new GerarQuardriculado().Gerar();

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

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            Buscar(txt_Pesquisa.Text);
        }

        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Pesquisa.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_ImprimeLaudo_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInput = new Thread(x =>
                {
                    SetLoading(true);

                    int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());

                    var analise = new AnaliseNegocio().ObterUmPorCodigo(idSelecionada);
                    var amostra = new AmostraNegocio().ObterAmostrarPorIdAnalise(idSelecionada);
                    new GerarPDF().Gerar(analise, amostra);

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

        private void cbx_Pesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_Pesquisa.SelectedItem)
            {
                case "Nome do Cliente":
                    {
                        txt_Pesquisa.Mask = "";
                        break;
                    }
                case "CPF do Cliente":
                    {
                        txt_Pesquisa.Mask = "000 , 000 , 000 - 00";
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
