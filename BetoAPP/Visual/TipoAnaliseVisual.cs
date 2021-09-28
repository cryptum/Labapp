using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class TipoAnaliseVisual : Form
    {
        private static TipoAnaliseVisual aForm = null;
        public static TipoAnaliseVisual Instance()
        {
            if (aForm == null)
            {
                aForm = new TipoAnaliseVisual();
            }
            return aForm;
        }
        public TipoAnaliseVisual()
        {
            InitializeComponent();
        }


        private void TipoAnalise_Load(object sender, EventArgs e)
        {

            
            //dataGridSolicitacao.DataSource = new TipoAnaliseNegocio().CarregamentoInicial();


            //_context = new ContextDB();
            //dataGridView1.DataSource = _context.Alunos.Select(x => new AnaliseModelo { IdAnalise = x.IdAnalise, DataEntrada = x.DataEntrada });

            //dataGridView1.DataSource = _context.Alunos.Local.ToBindingList();
        }
    }
}
