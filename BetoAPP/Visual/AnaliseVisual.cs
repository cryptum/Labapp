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
            cbx_Pesquisa.Items.Add("Solicitante");
            cbx_Pesquisa.Items.Add("Laudo");
        }

        

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            AdicionarAnaliseVisual View = new AdicionarAnaliseVisual();
            View.ShowDialog();
        }

        private void btn_Edita_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exclui_Click(object sender, EventArgs e)
        {

        }

        private void btn_LimparTodosOsCampos_Click(object sender, EventArgs e)
        {

        }

        private void btn_ImprimeQuadriculado_Click(object sender, EventArgs e)
        {
            new GerarQuardriculado().Gerar();
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
