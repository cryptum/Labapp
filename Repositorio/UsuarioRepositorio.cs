using Entidade;
using Entidade.DTO;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio() { }

        public UsuarioDTO ValidarAcesso(string Acesso, string Senha)
        {
            using (var db = new ContextDB())
            {
                var query = db.Usuarios
                                .Where(w => w.Acesso == Acesso && w.Senha == Senha)
                                .Select(x => new UsuarioDTO
                                {
                                    Nome = x.Nome,
                                    Bloqueado = x.Bloqueado,
                                    Administrador = x.Administrador
                                })
                                .FirstOrDefault();
                return query;
            }
        }


        public List<UsuarioObterTodosDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.Usuarios
                                .Select(x => new UsuarioObterTodosDTO
                                {
                                    Código = x.IdUsuario,
                                    Nome = x.Nome,
                                    Acesso = x.Acesso,
                                    Bloqueado = x.Bloqueado,
                                    Administrador = x.Administrador
                                })
                                .ToList();

                return query;
            }
        }

        public UsuarioEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.Usuarios
                                .Where(w => w.IdUsuario == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<UsuarioObterTodosDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.Usuarios
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new UsuarioObterTodosDTO
                                {
                                    Código = x.IdUsuario,
                                    Nome = x.Nome,
                                    Acesso = x.Acesso,
                                    Bloqueado = x.Bloqueado,
                                    Administrador = x.Administrador
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(UsuarioEntidade usuario)
        {
            using (var db = new ContextDB())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }

            return usuario.IdUsuario;
        }

        public int Editar(UsuarioEntidade usuario)
        {
            using (var db = new ContextDB())
            {
                db.Entry<UsuarioEntidade>(usuario).State = EntityState.Modified;
                db.SaveChanges();
            }

            return usuario.IdUsuario;
        }

        public int Excluir(UsuarioEntidade usuario)
        {
            using (var db = new ContextDB())
            {
                db.Remove(usuario);
                db.SaveChanges();
            }

            return usuario.IdUsuario;
        }
    }
}
