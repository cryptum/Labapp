﻿using LabAPP.Util;
using Negocio;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual
{
    public partial class AdicionarCulturaVisual : Form
    {
        public int IdInicial { get; set; }
        public AdicionarCulturaVisual(string titulo, int idInicial, string valorInicial)
        {
            InitializeComponent();
            txtTitulo.Text = titulo;
            txtNome.Text = valorInicial;
            IdInicial = idInicial;
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitulo.Text == "Adicionar Cultura")
                {
                    var result = new CulturaNegocio().Salvar(txtNome.Text);
                    if (result == 0)
                    {
                        MessageBox.Show(Mensagem.NDeuCerto.Value, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Text = "";
                        txtNome.Focus();
                        MessageBox.Show("Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (txtTitulo.Text == "Editar Cultura")
                {
                    var result = new CulturaNegocio().Editar(this.IdInicial, txtNome.Text);
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

        private void btn_Cancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
