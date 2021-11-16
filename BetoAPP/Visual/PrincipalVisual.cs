using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace BetoAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        public PrincipalVisual(int IdUsuarioLogado, string Usuariologado, bool hierarquia)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = Usuariologado;
            //this.menuStrip1.BackColor = Color.GhostWhite;
            this.btnDarkAndLight.Visible = false;

            if (hierarquia)
            {
                colaboradoresToolStripMenuItem.Visible = true;
            }
            else
            {
                colaboradoresToolStripMenuItem.Visible = false;
            }
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

        private void amostratoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmostraVisual View = AmostraVisual.Instance();
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

        private void btnDarkAndLight_Click(object sender, EventArgs e)
        {
            if (menuStrip1.BackColor == Color.GhostWhite)
            {
                btnDarkAndLight.Image = Properties.Resources.sun_fill_White_36px;

                this.menuStrip1.BackColor = Color.DarkSlateGray;
                this.menuStrip1.ForeColor = Color.White;

                this.statusStrip1.BackColor = Color.DarkSlateGray;
                this.statusStrip1.ForeColor = Color.White;

                Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.DarkSlateGray;

                clienteToolStripMenuItem.Image = Properties.Resources.user_fill_Branco_36px;
                analiseToolStripMenuItem.Image = Properties.Resources.microscope_fill_Branco_36px;
                amostratoolStripMenuItem.Image = Properties.Resources.test_tube_Branco_36px;
                culturatoolStripMenuItem.Image = Properties.Resources.plant_fill_Branco_36px;
                referenciatoolStripMenuItem.Image = Properties.Resources.pin_fill_Branco_36px;
                solicitantetoolStripMenuItem.Image = Properties.Resources.request_fill_Branco_36px;
                tipoanalisetoolStripMenuItem.Image = Properties.Resources.flask_Branco_36px;
                colaboradoresToolStripMenuItem.Image = Properties.Resources.shield_fill_Branco_36px;
            }
            else
            {
                btnDarkAndLight.Image = Properties.Resources.sun_fill_Dark_36px;
                this.menuStrip1.BackColor = Color.White;
                this.menuStrip1.ForeColor = Color.Black;

                this.statusStrip1.BackColor = Color.White;
                this.statusStrip1.ForeColor = Color.Black;

                Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;

                clienteToolStripMenuItem.Image = Properties.Resources.user_fill_36px;
                analiseToolStripMenuItem.Image = Properties.Resources.microscope_fill_36px;
                amostratoolStripMenuItem.Image = Properties.Resources.test_tube_azul_36px;
                culturatoolStripMenuItem.Image = Properties.Resources.plant_fill_36px;
                referenciatoolStripMenuItem.Image = Properties.Resources.pin_fill_36px;
                solicitantetoolStripMenuItem.Image = Properties.Resources.request_fill_36px;
                tipoanalisetoolStripMenuItem.Image = Properties.Resources.flask_fill_36px;
                colaboradoresToolStripMenuItem.Image = Properties.Resources.sheld_fill_36px;


            }
        }

        private void PrincipalVisual_Load(object sender, EventArgs e)
        {
            foreach (Control ctrlControl in this.Controls)
            {
                if (ctrlControl is MdiClient)
                {
                    BackgroundImage = Properties.Resources.AgroFrutal;
                    BackgroundImageLayout = ImageLayout.Center;
                }
            }
        }
    }
}