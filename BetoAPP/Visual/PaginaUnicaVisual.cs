using Entidade;
using Negocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class PaginaUnicaVisual : Form
    {
        public PaginaUnicaVisual()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Util.Util.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panel1.BringToFront();
        }

        void RecarregarGrid()
        {
            dataGridView1.Rows[0].Cells[1].Value = "Número";
            dataGridView1.Rows[0].Cells[1].Value = "Nome";
            dataGridView1.Rows[0].Cells[1].Value = "Diluição";
            dataGridView1.Rows[0].Cells[1].Value = "PHÁgua";
            dataGridView1.Rows[0].Cells[1].Value = "Fóforo";
            dataGridView1.Rows[0].Cells[1].Value = "Fóforo";
            dataGridView1.Rows[0].Cells[1].Value = "Potássio";
            dataGridView1.Rows[0].Cells[1].Value = "Cálcio";
            dataGridView1.Rows[0].Cells[1].Value = "Magnésio";
            dataGridView1.Rows[0].Cells[1].Value = "Alumínio";
            dataGridView1.Rows[0].Cells[1].Value = "Acidez Potencial";
            dataGridView1.Rows[0].Cells[1].Value = "Zinco";
            dataGridView1.Rows[0].Cells[1].Value = "Cobre";
            dataGridView1.Rows[0].Cells[1].Value = "Ferro";
            dataGridView1.Rows[0].Cells[1].Value = "Manganês";
            dataGridView1.Rows[0].Cells[1].Value = "Argila M.I.";
            dataGridView1.Rows[0].Cells[1].Value = "Argila M.F.";
            dataGridView1.Rows[0].Cells[1].Value = "Areia M.I.";
            dataGridView1.Rows[0].Cells[1].Value = "Areia M.F.";
            dataGridView1.Rows[0].Cells[1].Value = "Silte M.I.";
            dataGridView1.Rows[0].Cells[1].Value = "Silte M.F.";
            dataGridView1.Rows[0].Cells[1].Value = "Boro";
            dataGridView1.Rows[0].Cells[1].Value = "Enxofre";
            dataGridView1.Rows[0].Cells[1].Value = "M. Orgânica";

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!cbx_TipoAnalise.Items.Contains(cbx_TipoAnalise.Text))
            {
                new TipoAnaliseNegocio().Salvar(cbx_TipoAnalise.Text);
            }




            //var result = new ProprietarioNegocio().Salvar(cbxNomeCliente.Text, txtCpfCnpj.Text, txtAnotacao.Text);
            //if (result > 0)
            //{
            //    MessageBox.Show($"Usuario {result} adicionado");
            //    Console.WriteLine("button1_Click  001");
            //}
            Console.WriteLine("button1_Click  002");
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var result = new ProprietarioNegocio().ObterUmPorNome(cbx_NomeCliente.Text);
            if (result.Cpf.Length <= 14)
            {
                //cpf
                cbx_CpfCnpj.SelectedIndex = 0;
            }
            else if (result.Cpf.Length >= 18)
            {
                //cnpj
                cbx_CpfCnpj.SelectedIndex = 1;
            }
            txt_CpfCnpj.Text = result.Cpf;
            txt_Anotacao.Text = result.Observacao;

            if (result.Fazendas != null)
            {
                foreach (var item in result.Fazendas)
                {
                    //cbxNomeCliente.Items.Clear();
                    cbx_Fazenda.Items.Add(item.Fazenda);
                }
            }
        }

        private void cbx_Fazenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = new FazendaNegocio().ObterUmPorNomeEProprietario(cbx_Fazenda.Text, cbx_NomeCliente.Text);
            txt_Municipio.Text = result.Municipio;
        }

        private void cbxNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbx_NomeCliente.Text.Length != 0)
            {
                var result = new ProprietarioNegocio().ObterListaPorNome(cbx_NomeCliente.Text);
                foreach (var item in result)
                {
                    //cbxNomeCliente.Items.Clear();
                    cbx_NomeCliente.Items.Add(item.Nome);
                }
            }

            //if (cbxNomeCliente.Text.Length <= 1 && e.KeyCode == Keys.Back)
            //{
            //    cbxNomeCliente.Text = "";
            //}
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void PaginaUnicaVisual_Load(object sender, EventArgs e)
        {

            cbx_CpfCnpj.Items.Add("CPF");
            cbx_CpfCnpj.Items.Add("CNPJ");
            cbx_CpfCnpj.SelectedIndex = 0;

            var nomesTipoAnalise = new TipoAnaliseNegocio().ObterTodos();

            for (int i = 0; i < nomesTipoAnalise.Count(); i++)
            {
                cbx_TipoAnalise.Items.Add(nomesTipoAnalise[i].Nome);
            }

            var nomesCultura = new CulturaNegocio().ObterTodos();
            for (int i = 0; i < nomesCultura.Count(); i++)
            {
                cbx_Cultura.Items.Add(nomesCultura[i].Nome);
            }

            var nomesSolicitacao = new ConvenioNegocio().ObterTodos();
            for (int i = 0; i < nomesSolicitacao.Count(); i++)
            {
                cbx_Convenio.Items.Add(nomesSolicitacao[i].Nome);
            }
        }
    }
}