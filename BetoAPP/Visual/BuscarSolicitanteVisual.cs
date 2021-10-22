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
    public partial class BuscarSolicitanteVisual : Form
    {
        public int IdSolicitante { get; set; }
        public string NomeSolicitante { get; set; }
        public BuscarSolicitanteVisual()
        {
            InitializeComponent();
        }

        public void RecarregarGrid()
        {
            dataGridSolicitante.DataSource = new SolicitanteNegocio().ObterTodos();

            dataGridSolicitante.Columns[0].Width = 90;
            dataGridSolicitante.Columns[1].Width = 305;
            dataGridSolicitante.Columns[2].Width = 120;
            dataGridSolicitante.Columns[3].Width = 110;

            dataGridSolicitante.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridSolicitante.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridSolicitante.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BuscarSolicitante_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void dataGridSolicitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.IdSolicitante = Convert.ToInt32(dataGridSolicitante.CurrentRow.Cells[0].Value.ToString());
            this.NomeSolicitante = dataGridSolicitante.CurrentRow.Cells[1].Value.ToString();
            this.Dispose();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
