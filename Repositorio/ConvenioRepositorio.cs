using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class ConvenioRepositorio
    {

        public ConvenioRepositorio() { }

        public List<TipoSolicitacaoDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Convenios
                                .Select(x => new TipoSolicitacaoDTO
                                {
                                    Código = x.IdConvenio,
                                    Nome = x.Nome
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public List<TipoSolicitacaoNomesDTO> ObterTodosOsNomes()
        {
            using (var db = new ContextDB())
            {
                var query = db.Convenios
                                .Select(x => new TipoSolicitacaoNomesDTO
                                {
                                    Nome = x.Nome
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public ConvenioEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Convenios
                                .Where(w => w.IdConvenio == id)
                                .AsNoTracking()
                                .FirstOrDefault();

                return query;
            }
        }

        public List<TipoSolicitacaoDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Convenios
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new TipoSolicitacaoDTO
                                {
                                    Código = x.IdConvenio,
                                    Nome = x.Nome
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(ConvenioEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.Convenios.Add(TipoSolicitacao);
                db.SaveChanges();
            }

            return TipoSolicitacao.IdConvenio;
        }

        public int Editar(ConvenioEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.Entry<ConvenioEntidade>(TipoSolicitacao).State = EntityState.Modified;
                db.SaveChanges();
            }

            return TipoSolicitacao.IdConvenio;
        }

        public int Excluir(ConvenioEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.Remove(TipoSolicitacao);
                db.SaveChanges();
            }

            return TipoSolicitacao.IdConvenio;
        }
    }
}
