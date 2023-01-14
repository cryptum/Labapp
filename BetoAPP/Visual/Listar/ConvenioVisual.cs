using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class ConvenioVisual : Form
    {
        private static ConvenioVisual aForm = null;
        public static ConvenioVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new ConvenioVisual();
            }
            return aForm;
        }
        public ConvenioVisual()
        {
            InitializeComponent();
            btn_Pesquisa.Select();
        }

        void AlinharGrid()
        {
            dataGridTipoSolicitacao.Columns[0].Width = 100;
            dataGridTipoSolicitacao.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void RecarregarGrid()
        {
            dataGridTipoSolicitacao.DataSource = new ConvenioNegocio().ObterTodos();
            AlinharGrid();
        }

        void Buscar(string nome)
        {
            dataGridTipoSolicitacao.DataSource = new ConvenioNegocio().ObterListaPorNome(nome);
            AlinharGrid();
        }

        private void TipoSolicitacaoVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarConvenioVisual View = new AdicionarConvenioVisual("Adicionar Tipo Solicitação", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridTipoSolicitacao.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridTipoSolicitacao.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridTipoSolicitacao.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AdicionarConvenioVisual View = new AdicionarConvenioVisual("Editar Tipo Solicitação", idSelecionada, nameSelecionada);
                        View.ShowDialog();
                        RecarregarGrid();
                    }
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
                if (dataGridTipoSolicitacao.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridTipoSolicitacao.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridTipoSolicitacao.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = new ConvenioNegocio().Excluir(idSelecionada);
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

        private void btn_Recarrega_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
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

        private void txt_Pesquisa_Click(object sender, EventArgs e)
        {
            txt_Pesquisa.Text = "";
        }
    }
}
