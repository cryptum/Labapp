using System;
using System.ComponentModel.DataAnnotations;

namespace Entidade.DTO
{
    public class UsuarioDTO
    {
        [Display(Name = "Código")]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }

        public string Acesso { get; set; }

        public string Senha { get; set; }
        public bool Bloqueado { get; set; }

        public bool Administrador { get; set; }

        public DateTime DataCriado { get; set; }

        public bool AcessoPermitido { get; set; }

        public string AcessoMessagem { get; set; }
    }

    public class UsuarioObterTodosDTO
    {
        public int Código { get; set; }

        public string Nome { get; set; }

        public string Acesso { get; set; }

        public bool Bloqueado { get; set; }

        public bool Administrador { get; set; }
    }
}
