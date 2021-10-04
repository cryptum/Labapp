using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SolicitanteNegocio
    {
        public List<SolicitanteDTO> ObterTodos()
        {
            return new SolicitanteRepositorio().ObterTodos(false);
        }

        public List<SolicitanteDTO> ObterListaPorNome(string nome)
        {
            return new SolicitanteRepositorio().ObterListaPorNome(nome);
        }

        public SolicitanteEntidade ObterUmPorCodigo(int id)
        {
            return new SolicitanteRepositorio().ObterUmPorCodigo(id);
        }

        public int Salvar(String Nome, String Observacao)
        {
            SolicitanteEntidade Solicitante = new SolicitanteEntidade();
            Solicitante.Nome = Nome;
            Solicitante.Observacao = Observacao;
            Solicitante.Excluido = false;
            return new SolicitanteRepositorio().Salvar(Solicitante);
        }

        public int Editar(int Id, String Nome, String Observacao)
        {
            SolicitanteEntidade Solicitante = new SolicitanteRepositorio().ObterUmPorCodigo(Id);
            if (Solicitante == null)
            {
                return 0;
            }
            Solicitante.Nome = Nome;
            Solicitante.Observacao = Observacao;
            return new SolicitanteRepositorio().Editar(Solicitante);
        }

        public int ExcluirLogicamente(int Id, bool Excluido)
        {
            SolicitanteEntidade Solicitante = new SolicitanteRepositorio().ObterUmPorCodigo(Id);
            if (Solicitante == null)
            {
                return 0;
            }
            Solicitante.Excluido = true;
            return new SolicitanteRepositorio().Editar(Solicitante);
        }
    }
}
