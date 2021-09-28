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
    public partial class TipoSolicitacaoVisual : Form
    {
        private static TipoSolicitacaoVisual aForm = null;
        public static TipoSolicitacaoVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new TipoSolicitacaoVisual();
            }
            return aForm;
        }
        public TipoSolicitacaoVisual()
        {
            InitializeComponent();
        }
    }
}
