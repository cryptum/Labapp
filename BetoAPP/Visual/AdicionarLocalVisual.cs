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
    public partial class AdicionarLocalVisual : Form
    {
        public int IdInicial { get; set; }
        public int IdSolicitante { get; set; }
        public AdicionarLocalVisual(string titulo, int idInicial, string valorFazenda, string valorMunicipio, int idSolicitante)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtFazenda.Text = valorFazenda;
            txtMunicipio.Text = valorMunicipio;
            IdSolicitante = idSolicitante;
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
                if (txtTitulo.Text == "Adicionar Local")
                {
                    var result = new LocalNegocio().Salvar(txtFazenda.Text, txtMunicipio.Text, IdSolicitante);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtFazenda.Text = "";
                        txtMunicipio.Text = "";
                        txtFazenda.Focus();
                        MessageBox.Show("Salvo!");
                    }
                }
                else if (txtTitulo.Text == "Editar Local")
                {
                    var result = new LocalNegocio().Editar(this.IdInicial, txtFazenda.Text, txtMunicipio.Text, IdSolicitante);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtFazenda.Text = "";
                        txtMunicipio.Text = "";
                        txtFazenda.Focus();
                        MessageBox.Show("Salvo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
