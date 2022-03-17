using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class FazendaRepositorio
    {
        public FazendaRepositorio() { }

        public List<FazendaDTO> ObterTodos(int idProprietario, bool Excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Fazendas
                                .Where(w => w.Excluido == Excluido && w.Proprietarios.IdProprietario == idProprietario)
                                .Select(x => new FazendaDTO
                                {
                                    Código = x.IdFazenda,
                                    Fazenda = x.Fazenda,
                                    Município = x.Municipio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public FazendaEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Fazendas
                                .Where(w => w.IdFazenda == id)
                                .AsNoTracking()
                                .FirstOrDefault();

                return query;
            }
        }

        public List<FazendaEntidade> ObterUmPorCodigoDeProprietario(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Fazendas
                                .Where(w => w.Proprietarios.IdProprietario == id)
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public FazendaEntidade ObterUmPorNomeEProprietario(string fazenda, string nomeProprietario)
        {
            using (var db = new ContextDB())
            {
                var query = db.Fazendas
                                .Where(w => w.Fazenda == fazenda)
                                .Where(w => w.Proprietarios.Nome == nomeProprietario)
                                .AsNoTracking()
                                .First();

                return query;
            }
        }


        public List<FazendaDTO> ObterListaPorNome(int idProprietario, string nome, bool Excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Fazendas
                                .Where(w => EF.Functions.Like(w.Fazenda, "%" + nome + "%"))
                                .Where(w => w.Excluido == Excluido && w.Proprietarios.IdProprietario == idProprietario)
                                .Select(x => new FazendaDTO
                                {
                                    Código = x.IdFazenda,
                                    Fazenda = x.Fazenda,
                                    Município = x.Municipio
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(FazendaEntidade fazenda)
        {
            //local.Proprietarios = new ProprietarioRepositorio().ObterUmPorCodigo(idProprietario);

            using (var db = new ContextDB())
            {
                db.Entry<FazendaEntidade>(fazenda).State = EntityState.Added;
                db.SaveChanges();
            }

            return fazenda.IdFazenda;
        }

        public int Editar(FazendaEntidade fazenda)
        {
            using (var db = new ContextDB())
            {
                db.Entry<FazendaEntidade>(fazenda).State = EntityState.Modified;
                db.SaveChanges();
            }

            return fazenda.IdFazenda;
        }
    }
}
