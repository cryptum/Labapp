using Repositorio.Config;
using Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class TipoSolicitacaoRepositorio
    {

        private readonly ContextDB _context;
        public TipoSolicitacaoRepositorio(ContextDB context)
        {
            _context = context;
        }

        public List<TipoAnaliseDTO> ObterTodos()
        {
            var query = _context.TipoAnalises
                                .Select(x => new TipoAnaliseDTO
                                {
                                    IdAnalise = x.IdTipoAnalise
                                })
                                .ToList();

            return query;
        }
    }
}
