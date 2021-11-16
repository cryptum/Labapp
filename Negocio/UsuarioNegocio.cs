using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

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

        public List<UsuarioObterTodosDTO> ObterTodos()
        {
            return new UsuarioRepositorio().ObterTodos();
        }

        public List<UsuarioObterTodosDTO> ObterListaPorNome(string nome)
        {
            return new UsuarioRepositorio().ObterListaPorNome(nome);
        }

        public int Salvar(string nome, string acesso, string senha, bool administrador, bool bloqueado)
        {
            UsuarioEntidade usuario = new();
            usuario.Nome = nome.Trim();
            usuario.Acesso = acesso.Trim();
            usuario.Senha = senha.Trim();
            usuario.Administrador = administrador;
            usuario.Bloqueado = bloqueado;
            usuario.DataCriado = DateTime.Now;
            return new UsuarioRepositorio().Salvar(usuario);
        }

        public int Editar(int id, string nome, string acesso, string senha, bool administrador, bool bloqueado)
        {
            UsuarioEntidade usuario = new UsuarioRepositorio().ObterUmPorCodigo(id);
            if (usuario == null)
            {
                return 0;
            }
            usuario.Nome = nome.Trim();
            usuario.Acesso = acesso.Trim();
            usuario.Senha = senha.Trim();
            usuario.Administrador = administrador;
            usuario.Bloqueado = bloqueado;
            return new UsuarioRepositorio().Editar(usuario);
        }

        public int Excluir(int Id)
        {
            UsuarioEntidade usuario = new UsuarioRepositorio().ObterUmPorCodigo(Id);
            if (usuario == null)
            {
                return 0;
            }
            return new UsuarioRepositorio().Excluir(usuario);
        }

    }
}
