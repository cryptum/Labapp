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
        /*
        public LocalRepositorio() { }

        public List<LocalDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Select(x => new LocalDTO
                                {
                                    Código = x.Idlocal,
                                    Nome = x.Nome
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
                                .Where(w => w.Idlocal == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<LocalDTO> ObterUmPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Locais
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new LocalDTO
                                {
                                    Código = x.Idlocal,
                                    Nome = x.Nome
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

            return local.Idlocal;
        }

        public int Editar(LocalEntidade local)
        {
            using (var db = new ContextDB())
            {
                db.Entry<LocalEntidade>(local).State = EntityState.Modified;
                db.SaveChanges();
            }

            return local.Idlocal;
        }

        public int Excluir(LocalEntidade local)
        {
            using (var db = new ContextDB())
            {
                db.Remove(local);
                db.SaveChanges();
            }

            return local.Idlocal;
        }
        */
    }
}
