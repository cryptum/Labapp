using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class AnaliseEntidade
    {
        [Key]
        public int IdAnalise { get; set; }

        public SolicitanteEntidade Solicitantes { get; set; }

        public string Local { get; set; }

        public string Municipio { get; set; }

        public string Referencia { get; set; }

        public string Cultura { get; set; }

        public string TipoSolicitacao { get; set; }

        public ICollection<AmostraEntidade> Amostras { get; set; }

        public DateTime DataCriado { get; set; }

        public DateTime? DataUltimaAtualizacao { get; set; }
    }
}
