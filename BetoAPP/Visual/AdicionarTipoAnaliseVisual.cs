using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarTipoAnaliseVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionarTipoAnaliseVisual(string titulo, int idInicial, string valorInicial)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtNome.Text = valorInicial;
            IdInicial = idInicial;
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

        private void btn_Cancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text == "Adicionar Tipo Análise")
                {
                    var result = new TipoAnaliseNegocio().Salvar(txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Text = "";
                        txtNome.Focus();
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (txtTitulo.Text == "Editar Tipo Análise")
                {
                    var result = new TipoAnaliseNegocio().Editar(this.IdInicial, txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
