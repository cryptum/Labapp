using BetoAPP.Util;
using Entidade.DTO;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AnaliseVisual : Form
    {
        private static AnaliseVisual aForm = null;
        public static AnaliseVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new AnaliseVisual();
            }
            return aForm;
        }
        public AnaliseVisual()
        {
            InitializeComponent();
            btn_Edita.Visible = false;
            cbx_Pesquisa.Items.Add("Solicitante");
            cbx_Pesquisa.Items.Add("Laudo");
            cbx_Pesquisa.SelectedIndex = 0;
        }

        public void RecarregarGrid()
        {
            dataGridAnalise.DataSource = new AnaliseNegocio().ObterTodos();
            dataGridAnalise.Columns[0].Width = 100;
            dataGridAnalise.Columns[1].Width = 300;
            dataGridAnalise.Columns[2].Width = 195;
            dataGridAnalise.Columns[3].Width = 120;
            dataGridAnalise.Columns[4].Width = 120;
            dataGridAnalise.Columns[5].Width = 150;
        }

        public List<AnaliseObterTodosDTO> Buscar(string nome)
        {
            return new AnaliseNegocio().ObterListaPorSolicitante(nome);
        }

        private void AnaliseVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdicionarAnaliseVisual View = new AdicionarAnaliseVisual("Adicionar Análise", 0, "");
            View.ShowDialog();
            this.Visible = true;
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridAnalise.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarCulturaVisual View = new AdicionarCulturaVisual("Editar Análise", idSelecionada, nameSelecionada);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_ImprimeQuadriculado_Click(object sender, EventArgs e)
        {
            new GerarQuardriculado().Gerar();
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

            int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());

            var analise = new AnaliseNegocio().ObterUmPorCodigo(idSelecionada);
            var amostra = new AmostraNegocio().ObterAmostrarPorIdAnalise(idSelecionada);
            new GerarPDF().Gerar(analise, amostra);
        }
    }
}
