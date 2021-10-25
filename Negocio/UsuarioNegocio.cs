using Entidade.DTO;
using Repositorio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public UsuarioNegocio() { }

        public UsuarioDTO ValidarAcesso(string Acesso, string Senha)
        {
            UsuarioDTO resultado = new UsuarioRepositorio().ValidarAcesso(Acesso, Senha);

            if (resultado == null)
            {
                resultado = new UsuarioDTO();
                resultado.AcessoPermitido = false;
                resultado.AcessoMessagem = "Usuário não encontrado";
                //Acesso não encontrado
            }
            else if (resultado.Bloqueado == true)
            {
                resultado = new UsuarioDTO();
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
