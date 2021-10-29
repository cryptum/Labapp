using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionaUsuarioVisual : Form
    {
        public AdicionaUsuarioVisual()
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


        private void btn_Edita_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {


        }

        private void AdicionaUsuarioVisual_Load(object sender, EventArgs e)
        {

        }
    }
}
