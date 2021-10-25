using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class AnaliseRepositorio
    {
        public AnaliseRepositorio() { }

        public List<AnaliseObterTodosDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Solicitante = x.Solicitantes.Nome,
                                    Local = x.Local,
                                    Referencia = x.Referencia,
                                    Cultura = x.Cultura,
                                    TipoSolicitacao = x.TipoSolicitacao
                                })
                                .OrderByDescending(o => o.Código)
                                .ToList();

                return query;
            }
        }

        public AnaliseEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => w.IdAnalise == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitante(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => EF.Functions.Like(w.Solicitantes.Nome, "%" + nome + "%"))
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Solicitante = x.Solicitantes.Nome,
                                    Local = x.Local,
                                    Referencia = x.Referencia,
                                    Cultura = x.Cultura,
                                    TipoSolicitacao = x.TipoSolicitacao
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(AnaliseEntidade Analise)
        {
            using (var db = new ContextDB())
            {
                db.Analises.Add(Analise);
                db.SaveChanges();
            }

            return Analise.IdAnalise;
        }

        public int Editar(AnaliseEntidade Analise)
        {
            using (var db = new ContextDB())
            {
                db.Entry<AnaliseEntidade>(Analise).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Analise.IdAnalise;
        }

        public int Excluir(AnaliseEntidade Analise)
        {
            using (var db = new ContextDB())
            {
                db.Remove(Analise);
                db.SaveChanges();
            }

            return Analise.IdAnalise;
        }

    }
}
