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
    public partial class AnaliseVisual : Form
    {
        private static AnaliseVisual aForm = null;
        public static AnaliseVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new AnaliseVisual();
            }
            return aForm;
        }
        public AnaliseVisual()
        {
            InitializeComponent();
        }

        private void btn_ImprimeQuadriculado_Click(object sender, EventArgs e)
        {
            new GerarQuardriculado().Gerar();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarAnaliseVisual View = new AdicionarAnaliseVisual();
            View.ShowDialog();
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
