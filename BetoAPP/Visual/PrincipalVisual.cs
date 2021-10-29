using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace BetoAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        public PrincipalVisual(int IdUsuarioLogado, String Usuariologado)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = Usuariologado;
            this.menuStrip1.BackColor = Color.GhostWhite;
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

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioVisual View = UsuarioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void solicitantetoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TipoSolicitacaoVisual View = TipoSolicitacaoVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoanalisetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnaliseVisual View = TipoAnaliseVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void referenciatoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReferenciaVisual View = ReferenciaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void culturatoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CulturaVisual View = CulturaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (menuStrip1.BackColor == Color.GhostWhite)
            {
                toolStripSplitButton1.Image = Properties.Resources.sun_fill_Dark_36px;
                this.menuStrip1.BackColor = Color.DimGray;
                this.menuStrip1.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                toolStripSplitButton1.Image = Properties.Resources.sun_fill_White_36px;
                this.menuStrip1.BackColor = Color.GhostWhite;
                this.menuStrip1.ForeColor = Color.DimGray;
            }
        }
    }
}