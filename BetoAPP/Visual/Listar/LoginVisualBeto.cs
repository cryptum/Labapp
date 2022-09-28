using Entidade.DTO;
using LabAPP.Visual;
using LabAPP.Visual.PaginaUnica;
using Negocio;
using System;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace LabAPP
{
    public partial class LoginVisualBeto : Form
    {
        Environments GlobalEnv;

        public LoginVisualBeto(Environments env)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btn_LabApp.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, btn_LabApp.Width, btn_LabApp.Height, 5, 5));
            btn_PaginaUnica.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, btn_PaginaUnica.Width, btn_PaginaUnica.Height, 5, 5));
            GlobalEnv = env;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Sair_MouseLeave(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_cinza_24px;
        }

        private void btn_Sair_MouseHover(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_vermelho_24px;
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            try
            {
                //UsuarioDTO resultado = new UsuarioNegocio().ValidarAcesso(txt_Usuario.Text.Trim(), txt_Senha.Text.Trim());
                //if (resultado.AcessoPermitido == true)
                //{
                //    PrincipalVisual ViewPrincipal = new PrincipalVisual(GlobalEnv, resultado.Código, resultado.Nome, resultado.Administrador);
                //    this.Hide();
                //    ViewPrincipal.Show();
                //}
                //else
                //{
                //    MessageBox.Show(resultado.AcessoMessagem);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void btn_Acessar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_Minimiza_MouseHover(object sender, EventArgs e)
        {
            btn_Minimiza.Image = Properties.Resources.subtract_vermelho_24px;
        }

        private void btn_Minimiza_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimiza.Image = Properties.Resources.subtract_cinza_24px;
        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_LabApp_Click(object sender, EventArgs e)
        {
            PrincipalVisual ViewPrincipal = new PrincipalVisual(GlobalEnv, 0, "user", true);
            this.Hide();
            ViewPrincipal.Show();
        }

        private void btn_PaginaUnica_Click(object sender, EventArgs e)
        {
            PrincipalUnicoVisual ViewPrincipal = new PrincipalUnicoVisual();
            this.Hide();
            ViewPrincipal.Show();
        }
    }
}
