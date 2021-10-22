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
    public class ReferenciaRepositorio
    {
        public ReferenciaRepositorio() { }

        public List<ReferenciaDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Referencias
                                .Select(x => new ReferenciaDTO
                                {
                                    Código = x.IdReferencia,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public List<ReferenciaNomeDTO> ObterTodosOsNome()
        {
            using (var db = new ContextDB())
            {
                var query = db.Referencias
                                .Select(x => new ReferenciaNomeDTO
                                {
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public ReferenciaEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Referencias
                                .Where(w => w.IdReferencia == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<ReferenciaDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Referencias
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new ReferenciaDTO
                                {
                                    Código = x.IdReferencia,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(ReferenciaEntidade referencia)
        {
            using (var db = new ContextDB())
            {
                db.Referencias.Add(referencia);
                db.SaveChanges();
            }

            return referencia.IdReferencia;
        }

        public int Editar(ReferenciaEntidade referencia)
        {
            using (var db = new ContextDB())
            {
                db.Entry<ReferenciaEntidade>(referencia).State = EntityState.Modified;
                db.SaveChanges();
            }

            return referencia.IdReferencia;
        }

        public int Excluir(ReferenciaEntidade referencia)
        {
            using (var db = new ContextDB())
            {
                db.Remove(referencia);
                db.SaveChanges();
            }

            return referencia.IdReferencia;
        }
    }
}
