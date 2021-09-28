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
    public partial class AdicionarCulturaView : Form
    {
        public int IdInicial { get; set; }
        public AdicionarCulturaView(string titulo, int idInicial, string valorInicial)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtNome.Text = valorInicial;
            IdInicial= idInicial;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text =="Adicionar Cultura")
                {
                    var result = new CulturaNegocio().Salvar(txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    txtNome.Text = "";
                    txtNome.Focus();
                    MessageBox.Show("Salvo!");
                }
                else if (txtTitulo.Text == "Editar Cultura")
                {
                    var result = new CulturaNegocio().Editar(this.IdInicial, txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    txtNome.Text = "";
                    txtNome.Focus();
                    MessageBox.Show("Salvo!");
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
