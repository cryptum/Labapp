using System;
using System.Windows.Forms;


namespace BetoAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        public PrincipalVisual(Guid IdUsuarioLogado,String Usuariologado)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = Usuariologado;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var frm = new TipoAnaliseVisual();
            //frm.MdiParent = this;
            //frm.Show();


            TipoAnaliseVisual ViewLogin = new TipoAnaliseVisual();
            ViewLogin.TopLevel = true;
            panel1.Controls.Add(ViewLogin);
            ViewLogin.Show();

        }

        private void analiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliseVisual View = new AnaliseVisual();
            

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitanteVisual View = new SolicitanteVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioVisual View = new RelatorioVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioView View = new UsuarioView();
            View.TopLevel = false;
            panel1.Controls.Add(View);
            View.Show();
        }

        private void culturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CulturaVisual View = new CulturaVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void referenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenciaVisual View = new ReferenciaVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void tipoAnaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnaliseVisual View = new TipoAnaliseVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }

        private void tipoSolicitacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoSolicitacaoVisual View = new TipoSolicitacaoVisual();

                View.TopLevel = false;
                panel1.Controls.Add(View);
                View.Show();
        }
    }
}
