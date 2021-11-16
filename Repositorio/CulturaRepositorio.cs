using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class CulturaRepositorio
    {
        public CulturaRepositorio() { }

        public List<CulturaDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Culturas
                                .Select(x => new CulturaDTO
                                {
                                    Código = x.IdCultura,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public List<CulturaNomeDTO> ObterTodosOsNomes()
        {
            using (var db = new ContextDB())
            {
                var query = db.Culturas
                                .Select(x => new CulturaNomeDTO
                                {
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public CulturaEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Culturas
                                .Where(w => w.IdCultura == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<CulturaDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Culturas
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new CulturaDTO
                                {
                                    Código = x.IdCultura,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(CulturaEntidade cultura)
        {
            using (var db = new ContextDB())
            {
                db.Culturas.Add(cultura);
                db.SaveChanges();
            }

            return cultura.IdCultura;
        }

        public int Editar(CulturaEntidade cultura)
        {
            using (var db = new ContextDB())
            {
                db.Entry<CulturaEntidade>(cultura).State = EntityState.Modified;
                db.SaveChanges();
            }

            return cultura.IdCultura;
        }

        public int Excluir(CulturaEntidade cultura)
        {
            using (var db = new ContextDB())
            {
                db.Remove(cultura);
                db.SaveChanges();
            }

            return cultura.IdCultura;
        }
    }
}
