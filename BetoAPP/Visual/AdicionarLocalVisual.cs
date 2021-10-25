using BetoAPP.Util;
using Negocio;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarLocalVisual : Form
    {
        public int IdInicial { get; set; }
        public int IdSolicitante { get; set; }
        public AdicionarLocalVisual(string titulo, int idInicial, string valorFazenda, string valorMunicipio, int idSolicitante)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtFazenda.Text = valorFazenda;
            txtMunicipio.Text = valorMunicipio;
            IdSolicitante = idSolicitante;
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
                if (txtTitulo.Text == "Adicionar Local")
                {
                    var result = new LocalNegocio().Salvar(txtFazenda.Text, txtMunicipio.Text, IdSolicitante);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!");
                    }
                }
                else if (txtTitulo.Text == "Editar Local")
                {
                    var result = new LocalNegocio().Editar(this.IdInicial, txtFazenda.Text, txtMunicipio.Text, IdSolicitante);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
