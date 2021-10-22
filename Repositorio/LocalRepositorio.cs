using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                    Municipio = x.Municipio
                                })
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
                                    Municipio = x.Municipio
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(LocalEntidade local)
        {
            using (var db = new ContextDB())
            {
                db.Locais.Add(local);
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
