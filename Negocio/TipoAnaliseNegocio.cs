using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class TipoAnaliseNegocio
    {

        public TipoAnaliseNegocio(){}

        public List<TipoAnaliseDTO> CarregamentoInicial()
        {
            return new TipoAnaliseRepositorio().ObterTodos();
        }
    }
}
