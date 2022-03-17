using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class ProprietarioRepositorio
    {
        public ProprietarioRepositorio() { }

        public List<ProprietarioDTO> ObterTodos(bool excluido)
        {
            using (var db = new ContextDB())
            {
                var query = db.Proprietarios
                                .Where(w => w.Excluido == excluido)
                                .Select(x => new ProprietarioDTO
                                {
                                    Código = x.IdProprietario,
                                    Nome = x.Nome,
                                    CPF = x.Cpf,
                                    Observação = x.Observacao,
                                    Fazendas = x.Fazendas.Count()
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public ProprietarioEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Proprietarios
                                .Where(w => w.IdProprietario == id)
                                .AsNoTracking()
                                .First();

                return query;
            }
        }

        public ProprietarioEntidade ObterUmPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Proprietarios
                                .Include(i => i.Fazendas)
                                .Where(w => w.Nome == nome)
                                .AsNoTracking()
                                .First();

                return query;
            }
        }

        public List<ProprietarioDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Proprietarios
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new ProprietarioDTO
                                {
                                    Código = x.IdProprietario,
                                    Nome = x.Nome,
                                    CPF = x.Cpf,
                                    Observação = x.Observacao,
                                    Fazendas = x.Fazendas.Count()
                                })
                                .AsNoTracking()
                                .ToList();

                return query;
            }
        }

        public int Salvar(ProprietarioEntidade proprietario)
        {
            using (var db = new ContextDB())
            {
                db.Proprietarios.Add(proprietario);
                db.SaveChanges();
            }

            return proprietario.IdProprietario;
        }

        public int Editar(ProprietarioEntidade proprietario)
        {
            using (var db = new ContextDB())
            {
                db.Entry<ProprietarioEntidade>(proprietario).State = EntityState.Modified;
                db.SaveChanges();
            }

            return proprietario.IdProprietario;
        }
    }
}
