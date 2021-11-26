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

        public List<AnaliseObterTodosImcompletoDTO> ObterTodosImcompleta()
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => w.Completa == false)
                                .Select(x => new AnaliseObterTodosImcompletoDTO
                                {
                                    Código = x.IdAnalise,
                                    Análise = x.NomeAnalise,
                                    Local = x.Local,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura
                                })
                                .AsNoTracking()
                                .OrderByDescending(o => o.Código)
                                .ToList();

                return query;
            }
        }

        public List<AnaliseObterTodosCompletoDTO> ObterTodosCompletos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => w.Completa == true)
                                .Select(x => new AnaliseObterTodosCompletoDTO
                                {
                                    Código = x.IdAnalise,
                                    Análise = x.NomeAnalise,
                                    Proprietário = x.Solicitantes.Nome,
                                    Local = x.Local,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.TipoSolicitacao
                                })
                                .AsNoTracking()
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
                                .Include(i => i.Solicitantes)
                                .FirstOrDefault();

                return query;
            }

        }

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitanteNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => EF.Functions.Like(w.Solicitantes.Nome, "%" + nome + "%"))
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Proprietário = x.Solicitantes.Nome,
                                    Local = x.Local,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.TipoSolicitacao
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitanteCpf(string cpf)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => EF.Functions.Like(w.Solicitantes.Cpf, "%" + cpf + "%"))
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Proprietário = x.Solicitantes.Nome,
                                    Local = x.Local,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.TipoSolicitacao
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(AnaliseEntidade Analise, int idSolicitante)
        {
            Analise.Solicitantes = new SolicitanteRepositorio().ObterUmPorCodigo(idSolicitante);

            using (var db = new ContextDB())
            {
                db.Entry<AnaliseEntidade>(Analise).State = EntityState.Added;
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
