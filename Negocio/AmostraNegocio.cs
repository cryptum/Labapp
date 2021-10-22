using Entidade;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AmostraNegocio
    {
        public AmostraNegocio(){}

        public List<AmostraEntidade> ObterAmostrarPorIdAnalise(int idAnalise)
        {
            return new AmostraNegocio().ObterAmostrarPorIdAnalise(idAnalise);
        }

        public int Salvar(AmostraEntidade amostra)
        {
            return new AmostraRepositorio().Salvar(amostra);
        }

        public int Excluir(int idAnalise)
        {
            return new AmostraRepositorio().Excluir(new AmostraRepositorio().RecuperarParaExcluir(idAnalise));
        }
    }
}
