using BetoAPP.Visual;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetoAPP
{
    public partial class LoginVisual : Form
    {

        public LoginVisual()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnl_Usuario.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, pnl_Usuario.Width, pnl_Usuario.Height, 5, 5));
            pnl_Senha.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, pnl_Senha.Width, pnl_Senha.Height, 5, 5));
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Sair_MouseLeave(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_line;
        }

        private void btn_Sair_MouseHover(object sender, EventArgs e)
        {
            btn_Sair.Image = Properties.Resources.close_line1;
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            var resultado = new UsuarioNegocio().ValidarAcesso(txt_Usuario.Text, txt_Senha.Text);

            if (resultado.AcessoPermitido == true)
            {
                PrincipalVisual ViewPrincipal = new PrincipalVisual(resultado.IdUsuario, resultado.Nome);
                this.Hide();
                ViewPrincipal.Show();
            }
            else
            {
                MessageBox.Show(resultado.AcessoMessagem);
            }
            
        }

        private void btn_Acessar_Paint(object sender, PaintEventArgs e)
        {
            btn_Acessar.Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, btn_Acessar.Width, btn_Acessar.Height, 15, 15));
        }

        private void btn_Minimiza_MouseHover(object sender, EventArgs e)
        {
            btn_Minimiza.Image = Properties.Resources.subtract_line__1_;
        }

        private void btn_Minimiza_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimiza.Image = Properties.Resources.subtract_line;

        }

        private void btn_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
