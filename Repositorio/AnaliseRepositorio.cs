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

        public List<AnalisePaginaUnicaDTO> ObterTodosPaginaUnica()
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Select(x => new AnalisePaginaUnicaDTO
                                {
                                    Código = x.IdAnalise,
                                    Análise = x.NomeAnalise,
                                    Proprietário = x.Proprietarios.Nome,
                                    Fazenda = x.Fazenda,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.Convenio,
                                    Data = x.DataCriado.Date,
                                    Hora = x.DataCriado.ToShortTimeString(),
                                })
                                .AsNoTracking()
                                .OrderByDescending(o => o.Código)
                                .ToList();

                return query;
            }
        }

        public List<AnaliseObterTodosImcompletoDTO> ObterTodosImcompleta()
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Select(x => new AnaliseObterTodosImcompletoDTO
                                {
                                    Código = x.IdAnalise,
                                    Análise = x.NomeAnalise,
                                    Fazenda = x.Fazenda,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Completo = x.Finalizada == true ? "Completa" : "Em Aberto"
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
                                .Select(x => new AnaliseObterTodosCompletoDTO
                                {
                                    Código = x.IdAnalise,
                                    Análise = x.NomeAnalise,
                                    Proprietário = x.Proprietarios.Nome,
                                    Fazenda = x.Fazenda,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.Convenio,
                                    Completo = x.Finalizada == true ? "Completa" : "Em Aberto"
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
                                .Include(i => i.Proprietarios)
                                .FirstOrDefault();

                return query;
            }

        }

        public List<AnaliseObterTodosDTO> ObterListaPorNomeProprietario(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => EF.Functions.Like(w.Proprietarios.Nome, "%" + nome + "%"))
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Proprietário = x.Proprietarios.Nome,
                                    Fazenda = x.Fazenda,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.Convenio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public List<AnaliseObterTodosDTO> ObterListaPorCpfProprietario(string cpf)
        {
            using (var db = new ContextDB())
            {
                var query = db.Analises
                                .Where(w => EF.Functions.Like(w.Proprietarios.Cpf.Replace(".", "").Replace(",", "").Replace("\\", "").Replace("/", ""), "%" + cpf + "%"))
                                .Select(x => new AnaliseObterTodosDTO
                                {
                                    Código = x.IdAnalise,
                                    Proprietário = x.Proprietarios.Nome,
                                    Fazenda = x.Fazenda,
                                    Referência = x.Referencia,
                                    Cultura = x.Cultura,
                                    Solicitação = x.Convenio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(AnaliseEntidade Analise, int idProprietario)
        {
            Analise.Proprietarios = new ProprietarioRepositorio().ObterUmPorCodigo(idProprietario);

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
