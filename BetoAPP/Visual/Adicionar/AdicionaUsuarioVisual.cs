using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class AdicionaUsuarioVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionaUsuarioVisual(string titulo, int idInicial, string valorInicial)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtNome.Text = valorInicial;
            IdInicial = idInicial;
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {

            bool adm = radioAdmin.Checked ? true : false;
            bool blok = radioBloqueio.Checked ? true : false;

            try
            {
                if (txtTitulo.Text == "Adicionar Usuário")
                {
                    var result = new UsuarioNegocio().Salvar(txtNome.Text, txtAcesso.Text, txtSenha.Text, adm, blok);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Text = "";
                        txtAcesso.Text = "";
                        txtSenha.Text = "";
                        radioAdmin.Checked = false;
                        radioColab.Checked = false;
                        radioAcesso.Checked = false;
                        radioBloqueio.Checked = false;
                        txtNome.Text = "";
                        txtNome.Focus();
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (txtTitulo.Text == "Editar Usuário")
                {
                    var result = new UsuarioNegocio().Editar(this.IdInicial, txtNome.Text, txtAcesso.Text, txtSenha.Text, adm, blok);
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
                MessageBox.Show(Mensagem.ErroThread.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            radioColab.Checked = false;
        }

        private void radioColab_CheckedChanged(object sender, EventArgs e)
        {
            radioAdmin.Checked = false;
        }

        private void radioAcesso_CheckedChanged(object sender, EventArgs e)
        {
            radioBloqueio.Checked = false;
        }

        private void radioBloqueio_CheckedChanged(object sender, EventArgs e)
        {
            radioAcesso.Checked = false;
        }
    }
}
