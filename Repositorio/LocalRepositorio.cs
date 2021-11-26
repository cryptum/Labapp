using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class LocalRepositorio
    {
        public LocalRepositorio() { }

        public List<LocalDTO> ObterTodos(int idSolicitante, bool Excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Where(w => w.Excluido == Excluido && w.Solicitantes.IdSolicitante == idSolicitante)
                                .Select(x => new LocalDTO
                                {
                                    Código = x.IdLocal,
                                    Fazenda = x.Fazenda,
                                    Município = x.Municipio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public LocalEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Where(w => w.IdLocal == id)
                                .AsNoTracking()
                                .FirstOrDefault();

                return query;
            }
        }

        public List<LocalEntidade> ObterUmPorCodigoSolicitante(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Where(w => w.Solicitantes.IdSolicitante == id)
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public List<LocalDTO> ObterListaPorNome(int idSolicitante, string nome, bool Excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Where(w => EF.Functions.Like(w.Fazenda, "%" + nome + "%"))
                                .Where(w => w.Excluido == Excluido && w.Solicitantes.IdSolicitante == idSolicitante)
                                .Select(x => new LocalDTO
                                {
                                    Código = x.IdLocal,
                                    Fazenda = x.Fazenda,
                                    Município = x.Municipio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(LocalEntidade local)
        {
            //local.Solicitantes = new SolicitanteRepositorio().ObterUmPorCodigo(idSolicitante);

            using (var db = new ContextDB())
            {
                db.Entry<LocalEntidade>(local).State = EntityState.Added;
                db.SaveChanges();
            }

            return local.IdLocal;
        }

        public int Editar(LocalEntidade local)
        {
            using (var db = new ContextDB())
            {
                db.Entry<LocalEntidade>(local).State = EntityState.Modified;
                db.SaveChanges();
            }

            return local.IdLocal;
        }
    }
}
