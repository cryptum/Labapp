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
        }

        public void RecarregarGrid()
        {
            dataGridView.DataSource = new AnaliseNegocio().ObterTodosImcompleta();
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
            new GerarQuardriculado().Gerar();
        }
    }
}
