using Entidade;
using Entidade.DTO;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class TipoSolicitacaoNegocio
    {
        public TipoSolicitacaoNegocio(){}

        public List<TipoSolicitacaoDTO> ObterTodos()
        {
            return new TipoSolicitacaoRepositorio().ObterTodos();
        }

        public List<TipoSolicitacaoDTO> ObterListaPorNome(string nome)
        {
            return new TipoSolicitacaoRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(string Nome)
        {
            TipoSolicitacaoEntidade TipoSolicitacao = new TipoSolicitacaoEntidade();
            TipoSolicitacao.Nome = Nome;
            return new TipoSolicitacaoRepositorio().Salvar(TipoSolicitacao);
        }

        public int Editar(int Id, string Nome)
        {
            TipoSolicitacaoEntidade TipoSolicitacao = new TipoSolicitacaoRepositorio().ObterUmPorCodigo(Id);
            if (TipoSolicitacao == null)
            {
                return 0;
            }
            TipoSolicitacao.Nome = Nome;
            return new TipoSolicitacaoRepositorio().Editar(TipoSolicitacao);
        }

        public int Excluir(int Id)
        {
            TipoSolicitacaoEntidade TipoSolicitacao = new TipoSolicitacaoRepositorio().ObterUmPorCodigo(Id);
            if (TipoSolicitacao == null)
            {
                return 0;
            }
            return new TipoSolicitacaoRepositorio().Excluir(TipoSolicitacao);
        }
    }
}
