using Entidade.DTO;
using LabAPP.Visual;
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
            pnl_Usuario.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, pnl_Usuario.Width, pnl_Usuario.Height, 5, 5));
            pnl_Senha.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, pnl_Senha.Width, pnl_Senha.Height, 5, 5));
            txt_Usuario.Focus();
            GlobalEnv = env;

            switch (env)
            {
                case Environments.local:
                    txt_Usuario.Text = "admin";
                    txt_Senha.Text = "123";
                    break;
                case Environments.beto:
                    txt_Usuario.Text = "beto";
                    txt_Senha.Text = "123";
                    break;
                case Environments.betoInMemory:
                    txt_Usuario.Text = "admin";
                    txt_Senha.Text = "123";
                    break;
                default:
                    break;
            }
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

        //private void SetLoading(bool displayLoader)
        //{
        //    if (displayLoader)
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = true;
        //            pcbCarregar.BringToFront();
        //            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        //        });
        //    }
        //    else
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = false;
        //            pcbCarregar.SendToBack();
        //            this.Cursor = System.Windows.Forms.Cursors.Default;
        //        });
        //    }
        //}

        public void Login()
        {
            try
            {
                UsuarioDTO resultado = new UsuarioNegocio().ValidarAcesso(txt_Usuario.Text.Trim(), txt_Senha.Text.Trim());
                if (resultado.AcessoPermitido == true)
                {
                    PrincipalVisual ViewPrincipal = new PrincipalVisual(GlobalEnv, resultado.Código, resultado.Nome, resultado.Administrador);
                    this.Hide();
                    ViewPrincipal.Show();
                }
                else
                {
                    MessageBox.Show(resultado.AcessoMessagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Senha.Focus();
                e.Handled = e.SuppressKeyPress = true;
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
            btn_Acessar.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, btn_Acessar.Width, btn_Acessar.Height, 15, 15));
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
    }
}
