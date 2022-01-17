using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class BuscarProprietarioVisual : Form
    {
        public int IdProprietario { get; set; }
        public string NomeProprietario { get; set; }
        public BuscarProprietarioVisual()
        {
            InitializeComponent();
        }

        void RecarregarGrid()
        {
            dataGridProprietario.DataSource = new ProprietarioNegocio().ObterTodos();

            dataGridProprietario.Columns[0].Width = 90;
            dataGridProprietario.Columns[1].Width = 305;
            dataGridProprietario.Columns[2].Width = 120;
            dataGridProprietario.Columns[3].Width = 110;

            dataGridProprietario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProprietario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridProprietario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridProprietario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BuscarProprietario_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void dataGridProprietario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarProprietario();
        }

        private void dataGridProprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelecionarProprietario();
            }
        }

        void SelecionarProprietario()
        {
            this.IdProprietario = Convert.ToInt32(dataGridProprietario.CurrentRow.Cells[0].Value.ToString());
            this.NomeProprietario = dataGridProprietario.CurrentRow.Cells[1].Value.ToString();
            this.Dispose();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
