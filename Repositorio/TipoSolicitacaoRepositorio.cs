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
            var query = _context.Alunos
                                .Select(x => new TipoAnaliseDTO
                                {
                                    IdAnalise = x.IdAnalise,
                                    DataEntrada = x.DataEntrada
                                })
                                .ToList();

            return query;
        }
    }
}
