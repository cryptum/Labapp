using Entidade;
using Entidade.DTO;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class ConvenioNegocio
    {
        public ConvenioNegocio() { }

        public List<TipoSolicitacaoDTO> ObterTodos()
        {
            return new ConvenioRepositorio().ObterTodos();
        }

        public List<TipoSolicitacaoNomesDTO> ObterTodosOsNomes()
        {
            return new ConvenioRepositorio().ObterTodosOsNomes();
        }

        public List<TipoSolicitacaoDTO> ObterListaPorNome(string nome)
        {
            return new ConvenioRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(string Nome)
        {
            ConvenioEntidade TipoSolicitacao = new ConvenioEntidade();
            TipoSolicitacao.Nome = Nome.Trim();
            return new ConvenioRepositorio().Salvar(TipoSolicitacao);
        }

        public int Editar(int Id, string Nome)
        {
            ConvenioEntidade TipoSolicitacao = new ConvenioRepositorio().ObterUmPorCodigo(Id);
            if (TipoSolicitacao == null)
            {
                return 0;
            }
            TipoSolicitacao.Nome = Nome.Trim();
            return new ConvenioRepositorio().Editar(TipoSolicitacao);
        }

        public int Excluir(int Id)
        {
            ConvenioEntidade TipoSolicitacao = new ConvenioRepositorio().ObterUmPorCodigo(Id);
            if (TipoSolicitacao == null)
            {
                return 0;
            }
            return new ConvenioRepositorio().Excluir(TipoSolicitacao);
        }
    }
}
