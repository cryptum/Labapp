using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class LocalVisual : Form
    {
        private static LocalVisual aForm = null;
        public static LocalVisual Instance(int idSolicitante)
        {
            if (aForm == null)
            {
                aForm = new LocalVisual(idSolicitante);
            }
            return aForm;
        }

        int idInicialSolicitante;
        public LocalVisual(int idSolicitante)
        {
            InitializeComponent();
            idInicialSolicitante = idSolicitante;
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
            dataGridLocal.DataSource = new LocalNegocio().ObterTodos(idInicialSolicitante);
            dataGridLocal.Columns[1].Width = 381;
        }

        public void Buscar(string nome)
        {
            dataGridLocal.DataSource = new LocalNegocio().ObterListaPorNome(idInicialSolicitante, nome);
            dataGridLocal.Columns[1].Width = 381;
        }

        private void LocalVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdicionarLocalVisual View = new AdicionarLocalVisual("Adicionar Local", 0, "", "", idInicialSolicitante);
            View.ShowDialog();
            this.Visible = true;
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridLocal.CurrentRow.Cells[0].Value.ToString());
                string FazendaSelecionada = dataGridLocal.CurrentRow.Cells[1].Value.ToString();
                string municipioSelecionada = dataGridLocal.CurrentRow.Cells[2].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {FazendaSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarLocalVisual View = new AdicionarLocalVisual("Editar Local", idSelecionada, FazendaSelecionada, municipioSelecionada, idInicialSolicitante);
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
                int idSelecionada = Convert.ToInt32(dataGridLocal.CurrentRow.Cells[0].Value.ToString());
                string FazendaSelecionada = dataGridLocal.CurrentRow.Cells[1].Value.ToString();
                string municipioSelecionada = dataGridLocal.CurrentRow.Cells[2].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {FazendaSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = new LocalNegocio().ExcluirLogicamente(idSelecionada, true);
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

        private void btn_Solicitacao_Click(object sender, EventArgs e)
        {
            Buscar(txt_Local.Text);
        }

        private void txt_Solicitacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Local.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
