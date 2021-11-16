using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class CulturaNegocio
    {
        public List<CulturaDTO> ObterTodos()
        {
            return new CulturaRepositorio().ObterTodos();
        }

        public List<CulturaNomeDTO> ObterTodosOsNomes()
        {
            return new CulturaRepositorio().ObterTodosOsNomes();
        }

        public List<CulturaDTO> ObterListaPorNome(string nome)
        {
            return new CulturaRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(String Nome)
        {
            CulturaEntidade cultura = new CulturaEntidade();
            cultura.Nome = Nome.Trim();
            return new CulturaRepositorio().Salvar(cultura);
        }

        public int Editar(int Id, String Nome)
        {
            CulturaEntidade cultura = new CulturaRepositorio().ObterUmPorCodigo(Id);
            if (cultura == null)
            {
                return 0;
            }
            cultura.Nome = Nome.Trim();
            return new CulturaRepositorio().Editar(cultura);
        }

        public int Excluir(int Id)
        {
            CulturaEntidade cultura = new CulturaRepositorio().ObterUmPorCodigo(Id);
            if (cultura == null)
            {
                return 0;
            }
            return new CulturaRepositorio().Excluir(cultura);
        }
    }
}
