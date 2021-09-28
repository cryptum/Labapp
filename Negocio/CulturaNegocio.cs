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
    public class CulturaNegocio
    {
        public List<CulturaDTO> ObterTodos()
        {
            return new CulturaRepositorio().ObterTodos();
        }

        public List<CulturaDTO> ObterUmPorNome(string nome)
        {
            return new CulturaRepositorio().ObterUmPorNome(nome);
        }

        public int Salvar(String Nome)
        {
            CulturaEntidade cultura = new CulturaEntidade();
            cultura.Nome = Nome;
            return new CulturaRepositorio().Salvar(cultura);
        }

        public int Editar(int Id, String Nome)
        {
            CulturaEntidade cultura = new CulturaRepositorio().ObterUmPorCodigo(Id);
            if(cultura == null)
            {
                return 0;
            }
            cultura.Nome = Nome;
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
