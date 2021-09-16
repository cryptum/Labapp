using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public UsuarioNegocio(){}

        public UsuarioDTO ValidarAcesso(string Acesso, string Senha)
        {
            var resultado = new UsuarioRepositorio().ValidarAcesso(Acesso, Senha);

            if (resultado == null)
            {
                resultado.AcessoPermitido = false;
                resultado.AcessoMessagem = "Usuário não encontrado";
                //Acesso não encontrado
            }
            else if (resultado.Bloqueado == true)
            {
                resultado.AcessoPermitido = false;
                resultado.AcessoMessagem = "Usuário bloqueado";
                //Acesso Bloqueado
            }
            else
            {
                resultado.AcessoPermitido = true;
                //Acesso permitido
            }

            return resultado;
        }

    }
}
