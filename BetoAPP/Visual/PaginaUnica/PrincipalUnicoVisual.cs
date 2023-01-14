using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual.PaginaUnica
{
    public partial class PrincipalUnicoVisual : Form
    {
        public PrincipalUnicoVisual()
        {
            InitializeComponent();
            RecarregarGrid();
        }

        public void RecarregarGrid()
        {
            dataGridView.DataSource = new AnaliseNegocio().ObterTodosPaginaUnica();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnaliseUnicoVisual View = new AnaliseUnicoVisual();
            View.ShowDialog();
            this.Visible = true;
            RecarregarGrid();
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Quadriculado_Click(object sender, EventArgs e)
        {
            var caminho = new GerarQuardriculado().Gerar();
        }

        private void PrincipalUnicoVisual_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
