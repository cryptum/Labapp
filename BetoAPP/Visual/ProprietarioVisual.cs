using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class ProprietarioVisual : Form
    {
        private static ProprietarioVisual aForm = null;
        public static ProprietarioVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new ProprietarioVisual();
            }
            return aForm;
        }
        public ProprietarioVisual()
        {
            InitializeComponent();
            btn_Pesquisa.Select();
            //this.menuStrip1.BackColor = Color.DimGray;
            //this.menuStrip1.ForeColor = Color.WhiteSmoke;
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
            dataGridProprietario.Columns[0].Width = 100;
            dataGridProprietario.Columns[2].Width = 160;
            dataGridProprietario.Columns[3].Width = 180;
            dataGridProprietario.Columns[4].Width = 110;
            dataGridProprietario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProprietario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridProprietario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridProprietario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridProprietario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        void RecarregarGrid()
        {
            dataGridProprietario.DataSource = new ProprietarioNegocio().ObterTodos();
            AlinharGrid();
        }

        void Buscar(string nome)
        {
            dataGridProprietario.DataSource = new ProprietarioNegocio().ObterListaPorNome(nome);
            AlinharGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarProprietarioVisual View = new AdicionarProprietarioVisual("Adicionar Proprietário", 0, "", "", "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProprietario.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridProprietario.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridProprietario.CurrentRow.Cells[1].Value.ToString();
                    string cpfCnpjSelecionada = dataGridProprietario.CurrentRow.Cells[2].Value.ToString();
                    string obsSelecionada = dataGridProprietario.CurrentRow.Cells[3].Value.ToString();

                    if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AdicionarProprietarioVisual View = new AdicionarProprietarioVisual("Editar Proprietário", idSelecionada, nameSelecionada, cpfCnpjSelecionada, obsSelecionada);
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
                if (dataGridProprietario.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridProprietario.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridProprietario.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = new ProprietarioNegocio().ExcluirLogicamente(idSelecionada, true);
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
            Buscar(txt_Proprietario.Text);
        }

        private void btn_Fazendas_Click(object sender, EventArgs e)
        {
            if (dataGridProprietario.CurrentRow != null)
            {
                int idProprietario = Convert.ToInt32(dataGridProprietario.CurrentRow.Cells[0].Value);

                FazendaVisual View = new FazendaVisual(idProprietario);
                View.ShowDialog();
                RecarregarGrid();
            }
        }

        private void ProprietarioVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
            AlinharGrid();
        }

        private void txt_Proprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Proprietario.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void dataGridProprietario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex >= 0)
                {
                    var nomeCabecalho = dataGridProprietario.Columns[e.ColumnIndex].Name;
                    int idProprietario = Convert.ToInt32(dataGridProprietario.CurrentRow.Cells[0].Value);


                    if (nomeCabecalho == "Fazendas")
                    {
                        FazendaVisual View = new FazendaVisual(idProprietario);
                        View.ShowDialog();
                        RecarregarGrid();
                    }
                }
            }
        }
    }
}
