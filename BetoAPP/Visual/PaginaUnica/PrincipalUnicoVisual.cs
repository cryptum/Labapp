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
            //new GerarQuardriculado().AbreVisualizadorPadrao(caminho);
            //using (var pd = new System.Drawing.Printing.PrintDocument())
            //{
            //    pd.PrinterSettings.PrinterName = impressoraComboBox.SelectedItem.ToString();
            //    pd.PrinterSettings.
            //    pd.PrintPage += Pd_PrintPage;
            //    pd.Print();
            //}
        }
    }
}
