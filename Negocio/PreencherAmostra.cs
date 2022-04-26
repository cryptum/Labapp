using Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PreencherAmostra
    {

        public AmostraImpressaoLaudoDTO Preencher(
            double pH,
            double diluicao,
            double P,
            double K,
            double Ca,
            double Mg,
            double Al,
            double AlH,
            double Zn,
            double Cu,
            double Fe,
            double Mn,
            double ArgilaInicial,
            double ArgilaFinal,
            double AreiaInicial,
            double AreiaFinal,
            double SilteInicial,
            double SilteFinal,
            double B,
            double S,
            double MO
            )
        {
            AmostraImpressaoLaudoDTO amostra = new AmostraImpressaoLaudoDTO();
            amostra.Basica = true;
            amostra.PhAgua = new MotorDeCalculo().ProcessarPH(pH).ToString();
            amostra.Fosforo = new MotorDeCalculo().ProcessarFosforo(P, diluicao).ToString();

            double k = new MotorDeCalculo().ProcessarPotassio(K);
            amostra.Potassio = k.ToString();

            double ca = new MotorDeCalculo().ProcessarCalcio(Ca);
            amostra.Calcio = ca.ToString();

            double mg = new MotorDeCalculo().ProcessarMagnesio(Mg);
            amostra.Magnesio = mg.ToString();

            double al = new MotorDeCalculo().ProcessarAluminio(Al);
            amostra.Aluminio = al.ToString();

            double alh = new MotorDeCalculo().ProcessarAcidoPotencial(AlH);
            amostra.AcidezPotencial = alh.ToString();

            double sb = Math.Round(k + Ca + mg, 2);
            amostra.SB = sb.ToString();

            double ti = Math.Round(al + sb, 2);
            amostra.ti = ti.ToString();

            double T = Math.Round(alh + sb, 2);
            amostra.T = T.ToString();

            amostra.V = Math.Round(((100 * sb) / T), 2).ToString();
            amostra.m = Math.Round(((100 * al) / ti), 2).ToString();


            amostra.Zinco = Zn == 0 ? "N/S" : new MotorDeCalculo().ProcessarZinco(Zn).ToString();
            amostra.Cobre = Cu == 0 ? "N/S" : new MotorDeCalculo().ProcessarCobre(Cu).ToString();
            amostra.Ferro = Cu == 0 ? "N/S" : new MotorDeCalculo().ProcessarFerro(Fe).ToString();
            amostra.Manganes = Mn == 0 ? "N/S" : new MotorDeCalculo().ProcessarManganes(Mn).ToString();

            amostra.Completa = Zn == 0 && Cu == 0 && Fe == 0 && Mn == 0 ? false : true;


            amostra.Argila = ArgilaInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarArgila(ArgilaInicial, ArgilaFinal).ToString();
            amostra.Areia = AreiaInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarAreia(AreiaInicial, AreiaFinal).ToString();
            amostra.Silte = SilteInicial == 0 ? "N/S" : new MotorDeCalculo().ProcessarSilte(SilteInicial, SilteFinal).ToString();

            amostra.Fisica = ArgilaInicial == 0 && ArgilaFinal == 0 && AreiaInicial == 0 && AreiaFinal == 0 && SilteInicial == 0;

            amostra.Enxofre = S == 0 ? "N/S" : new MotorDeCalculo().ProcessarEnxofre(S).ToString();
            amostra.Boro  = B == 0 ? "N/S" : new MotorDeCalculo().ProcessarBoro(B).ToString();
            amostra.MateriaOrganica = MO == 0 ? "N/S" : new MotorDeCalculo().ProcessarMateriaOrganica(MO).ToString();

            amostra.Opcional = S == 0 && B == 0 && MO == 0 ? false : true;


            amostra.TonHa = Math.Round(((0.6 * T - sb) / 10), 2).ToString();

            return amostra;
        }
    }
}
