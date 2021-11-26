using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class SolicitanteRepositorio
    {
        public SolicitanteRepositorio() { }

        public List<SolicitanteDTO> ObterTodos(bool Excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Solicitantes
                                .Where(w => w.Excluido == Excluido)
                                .Select(x => new SolicitanteDTO
                                {
                                    Código = x.IdSolicitante,
                                    Nome = x.Nome,
                                    Cpf = x.Cpf,
                                    Observação = x.Observacao,
                                    Fazendas = x.Locais.Count()
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public SolicitanteEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Solicitantes
                                .Where(w => w.IdSolicitante == id)
                                .AsNoTracking()
                                .First();

                return query;
            }
        }

        public List<SolicitanteDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Solicitantes
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new SolicitanteDTO
                                {
                                    Código = x.IdSolicitante,
                                    Nome = x.Nome,
                                    Cpf = x.Cpf,
                                    Observação = x.Observacao,
                                    Fazendas = x.Locais.Count()
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(SolicitanteEntidade solicitante)
        {
            using (var db = new ContextDB())
            {
                db.Solicitantes.Add(solicitante);
                db.SaveChanges();
            }

            return solicitante.IdSolicitante;
        }

        public int Editar(SolicitanteEntidade solicitante)
        {
            using (var db = new ContextDB())
            {
                db.Entry<SolicitanteEntidade>(solicitante).State = EntityState.Modified;
                db.SaveChanges();
            }

            return solicitante.IdSolicitante;
        }
    }
}
