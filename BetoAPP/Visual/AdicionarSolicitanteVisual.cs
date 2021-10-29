using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarSolicitanteVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionarSolicitanteVisual(string titulo, int idInicial, string valorInicial)
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTitulo.Text == "Adicionar Cliente")
                {
                    var result = new SolicitanteNegocio().Salvar(txtNome.Text, txtCpf.Text, txtObservacao.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!");
                    }
                }
                else if (txtTitulo.Text == "Editar Cliente")
                {
                    var result = new SolicitanteNegocio().Editar(this.IdInicial, txtNome.Text, txtCpf.Text, txtObservacao.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!");

                    }
                }
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
