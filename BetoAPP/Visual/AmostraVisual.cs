using LabAPP.Util;
using Negocio;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Environments = Repositorio.Config.Environments;

namespace LabAPP.Visual
{
    public partial class AmostraVisual : Form
    {
        private static AmostraVisual aForm = null;
        public static AmostraVisual Instance(Environments env)
        {
            if (aForm == null)
            {
                aForm = new AmostraVisual(env);
            }
            return aForm;
        }

        Environments GlobalEnv;

        public AmostraVisual(Environments env)
        {
            InitializeComponent();
            GlobalEnv = env;
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pcbCarregar.Visible = true;
                    pcbCarregar.BringToFront();
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    pcbCarregar.Visible = false;
                    pcbCarregar.SendToBack();
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }


        void AlinharGrid()
        {
            dataGridAnalise.Columns[0].Width = 100;
            dataGridAnalise.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridAnalise.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridAnalise.Columns[1].Width = 300;
            //dataGridAnalise.Columns[2].Width = 195;
            //dataGridAnalise.Columns[3].Width = 120;
            //dataGridAnalise.Columns[4].Width = 120;
            //dataGridAnalise.Columns[5].Width = 150;
        }

        public void RecarregarGrid()
        {
            dataGridAnalise.DataSource = new AnaliseNegocio().ObterTodosImcompleta();
            AlinharGrid();
        }

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void btn_Adicionar_Amostra_Click(object sender, EventArgs e)
        {
            if (dataGridAnalise.CurrentRow != null)
            {
                int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());
                this.Visible = false;
                AdicionarAnaliseVisual View = new AdicionarAnaliseVisual(GlobalEnv, "Adicionar Amostras", idSelecionada, "");
                View.ShowDialog();
                this.Visible = true;
                RecarregarGrid();
            }
        }

        private void btn_ImprimeQuadriculado_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInput = new Thread(x =>
                {
                    SetLoading(true);

                    new GerarQuardriculado().Gerar();

                    SetLoading(false);
                }
                    );
                threadInput.Start();

            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_ImprimeLaudo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAnalise.CurrentRow != null)
                {
                    Thread threadInput = new Thread(x =>
                    {
                        SetLoading(true);

                        int idSelecionada = Convert.ToInt32(dataGridAnalise.CurrentRow.Cells[0].Value.ToString());

                        var analise = new AnaliseNegocio().ObterUmPorCodigo(idSelecionada);
                        var amostra = new AmostraNegocio().ObterAmostrarPorIdAnalise(idSelecionada);
                        new GerarPDF().Gerar(analise, amostra);

                        SetLoading(false);
                    });
                    threadInput.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AmostraVisual_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
            AlinharGrid();
        }

        private void dataGridAnalise_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAnalise.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Completa")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(77, 228, 102);
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(230, 236, 63);
            }
        }
    }
}
