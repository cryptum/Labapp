using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;


namespace LabAPP.Visual
{
    public partial class PrincipalVisual : Form
    {
        Environments GlobalEnv;
        public PrincipalVisual(Environments env, int idUsuarioLogado, string usuarioLogado, bool hierarquia)
        {
            InitializeComponent();
            lbl_UsuarioLogado.Text = usuarioLogado;
            //this.menuStrip1.BackColor = Color.GhostWhite;
            this.btnDarkAndLight.Visible = false;
            this.referenciaToolStripMenuItem.Visible = false;
            _ = hierarquia == true ? colaboradoresToolStripMenuItem.Visible = true : colaboradoresToolStripMenuItem.Visible = false;

            GlobalEnv = env;
            switch (env)
            {
                case Environments.beto:
                    ordemToolStripMenuItem.Visible = false;
                    break;
                case Environments.betoInMemory:
                    ordemToolStripMenuItem.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void analiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaliseVisual View = AnaliseVisual.Instance(GlobalEnv);
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void amostraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmostraVisual View = AmostraVisual.Instance(GlobalEnv);
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProprietarioVisual View = ProprietarioVisual.Instance();
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

        private void convenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvenioVisual View = ConvenioVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void tipoanaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoAnaliseVisual View = TipoAnaliseVisual.Instance();
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

        private void culturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CulturaVisual View = CulturaVisual.Instance();
            View.MdiParent = this;
            View.Show();
            View.Activate();
        }

        private void ordemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrdemServico View = OrdemServico.Instance();
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

                proprietarioToolStripMenuItem.Image = Properties.Resources.user_fill_Branco_36px;
                analiseToolStripMenuItem.Image = Properties.Resources.microscope_fill_Branco_36px;
                amostraToolStripMenuItem.Image = Properties.Resources.test_tube_Branco_36px;
                culturaToolStripMenuItem.Image = Properties.Resources.plant_fill_Branco_36px;
                referenciaToolStripMenuItem.Image = Properties.Resources.pin_fill_Branco_36px;
                convenioToolStripMenuItem.Image = Properties.Resources.request_fill_Branco_36px;
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

                proprietarioToolStripMenuItem.Image = Properties.Resources.user_fill_36px;
                analiseToolStripMenuItem.Image = Properties.Resources.microscope_fill_36px;
                amostraToolStripMenuItem.Image = Properties.Resources.test_tube_azul_36px;
                culturaToolStripMenuItem.Image = Properties.Resources.plant_fill_36px;
                referenciaToolStripMenuItem.Image = Properties.Resources.pin_fill_36px;
                convenioToolStripMenuItem.Image = Properties.Resources.request_fill_36px;
                tipoanalisetoolStripMenuItem.Image = Properties.Resources.flask_fill_36px;
                colaboradoresToolStripMenuItem.Image = Properties.Resources.shield_user_fill;


            }
        }

        private void PrincipalVisual_Load(object sender, EventArgs e)
        {
            foreach (Control ctrlControl in this.Controls)
            {
                if (ctrlControl is MdiClient)
                {
                    BackgroundImage = Properties.Resources.Preisser;
                    BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
    }
}