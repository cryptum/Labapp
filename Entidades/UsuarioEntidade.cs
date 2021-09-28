using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class UsuarioEntidade
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Acesso { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public bool Bloqueado { get; set; }
        public string DataCriado { get; set; }
    }
}
