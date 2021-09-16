using Entidade.DTO;
using Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class TipoAnaliseRepositorio 
    {
        public TipoAnaliseRepositorio()
        {
        }


        public List<TipoAnaliseDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoAnalises
                                .Select(x => new TipoAnaliseDTO {
                                    IdAnalise = x.IdTipoAnalise
                                })
                                .ToList();
                return query;
            }
        }
    }
}
