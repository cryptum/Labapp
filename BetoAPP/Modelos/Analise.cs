using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetoAPP.Modelos
{
    class Analise
    {
        [Key]
        public Guid IdAnalise { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
