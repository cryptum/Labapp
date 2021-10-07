using System;
using System.Drawing;
using System.Windows.Forms;


namespace BetoAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        public PrincipalVisual(Guid IdUsuarioLogado,String Usuariologado)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = Usuariologado;


            //Remover Depois
            SolicitanteVisual View = SolicitanteVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void analiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliseVisual View = AnaliseVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitanteVisual View = SolicitanteVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVisual View = RelatorioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UsuarioView View = new UsuarioView();

            ////View.TopLevel = false;
            ////View.Location = new Point((panel1.Size.Width / 2) - (View.Size.Width / 2), (panel1.Size.Height / 2) - (View.Size.Height / 2));
            //panel1.Controls.Add(View);
            //View.Show();

            UsuarioVisual View = UsuarioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void culturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CulturaVisual View = CulturaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void referenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenciaVisual View = ReferenciaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoAnaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnaliseVisual View = TipoAnaliseVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoSolicitacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSolicitacaoVisual View = TipoSolicitacaoVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }
    }
}
