using BetoAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace BetoAPP.Visual
{
    public partial class AdicionarProprietarioVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionarProprietarioVisual(string titulo, int idInicial, string nome, string cpfCnpj, string obs)
        {
            InitializeComponent();
            cbxCPF_CNPJ.Items.Add("CPF");
            cbxCPF_CNPJ.Items.Add("CNPJ");
            cbxCPF_CNPJ.SelectedIndex = 0;
            txtTitulo.Text = titulo;
            IdInicial = idInicial;
            txtNome.Text = nome;
            txtObservacao.Text = obs;
            if (cpfCnpj.Length == 14)
            {//is cpf
                cbxCPF_CNPJ.SelectedIndex = 0;
                txtCpf.Text = cpfCnpj;
            }
            else
            {//is cnpj
                cbxCPF_CNPJ.SelectedIndex = 1;
                txtCpf.Text = cpfCnpj;
            }
        }

        //private void SetLoading(bool displayLoader)
        //{
        //    if (displayLoader)
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = true;
        //            pcbCarregar.BringToFront();
        //            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        //        });
        //    }
        //    else
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            pcbCarregar.Visible = false;
        //            pcbCarregar.SendToBack();
        //            this.Cursor = System.Windows.Forms.Cursors.Default;
        //        });
        //    }
        //}

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTitulo.Text == "Adicionar Proprietário")
                {
                    var result = new ProprietarioNegocio().Salvar(txtNome.Text, txtCpf.Text, txtObservacao.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (txtTitulo.Text == "Editar Proprietário")
                {
                    var result = new ProprietarioNegocio().Editar(this.IdInicial, txtNome.Text, txtCpf.Text, txtObservacao.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbxCPF_CNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCPF_CNPJ.Text)
            {
                case "CPF":
                    txtCpf.Mask = "000,000,000-00";
                    break;

                case "CNPJ":
                    txtCpf.Mask = "00,000,000/0000-00";
                    break;

                default:
                    break;
            }
        }
    }
}
