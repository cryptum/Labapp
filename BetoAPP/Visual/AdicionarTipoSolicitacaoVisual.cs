using BetoAPP.Util;
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
    public partial class AdicionarTipoSolicitacaoVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionarTipoSolicitacaoVisual(string titulo, int idInicial, string valorInicial)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtNome.Text = valorInicial;
            IdInicial = idInicial;
        }

        private void btn_Cancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text == "Adicionar Tipo Solicitação")
                {
                    var result = new TipoSolicitacaoNegocio().Salvar(txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Text = "";
                        txtNome.Focus();
                        MessageBox.Show("Salvo!");
                    }
                }
                else if (txtTitulo.Text == "Editar Tipo Solicitação")
                {
                    var result = new TipoSolicitacaoNegocio().Editar(this.IdInicial, txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Text = "";
                        txtNome.Focus();
                        MessageBox.Show("Salvo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }
    }
}
