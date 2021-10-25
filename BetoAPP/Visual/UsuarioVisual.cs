using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class UsuarioVisual : Form
    {
        private static UsuarioVisual aForm = null;
        public static UsuarioVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new UsuarioVisual();
            }
            return aForm;
        }
        public UsuarioVisual()
        {
            InitializeComponent();
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


        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionaUsuarioVisual View = new AdicionaUsuarioVisual();
            View.ShowDialog();
        }

        private void btn_Recarrega_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Thread threadInput = new Thread(x =>
            //    {
            //        SetLoading(true);


            //        SetLoading(false);
            //    }
            //        );
            //    threadInput.Start();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

        }
    }
}
