using BetoAPP.Util;
using Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class SolicitanteVisual : Form
    {
        private static SolicitanteVisual aForm = null;
        public static SolicitanteVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new SolicitanteVisual();
            }
            return aForm;
        }
        public SolicitanteVisual()
        {
            InitializeComponent();
            this.menuStrip1.BackColor = Color.DimGray;
            this.menuStrip1.ForeColor = Color.WhiteSmoke;
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
            dataGridSolicitante.DataSource = new SolicitanteNegocio().ObterTodos();
            dataGridSolicitante.Columns[0].Width = 100;
            dataGridSolicitante.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSolicitante.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void Buscar(string nome)
        {
            dataGridSolicitante.DataSource = new SolicitanteNegocio().ObterListaPorNome(nome);
            dataGridSolicitante.Columns[0].Width = 100;
            dataGridSolicitante.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSolicitante.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SolicitanteVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarSolicitanteVisual View = new AdicionarSolicitanteVisual("Adicionar Cliente", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridSolicitante.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridSolicitante.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarSolicitanteVisual View = new AdicionarSolicitanteVisual("Editar Cliente", idSelecionada, nameSelecionada);
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
                int idSelecionada = Convert.ToInt32(dataGridSolicitante.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridSolicitante.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = new SolicitanteNegocio().ExcluirLogicamente(idSelecionada, true);
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

        private void btn_Solicitante_Click(object sender, EventArgs e)
        {
            Buscar(txt_Solicitante.Text);
        }

        private void txt_Solicitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Solicitante.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void dataGridSolicitante_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var nomeCabecalho = dataGridSolicitante.Columns[e.ColumnIndex].Name;
            string NumeroFazenda = dataGridSolicitante.CurrentRow.Cells[3].Value.ToString();
            int IdSolicitante = Convert.ToInt32(dataGridSolicitante.CurrentRow.Cells[0].Value);


            if (nomeCabecalho == "Fazendas")
            {
                LocalVisual View = new LocalVisual(IdSolicitante);
                View.ShowDialog();
                RecarregarGrid();
            }
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void SolicitanteVisual_MinimumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test minium size changed");
        }

        private void SolicitanteVisual_MaximumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test maximum size changed");
        }
    }
}
