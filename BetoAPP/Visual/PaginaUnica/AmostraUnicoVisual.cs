using Entidade;
using System;
using System.Windows.Forms;

namespace LabAPP.Visual.PaginaUnica
{
    public partial class AmostraUnicoVisual : Form
    {
        public AmostraEntidade Amostra { get; set; }

        public AmostraUnicoVisual()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Nome'");
                return;
            }

            if (txt_numero.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Número'");
                return;
            }

            AmostraEntidade amostra = new AmostraEntidade();

            amostra.NumeroAmostra = txt_numero.Text;
            amostra.NomeAmostra = txt_Nome.Text;
            amostra.Ph_Agua = txt_PhAgua.Text;
            amostra.Diluicao = txt_Diluicao.Text;
            amostra.P_Fosforo = txt_Fosforo.Text;
            amostra.K_Potassio = txt_Potassio.Text;
            amostra.Ca_Calcio = txt_Calcio.Text;
            amostra.Al_Aluminio = txt_Aluminio.Text;
            amostra.Mg_Magnesio = txt_Magnesio.Text;
            amostra.Alh_AcidezPotencial = txt_AcidezPotencial.Text;
            amostra.Zn_Zinco = txt_Zinco.Text;
            amostra.Cu_Cobre = txt_Cobre.Text;
            amostra.Fe_Ferro = txt_Ferro.Text;
            amostra.Mn_manganes = txt_Manganes.Text;
            amostra.Argila_Inicio = txt_Argila_Inicio.Text;
            amostra.Argila_Fim = txt_Argila_Fim.Text;
            amostra.Areia_Inicio = txt_Areia_Inicio.Text;
            amostra.Areia_Fim = txt_Areia_Fim.Text;
            amostra.Silte_Inicio = txt_Silte_Inicio.Text;
            amostra.Silte_Fim = txt_Silte_Fim.Text;
            amostra.B_Boro = txt_Boro.Text;
            amostra.S_Enxofre = txt_Enxofre.Text;
            amostra.Mo_MateriaOrganica = txt_MateriaOrganica.Text;

            this.Amostra = amostra;

            this.Dispose();
        }
    }
}
