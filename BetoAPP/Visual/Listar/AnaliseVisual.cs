using LabAPP.Util;
using Negocio;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace LabAPP.Visual
{
    public partial class AnaliseVisual : Form
    {
        private static AnaliseVisual aForm = null;
        public static AnaliseVisual Instance(Environments env)
        {
            if (aForm == null)
            {
                aForm = new AnaliseVisual(env);
            }
            return aForm;
        }

        Environments GlobalEnv;

        public AnaliseVisual(Environments env)
        {
            InitializeComponent();
            btn_Pesquisa.Select();
            cbx_Pesquisa.Items.Add("Nome do Proprietário");
            cbx_Pesquisa.Items.Add("CPF/CNPJ do Proprietário");
            cbx_Pesquisa.SelectedIndex = 0;
            GlobalEnv = env;
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
            dataGridAnalise.Columns[0].Width = 80;
            dataGridAnalise.Columns[1].Width = 80;
            dataGridAnalise.Columns[2].Width = 300;
            dataGridAnalise.Columns[3].Width = 195;
            dataGridAnalise.Columns[4].Width = 120;
            dataGridAnalise.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAnalise.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void RecarregarGrid()
        {
            dataGridAnalise.DataSource = new AnaliseNegocio().ObterTodosCompletos();
            AlinharGrid();
        }

        public void Buscar(string nomeOuCpf)
        {
            switch (cbx_Pesquisa.SelectedItem)
            {
                case "Nome do Proprietário":
                    {
                        dataGridAnalise.DataSource = new AnaliseNegocio().ObterListaPorNomeProprietario(nomeOuCpf);
                        AlinharGrid();
                        break;
                    }
                case "CPF/CNPJ do Proprietário":
                    {
                        dataGridAnalise.DataSource = new AnaliseNegocio().ObterListaPorCpfProprietario(nomeOuCpf.Replace(".", "").Replace(",", "").Replace("\\", "").Replace("/", ""));
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
            AdicionarAnaliseVisual View = new AdicionarAnaliseVisual(GlobalEnv, "Criar Análise", 0, "");
            View.ShowDialog();
            this.Visible = true;
            RecarregarGrid();
        }


        private void btn_Adicionar_Amostra_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridAnalise.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Adicionar Amostras ao: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Visible = false;
                    AdicionarCulturaVisual View = new AdicionarCulturaVisual("Adicionar Amostras", idSelecionada, nameSelecionada);
                    View.ShowDialog();
                    this.Visible = true;
                    RecarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Exclui_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAnalise.CurrentRow != null)
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
                if (dataGridAnalise.CurrentRow != null)
                {
                    Thread threadInput = new Thread(x =>
                    {
                        SetLoading(true);

                        int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());

                        var analise = new AnaliseNegocio().ObterUmPorCodigo(idSelecionada);
                        var amostra = new AmostraNegocio().ObterAmostrarPorIdAnalise(idSelecionada);

                        SetLoading(false);
                    });
                    threadInput.Start();
                }
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

        private void dataGridAnalise_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAnalise.Rows)
            {
                if (row.Cells[7].Value.ToString() == "Completa")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(77, 228, 102);
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(230, 236, 63);
            }
        }
    }
}
