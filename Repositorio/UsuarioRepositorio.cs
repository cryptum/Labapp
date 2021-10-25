using Entidade.DTO;
using Repositorio.Config;
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
                                    Bloqueado = x.Bloqueado
                                })
                                .FirstOrDefault();
                return query;
            }
        }
    }
}
