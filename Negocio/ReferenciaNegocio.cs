using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ReferenciaNegocio
    {
        public List<ReferenciaDTO> ObterTodos()
        {
            return new ReferenciaRepositorio().ObterTodos();
        }

        public List<ReferenciaNomeDTO> ObterTodosOsNomes()
        {
            return new ReferenciaRepositorio().ObterTodosOsNome();
        }

        public List<ReferenciaDTO> ObterListaPorNome(string nome)
        {
            return new ReferenciaRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(String Nome)
        {
            ReferenciaEntidade referencia = new ReferenciaEntidade();
            referencia.Nome = Nome.Trim();
            return new ReferenciaRepositorio().Salvar(referencia);
        }

        public int Editar(int Id, String Nome)
        {
            ReferenciaEntidade referencia = new ReferenciaRepositorio().ObterUmPorCodigo(Id);
            if (referencia == null)
            {
                return 0;
            }
            referencia.Nome = Nome.Trim();
            return new ReferenciaRepositorio().Editar(referencia);
        }

        public int Excluir(int Id)
        {
            ReferenciaEntidade referencia = new ReferenciaRepositorio().ObterUmPorCodigo(Id);
            if (referencia == null)
            {
                return 0;
            }
            return new ReferenciaRepositorio().Excluir(referencia);
        }
    }
}
