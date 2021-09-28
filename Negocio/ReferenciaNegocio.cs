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
        public List<ReferenciaDTO> ObterUmPorNome(string nome)
        {
            return new ReferenciaRepositorio().ObterUmPorNome(nome);
        }

        public int Salvar(String Nome)
        {
            ReferenciaEntidade referencia = new ReferenciaEntidade();
            referencia.Nome = Nome;
            return new ReferenciaRepositorio().Salvar(referencia);
        }

        public int Editar(int Id, String Nome)
        {
            ReferenciaEntidade referencia = new ReferenciaRepositorio().ObterUmPorCodigo(Id);
            if (referencia == null)
            {
                return 0;
            }
            referencia.Nome = Nome;
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
