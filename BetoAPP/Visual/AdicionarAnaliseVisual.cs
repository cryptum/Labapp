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
    public partial class AdicionarAnaliseVisual : Form
    {
        public AdicionarAnaliseVisual()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarFosforo
                (
                    Double.Parse(N1_P.Text),
                    Double.Parse(N1_DiluicaoP.Text)
                );

            MessageBox.Show($"Resultado Fosforo: {result}");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarPotassio
                (
                    Double.Parse(N1_K.Text)
                );

            MessageBox.Show($"Resultado Potassio: {result}");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarCalcio
                (
                    Double.Parse(N1_Ca.Text)
                );

            MessageBox.Show($"Resultado Calcio: {result}");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarMagnesio
                            (
                                Double.Parse(N1_Mg.Text)
                            );

            MessageBox.Show($"Resultado Magnesio: {result}");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarAluminio
                            (
                                Double.Parse(N1_Al.Text)
                            );

            MessageBox.Show($"Resultado Aluminio: {result}");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var result = new ProcessamentoConcentracao().ProcessarAcidoPotencial
                            (
                                Double.Parse(N1_HAl.Text)
                            );

            MessageBox.Show($"Resultado Acido: {result}");
        }
    }
}
