using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProprietarioNegocio
    {
        public List<ProprietarioDTO> ObterTodos()
        {
            return new ProprietarioRepositorio().ObterTodos(false);
        }

        public List<ProprietarioDTO> ObterListaPorNome(string nome)
        {
            return new ProprietarioRepositorio().ObterListaPorNome(nome);
        }

        public ProprietarioEntidade ObterUmPorCodigo(int id)
        {
            return new ProprietarioRepositorio().ObterUmPorCodigo(id);
        }

        public int Salvar(String Nome, String Cpf, String Observacao)
        {
            ProprietarioEntidade Solicitante = new ProprietarioEntidade();
            Solicitante.Nome = Nome.Trim();
            Solicitante.Cpf = Cpf;
            Solicitante.Observacao = Observacao.Trim();
            Solicitante.Excluido = false;
            return new ProprietarioRepositorio().Salvar(Solicitante);
        }

        public int Editar(int Id, String Nome, String Cpf, String Observacao)
        {
            ProprietarioEntidade Solicitante = new ProprietarioRepositorio().ObterUmPorCodigo(Id);
            if (Solicitante == null)
            {
                return 0;
            }
            Solicitante.Nome = Nome.Trim();
            Solicitante.Cpf = Cpf;
            Solicitante.Observacao = Observacao.Trim();
            return new ProprietarioRepositorio().Editar(Solicitante);
        }

        public int ExcluirLogicamente(int Id, bool Excluido)
        {
            ProprietarioEntidade Solicitante = new ProprietarioRepositorio().ObterUmPorCodigo(Id);
            if (Solicitante == null)
            {
                return 0;
            }
            Solicitante.Excluido = true;
            return new ProprietarioRepositorio().Editar(Solicitante);
        }
    }
}
