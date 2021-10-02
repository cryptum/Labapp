using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class UsuarioView : Form
    {
        private static UsuarioView aForm = null;
        public static UsuarioView Instance()
        {
            if (aForm == null)
            {
                aForm = new UsuarioView();
            }
            return aForm;
        }
        public UsuarioView()
        {
            InitializeComponent();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionaUsuarioVisual View = new AdicionaUsuarioVisual();
            View.ShowDialog();
        }

        private void btn_Recarrega_Click(object sender, EventArgs e)
        {

        }
    }
}
