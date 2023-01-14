using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class CulturaVisual : Form
    {
        private static CulturaVisual aForm = null;
        public static CulturaVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new CulturaVisual();
            }
            return aForm;
        }

        public CulturaVisual()
        {
            InitializeComponent();
            btn_Pesquisa.Select();
        }

        void AlinharGrid()
        {
            dataGridCultura.Columns[0].Width = 100;
            dataGridCultura.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void RecarregarGrid()
        {
            dataGridCultura.DataSource = new CulturaNegocio().ObterTodos();
            AlinharGrid();
        }

        void Buscar(string nome)
        {
            dataGridCultura.DataSource = new CulturaNegocio().ObterListaPorNome(nome);
            AlinharGrid();
        }

        private void CulturaVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarCulturaVisual View = new AdicionarCulturaVisual("Adicionar Cultura", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCultura.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridCultura.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridCultura.CurrentRow.Cells[1].Value.ToString();

                    if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AdicionarCulturaVisual View = new AdicionarCulturaVisual("Editar Cultura", idSelecionada, nameSelecionada);
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
                if (dataGridCultura.CurrentRow != null)
                {
                    int idSelecionada = Convert.ToInt32(dataGridCultura.CurrentRow.Cells[0].Value.ToString());
                    string nameSelecionada = dataGridCultura.CurrentRow.Cells[1].Value.ToString();

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
