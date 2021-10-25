using System;

namespace Negocio
{
    public class ProcessamentoConcentracao
    {

        public double ProcessarPH(double pH)
        {
            return Math.Round(pH, 2);
        }

        public double ProcessarFosforo(double P)
        {
            // carregando dados
            double[] xValues = { 0.4, 0.8, 1.2, 1.6 };  // Concentração de P
            double[] yValues = { 0.2240, 0.3850, 0.5100, 0.6020 }; // Absobância

            // encontrando a média do valor das variáveis independentes (eixo x) e dependentes (eixo y)
            double xMedia = 0;
            double yMedia = 0;
            for (int index = 0; index < xValues.Length; index++)
            {
                xMedia += xValues[index];
                yMedia += yValues[index];
            }
            xMedia = xMedia / xValues.Length;
            yMedia = yMedia / yValues.Length;

            // codificando a fórmula para calcular a inclinação
            double dividendo = 0;
            double divisor = 0;
            for (int index = 0; index < xValues.Length; index++)
            {
                // a soma do produto da dispersão das variáveis independentes e dependentes = distâncias entre cada um dos valores e o valor médio daquele eixo = covariância de x e y
                dividendo += (xValues[index] - xMedia) * (yValues[index] - yMedia);
                // a soma do quadrado da dispersão das variáveis independentes (do eixo x)
                divisor += Math.Pow(xValues[index] - xMedia, 2);
            }

            // encontrando a inclinação
            double a = dividendo / divisor;

            // codificando a fórmula para encontrar o ponto onde a linha de tendência intercepta o eixo y
            // a média das variáveis dependentes, subtraido o produto da inclinação com a média das variáveis independentes
            double b = yMedia - a * xMedia;
            a = Math.Round(a, 4);
            b = Math.Round(b, 4);

            double DiluicaoP = 2;

            double conc = (P - b) / a;

            double mgdm = conc * 10 * DiluicaoP;

            return Math.Round(mgdm, 2);
        }

        public double ProcessarPotassio(double K)
        {
            double conc = (K + 2.6) / 2.85;

            double amostra = conc * 10;

            double mmolc = amostra / (39.1 * 10) * 10;

            return Math.Round(mmolc, 2);
        }

        public double ProcessarCalcio(double Ca)
        {

            double amostra = Ca * 10 * 21;

            double pesoEquiv = 40 / 2;

            double mmolc = amostra / (pesoEquiv * 10) * 10;

            return Math.Round(mmolc, 2);
        }

        public double ProcessarMagnesio(double Mg)
        {

            double amostra = Mg * 10 * 21;

            double pesoEquiv = 24.3 / 2;

            double mmolc = amostra / (pesoEquiv * 10) * 10;

            return Math.Round(mmolc, 2);
        }

        public double ProcessarAluminio(double Al)
        {
            double ProvaEmBanco = 0.05;

            double mmolc = (Al - ProvaEmBanco) * 10;

            return Math.Round(mmolc, 2);
        }

        public double ProcessarAcidoPotencial(double HAl)
        {
            double ProvaEmBanco = 2.5;

            double mmolc = (HAl - ProvaEmBanco) * 10;

            return Math.Round(mmolc, 2);
        }

        public double ProcessarZinco(double Zn)
        {
            return Math.Round(Zn, 2);
        }

        public double ProcessarCobre(double Cu)
        {
            return Math.Round(Cu, 2);
        }

        public double ProcessarFerro(double Fe)
        {
            return Math.Round(Fe, 2);
        }

        public double ProcessarManganes(double Mn)
        {
            return Math.Round(Mn, 2);
        }

        public double ProcessarArgila(double Inicio, double Fim)
        {
            var subt = Fim - Inicio;
            var result = (100 * subt) / 20;

            return Math.Round(result, 2);
        }

        public double ProcessarAreia(double Inicio, double Fim)
        {
            var subt = Fim - Inicio;
            var result = (100 * subt) / 20;

            return Math.Round(result, 2);
        }

        public double ProcessarSilte(double Inicio, double Fim)
        {
            var subt = Fim - Inicio;
            var result = (100 * subt) / 20;

            return Math.Round(result, 2);
        }

        public double ProcessarBoro(double B)
        {
            return Math.Round(B, 2);
        }

        public double ProcessarEnxofre(double S)
        {
            return Math.Round(S, 2);
        }

        public double ProcessarMateriaOrganica(double MO)
        {
            return Math.Round(MO, 2);
        }
    }
}