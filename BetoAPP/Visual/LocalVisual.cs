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
    public partial class LocalVisual : Form
    {
        private static LocalVisual aForm = null;
        public static LocalVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new LocalVisual();
            }
            return aForm;
        }
        public LocalVisual()
        {
            InitializeComponent();
        }
        private void LocalVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {

        }

        
    }
}
