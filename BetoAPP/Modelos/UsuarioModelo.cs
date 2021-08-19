using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetoAPP.Modelos
{
    class UsuarioModelo
    {
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Acesso { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public string DataCriado { get; set; }
    }
}
