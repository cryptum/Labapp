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
    public partial class SolicitanteVisual : Form
    {
        private static SolicitanteVisual aForm = null;
        public static SolicitanteVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new SolicitanteVisual();
            }
            return aForm;
        }
        public SolicitanteVisual()
        {
            InitializeComponent();
        }
    }
}
