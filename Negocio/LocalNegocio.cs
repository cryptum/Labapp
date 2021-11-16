using Entidade;
using Entidade.DTO;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class LocalNegocio
    {
        public List<LocalDTO> ObterTodos(int idSolicitante)
        {
            return new LocalRepositorio().ObterTodos(idSolicitante, false);
        }

        public List<LocalEntidade> ObterUmPorCodigoSolicitante(int idSolicitante)
        {
            return new LocalRepositorio().ObterUmPorCodigoSolicitante(idSolicitante);
        }

        public List<LocalDTO> ObterListaPorNome(int idSolicitante, string nome)
        {
            return new LocalRepositorio().ObterListaPorNome(idSolicitante, nome, false);
        }

        public int Salvar(string fazenda, string municipio, int idSolicitante)
        {
            SolicitanteEntidade Solicitante = new SolicitanteNegocio().ObterUmPorCodigo(idSolicitante);
            LocalEntidade Local = new LocalEntidade();
            Local.Fazenda = fazenda.Trim();
            Local.Municipio = municipio.Trim();
            Local.Solicitantes = Solicitante;
            Local.Excluido = false;
            return new LocalRepositorio().Salvar(Local);
        }

        public int Editar(int Id, string fazenda, string municipio, int idSolicitante)
        {
            SolicitanteEntidade Solicitante = new SolicitanteNegocio().ObterUmPorCodigo(idSolicitante);
            if (Solicitante == null)
            {
                return 0;
            }

            LocalEntidade Local = new LocalRepositorio().ObterUmPorCodigo(Id);
            if (Local == null)
            {
                return 0;
            }
            Local.Fazenda = fazenda;
            Local.Municipio = municipio;
            Local.Solicitantes = Solicitante;
            Local.Excluido = false;
            return new LocalRepositorio().Editar(Local);
        }

        public int ExcluirLogicamente(int Id, bool Excluido)
        {
            LocalEntidade Local = new LocalRepositorio().ObterUmPorCodigo(Id);
            if (Local == null)
            {
                return 0;
            }
            Local.Excluido = true;
            return new LocalRepositorio().Editar(Local);
        }
    }
}
