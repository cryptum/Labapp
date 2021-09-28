using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class LocalEntidade
    {
        [Key]
        public int IdLocal { get; set; }
        public string Fazenda { get; set; }
        public string Municipio { get; set; }
        public SolicitanteEntidade Solicitante { get; set; }
    }
}
