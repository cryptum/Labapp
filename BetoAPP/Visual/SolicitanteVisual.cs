using BetoAPP.Util;
using Entidade.DTO;
using Negocio;
using Repositorio;
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
        }

        public void RecarregarGrid()
        {
            dataGridSolicitante.DataSource = new SolicitanteNegocio().ObterTodos();

            dataGridSolicitante.Columns[0].Width = 90;
            dataGridSolicitante.Columns[1].Width = 305;
            dataGridSolicitante.Columns[2].Width = 120;
            dataGridSolicitante.Columns[3].Width = 110;

            dataGridSolicitante.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSolicitante.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public List<SolicitanteDTO> Buscar(string nome)
        {
            return new SolicitanteNegocio().ObterListaPorNome(nome);
        }

        private void SolicitanteVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarSolicitanteVisual View = new AdicionarSolicitanteVisual("Adicionar Solicitante", 0, "");
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
                    AdicionarSolicitanteVisual View = new AdicionarSolicitanteVisual("Editar Solicitante", idSelecionada, nameSelecionada);
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
            }
        }

        private void dataGridSolicitante_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var nomeCabecalho = dataGridSolicitante.Columns[e.ColumnIndex].Name;
            string NumeroFazenda = dataGridSolicitante.CurrentRow.Cells[3].Value.ToString();

            if (nomeCabecalho == "Fazendas")
            {
                MessageBox.Show($"numero de fazendas {NumeroFazenda}");
            }
        }
    }
}
