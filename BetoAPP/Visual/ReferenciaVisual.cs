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
    public partial class ReferenciaVisual : Form
    {
        private static ReferenciaVisual aForm = null;
        public static ReferenciaVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new ReferenciaVisual();
            }
            return aForm;
        }
        public ReferenciaVisual()
        {
            InitializeComponent();
        }

        public void RecarregarGrid()
        {
            dataGridReferencia.DataSource = new ReferenciaNegocio().ObterTodos();
            dataGridReferencia.Columns[1].Width = 381;
        }

        public List<ReferenciaDTO> Buscar(string nome)
        {
            return new ReferenciaNegocio().ObterListaPorNome(nome);
        }

        private void ReferenciaVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarReferenciaVisual View = new AdicionarReferenciaVisual("Adicionar Referência", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridReferencia.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridReferencia.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarReferenciaVisual View = new AdicionarReferenciaVisual("Editar Referência", idSelecionada, nameSelecionada);
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
                int idSelecionada = Convert.ToInt32(dataGridReferencia.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridReferencia.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = new ReferenciaNegocio().Excluir(idSelecionada);
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
