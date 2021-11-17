using System;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class UsuarioEntidade
    {
        [Key]
        public int IdUsuario { get; set; }

        [MaxLength(150)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Acesso { get; set; }

        [MaxLength(50)]
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }
        public bool Administrador { get; set; }
        public DateTime DataCriado { get; set; }
    }
}
