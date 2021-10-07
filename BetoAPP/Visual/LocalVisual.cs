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
        public void RecarregarGrid()
        {
            dataGridLocal.DataSource = new LocalNegocio().ObterTodos(idInicialSolicitante);
            dataGridLocal.Columns[1].Width = 381;
        }

        public List<LocalDTO> Buscar(string nome)
        {
            return new LocalNegocio().ObterListaPorNome(idInicialSolicitante, nome);
        }

        private void LocalVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarLocalVisual View = new AdicionarLocalVisual("Adicionar Local", 0, "", "", idInicialSolicitante);
            View.ShowDialog();
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
            }
        }
    }
}
