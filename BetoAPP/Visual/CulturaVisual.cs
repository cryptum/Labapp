using BetoAPP.Util;
using Entidade.DTO;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BetoAPP.Visual
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
        }

        public void RecarregarGrid()
        {
            dataGridCultura.DataSource = new CulturaNegocio().ObterTodos();
            dataGridCultura.Columns[1].Width = 381;
        }

        public List<CulturaDTO> Buscar(string nome)
        {
            return new CulturaNegocio().ObterListaPorNome(nome);
        }

        private void CulturaVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarCulturaVisual View = new AdicionarCulturaVisual("Adicionar Cultura", 0 ,"");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada= Convert.ToInt32(dataGridCultura.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridCultura.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarCulturaVisual View = new AdicionarCulturaVisual("Editar Cultura", idSelecionada, nameSelecionada);
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
            }
        }
    }
}
