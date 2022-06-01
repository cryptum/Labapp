using Entidade;
using Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RelatorioNegocio
    {
        public void Gerar(AnaliseEntidade analise, List<AmostraEntidade> listaAmostra)
        {
            List<AmostraImpressaoLaudoDTO> AmostraSalva = new List<AmostraImpressaoLaudoDTO>();

            for (int i = 1; i < listaAmostra.Count; i++)
            {
                AmostraImpressaoLaudoDTO amostra = new();

                amostra = new PreencherAmostra().Preencher(
                         listaAmostra[i].NumeroAmostra,
                         listaAmostra[i].NomeAmostra,
                         Convert.ToDouble(listaAmostra[i].Ph_Agua),
                         Convert.ToDouble(listaAmostra[i].Diluicao),
                         Convert.ToDouble(listaAmostra[i].P_Fosforo),
                         Convert.ToDouble(listaAmostra[i].K_Potassio),
                         Convert.ToDouble(listaAmostra[i].Ca_Calcio),
                         Convert.ToDouble(listaAmostra[i].Mg_Magnesio),
                         Convert.ToDouble(listaAmostra[i].Al_Aluminio),
                         Convert.ToDouble(listaAmostra[i].Alh_AcidezPotencial),


                         Convert.ToDouble(listaAmostra[i].Zn_Zinco),
                         Convert.ToDouble(listaAmostra[i].Cu_Cobre),
                         Convert.ToDouble(listaAmostra[i].Fe_Ferro),
                         Convert.ToDouble(listaAmostra[i].Mn_manganes),


                         Convert.ToDouble(listaAmostra[i].Argila_Inicio),
                         Convert.ToDouble(listaAmostra[i].Argila_Fim),
                         Convert.ToDouble(listaAmostra[i].Areia_Inicio),
                         Convert.ToDouble(listaAmostra[i].Areia_Fim),
                         Convert.ToDouble(listaAmostra[i].Silte_Inicio),
                         Convert.ToDouble(listaAmostra[i].Silte_Fim),


                         Convert.ToDouble(listaAmostra[i].B_Boro),
                         Convert.ToDouble(listaAmostra[i].S_Enxofre),
                         Convert.ToDouble(listaAmostra[i].Mo_MateriaOrganica)

                         );


                new AmostraNegocio().Salvar(listaAmostra[i], analise.IdAnalise);
                AmostraSalva.Add(amostra);
            }

            var result = new GerarPDF().Gerar(analise, AmostraSalva);
        }
    }
}
