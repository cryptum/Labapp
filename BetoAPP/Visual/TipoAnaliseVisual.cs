﻿using BetoAPP.Util;
using Entidade.DTO;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class TipoAnaliseVisual : Form
    {
        private static TipoAnaliseVisual aForm = null;
        public static TipoAnaliseVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new TipoAnaliseVisual();
            }
            return aForm;
        }
        public TipoAnaliseVisual()
        {
            InitializeComponent();
        }

        public void RecarregarGrid()
        {
            dataGridTipoAnalise.DataSource = new TipoAnaliseNegocio().ObterTodos();
            dataGridTipoAnalise.Columns[1].Width = 381;
        }

        public List<TipoAnaliseDTO> Buscar(string nome)
        {
            return new TipoAnaliseNegocio().ObterListaPorNome(nome);
        }

        private void TipoAnalise_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarTipoAnaliseVisual View = new AdicionarTipoAnaliseVisual("Adicionar Tipo Análise", 0, "");
            View.ShowDialog();
            RecarregarGrid();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {
            try
            {
                int idSelecionada = Convert.ToInt32(dataGridTipoAnalise.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridTipoAnalise.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja editar: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdicionarTipoAnaliseVisual View = new AdicionarTipoAnaliseVisual("Editar Tipo Análise", idSelecionada, nameSelecionada);
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
                int idSelecionada = Convert.ToInt32(dataGridTipoAnalise.CurrentRow.Cells[0].Value.ToString());
                string nameSelecionada = dataGridTipoAnalise.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show($"Deseja Excluir: {nameSelecionada}?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = new TipoAnaliseNegocio().Excluir(idSelecionada);
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Buscar(txt_Pesquisa.Text);
        }

        private void txt_Solicitacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar(txt_Pesquisa.Text);
            }
        }
    }
}
