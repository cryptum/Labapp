using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class AdicionarFazendaVisual : Form
    {
        public int IdInicial { get; set; }
        public int idProprietario { get; set; }
        public AdicionarFazendaVisual(string titulo, int idInicial, string valorFazenda, string valorMunicipio, int idProprietario)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtFazenda.Text = valorFazenda;
            txtMunicipio.Text = valorMunicipio;
            this.idProprietario = idProprietario;
            IdInicial = idInicial;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text == "Adicionar Fazenda")
                {
                    var result = new FazendaNegocio().Salvar(txtFazenda.Text, txtMunicipio.Text, idProprietario);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtFazenda.Text = "";
                        txtMunicipio.Text = "";
                        txtFazenda.Focus();
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (txtTitulo.Text == "Editar Fazenda")
                {
                    var result = new FazendaNegocio().Editar(this.IdInicial, txtFazenda.Text, txtMunicipio.Text, idProprietario);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
