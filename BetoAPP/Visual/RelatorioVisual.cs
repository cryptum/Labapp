using Negocio;
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
    public partial class RelatorioVisual : Form
    {
        private static RelatorioVisual aForm = null;
        public static RelatorioVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new RelatorioVisual();
            }
            return aForm;
        }
        public RelatorioVisual()
        {
            InitializeComponent();
        }

        private void btn_Imprime_Click(object sender, EventArgs e)
        {
        }
    }
}
