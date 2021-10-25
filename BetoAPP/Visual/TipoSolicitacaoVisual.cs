using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class TipoSolicitacaoVisual : Form
    {
        private static TipoSolicitacaoVisual aForm = null;
        public static TipoSolicitacaoVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new TipoSolicitacaoVisual();
            }
            return aForm;
        }
        public TipoSolicitacaoVisual()
        {
            InitializeComponent();
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


        public void RecarregarGrid()
        {
            dataGridTipoSolicitacao.DataSource = new TipoSolicitacaoNegocio().ObterTodos();
            dataGridTipoSolicitacao.Columns[1].Width = 381;
        }

        public void Buscar(string nome)
        {
            dataGridTipoSolicitacao.DataSource = new TipoSolicitacaoNegocio().ObterListaPorNome(nome);
            dataGridTipoSolicitacao.Columns[1].Width = 381;
        }

        private void TipoSolicitacaoVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarTipoSolicitacaoVisual View = new AdicionarTipoSolicitacaoVisual("Adicionar Tipo Solicitação", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridTipoSolicitacao.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridTipoSolicitacao.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarTipoSolicitacaoVisual View = new AdicionarTipoSolicitacaoVisual("Editar Tipo Solicitação", idSelecionada, nameSelecionada);
                    View.ShowDialog();
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
                int idSelecionada = Convert.ToInt32(dataGridTipoSolicitacao.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridTipoSolicitacao.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = new TipoSolicitacaoNegocio().Excluir(idSelecionada);
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
    }
}
