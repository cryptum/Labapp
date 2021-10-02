using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Tipo { get; set; }

        public bool Bloqueado { get; set; }

        public string DataCriado { get; set; }

        public bool AcessoPermitido { get; set; }

        public string AcessoMessagem { get; set; }
    }
}
