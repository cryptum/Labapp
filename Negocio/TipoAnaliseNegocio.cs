using Entidade;
using Entidade.DTO;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class TipoAnaliseNegocio
    {

        public List<TipoAnaliseDTO> ObterTodos()
        {
            return new TipoAnaliseRepositorio().ObterTodos();
        }

        public List<TipoAnaliseDTO> ObterListaPorNome(string nome)
        {
            return new TipoAnaliseRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(string Nome)
        {
            TipoAnaliseEntidade TipoAnalise = new TipoAnaliseEntidade();
            TipoAnalise.Nome = Nome;
            return new TipoAnaliseRepositorio().Salvar(TipoAnalise);
        }

        public int Editar(int Id, string Nome)
        {
            TipoAnaliseEntidade TipoAnalise = new TipoAnaliseRepositorio().ObterUmPorCodigo(Id);
            if (TipoAnalise == null)
            {
                return 0;
            }
            TipoAnalise.Nome = Nome;
            return new TipoAnaliseRepositorio().Editar(TipoAnalise);
        }

        public int Excluir(int Id)
        {
            TipoAnaliseEntidade TipoAnalise = new TipoAnaliseRepositorio().ObterUmPorCodigo(Id);
            if (TipoAnalise == null)
            {
                return 0;
            }
            return new TipoAnaliseRepositorio().Excluir(TipoAnalise);
        }
    }
}
