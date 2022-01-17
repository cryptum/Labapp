using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class FazendaVisual : Form
    {
        private static FazendaVisual aForm = null;
        public static FazendaVisual Instance(int idProprietario)
        {
            if (aForm == null)
            {
                aForm = new FazendaVisual(idProprietario);
            }
            return aForm;
        }

        int idInicialProprietario;
        public FazendaVisual(int idProprietario)
        {
            InitializeComponent();
            idInicialProprietario = idProprietario;
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

        void AlinharGrid()
        {
            dataGridFazenda.Columns[0].Width = 100;
            dataGridFazenda.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void RecarregarGrid()
        {
            dataGridFazenda.DataSource = new FazendaNegocio().ObterTodos(idInicialProprietario);
            AlinharGrid();
        }

        void Buscar(string nome)
        {
            dataGridFazenda.DataSource = new FazendaNegocio().ObterListaPorNome(idInicialProprietario, nome);
            AlinharGrid();
        }

        private void FazendaVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            AdicionarFazendaVisual View = new AdicionarFazendaVisual("Adicionar Fazenda", 0, "", "", idInicialProprietario);
            View.ShowDialog();
            //this.Visible = true;
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridFazenda.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridFazenda.CurrentRow.Cells[0].Value.ToString());
                    string fazendaSelecionada = dataGridFazenda.CurrentRow.Cells[1].Value.ToString();
                    string municipioSelecionada = dataGridFazenda.CurrentRow.Cells[2].Value.ToString();

                    if (MessageBox.Show($"Deseja editar: {fazendaSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AdicionarFazendaVisual View = new AdicionarFazendaVisual("Editar Fazenda", idSelecionada, fazendaSelecionada, municipioSelecionada, idInicialProprietario);
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
                if (dataGridFazenda.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridFazenda.CurrentRow.Cells[0].Value.ToString());
                    string FazendaSelecionada = dataGridFazenda.CurrentRow.Cells[1].Value.ToString();
                    string municipioSelecionada = dataGridFazenda.CurrentRow.Cells[2].Value.ToString();

                    if (MessageBox.Show($"Deseja Excluir: {FazendaSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = new FazendaNegocio().ExcluirLogicamente(idSelecionada, true);
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

        private void btn_Solicitacao_Click(object sender, EventArgs e)
        {
            Buscar(txt_Pesquisa.Text);
        }

        private void txt_Solicitacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Pesquisa.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
