using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class TipoAnaliseRepositorio
    {
        public TipoAnaliseRepositorio() { }

        public List<TipoAnaliseDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoAnalises
                                .Select(x => new TipoAnaliseDTO
                                {
                                    Código = x.IdTipoAnalise,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public TipoAnaliseEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoAnalises
                                .Where(w => w.IdTipoAnalise == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<TipoAnaliseDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoAnalises
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new TipoAnaliseDTO
                                {
                                    Código = x.IdTipoAnalise,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(TipoAnaliseEntidade TipoAnalise)
        {
            using (var db = new ContextDB())
            {
                db.TipoAnalises.Add(TipoAnalise);
                db.SaveChanges();
            }

            return TipoAnalise.IdTipoAnalise;
        }

        public int Editar(TipoAnaliseEntidade TipoAnalise)
        {
            using (var db = new ContextDB())
            {
                db.Entry<TipoAnaliseEntidade>(TipoAnalise).State = EntityState.Modified;
                db.SaveChanges();
            }

            return TipoAnalise.IdTipoAnalise;
        }

        public int Excluir(TipoAnaliseEntidade TipoAnalise)
        {
            using (var db = new ContextDB())
            {
                db.Remove(TipoAnalise);
                db.SaveChanges();
            }

            return TipoAnalise.IdTipoAnalise;
        }
    }
}
