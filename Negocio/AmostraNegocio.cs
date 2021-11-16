using Entidade;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class AmostraNegocio
    {
        public AmostraNegocio() { }

        public List<AmostraEntidade> ObterAmostrarPorIdAnalise(int idAnalise)
        {
            return new AmostraRepositorio().ObterAmostrarPorIdAnalise(idAnalise);
        }

        public int Salvar(AmostraEntidade amostra, int IdAnalise)
        {
            return new AmostraRepositorio().Salvar(amostra, IdAnalise);
        }

        public int Excluir(int idAnalise)
        {
            return new AmostraRepositorio().Excluir(new AmostraRepositorio().RecuperarParaExcluir(idAnalise));
        }
    }
}
