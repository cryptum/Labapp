using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class UsuarioVisual : Form
    {
        private static UsuarioVisual aForm = null;
        public static UsuarioVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new UsuarioVisual();
            }
            return aForm;
        }
        public UsuarioVisual()
        {
            InitializeComponent();
            btn_Pesquisa.Select();
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
            dataGridUsuario.Columns[0].Width = 100;
            dataGridUsuario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUsuario.Columns[3].ReadOnly = true;
            dataGridUsuario.Columns[4].ReadOnly = true;
        }

        void RecarregarGrid()
        {
            dataGridUsuario.DataSource = new UsuarioNegocio().ObterTodos();
            AlinharGrid();
        }

        void Buscar(string nome)
        {
            dataGridUsuario.DataSource = new UsuarioNegocio().ObterListaPorNome(nome);
            AlinharGrid();
        }

        private void UsuarioVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
            AlinharGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionaUsuarioVisual View = new AdicionaUsuarioVisual("Adicionar Usuário", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuario.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridUsuario.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridUsuario.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AdicionaUsuarioVisual View = new AdicionaUsuarioVisual("Editar Usuário", idSelecionada, nameSelecionada);
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
                if (dataGridUsuario.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridUsuario.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridUsuario.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int result = new CulturaNegocio().Excluir(idSelecionada);
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


        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Pesquisa.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            Buscar(txt_Pesquisa.Text);
        }
    }
}
