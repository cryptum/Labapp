﻿using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LocalNegocio
    {
        public List<LocalDTO> ObterTodos(int idSolicitante)
        {
            return new LocalRepositorio().ObterTodos(idSolicitante, false);
        }


        public List<LocalDTO> ObterListaPorNome(int idSolicitante, string nome)
        {
            return new LocalRepositorio().ObterListaPorNome(idSolicitante, nome, false);
        }

        public int Salvar(String fazenda, String municipio, int idSolicitante)
        {
            LocalEntidade Local = new LocalEntidade();
            Local.Fazenda = fazenda;
            Local.Municipio = municipio;
            //Local.Solicitantes = Solici
            Local.Excluido = false;
            return new LocalRepositorio().Salvar(Local);
        }

        public int Editar(int Id, String Nome, String Observacao)
        {
            LocalEntidade Local = new LocalRepositorio().ObterUmPorCodigo(Id);
            if (Local == null)
            {
                return 0;
            }
            //Local.Nome = Nome;
            //Local.Observacao = Observacao;
            return new LocalRepositorio().Editar(Local);
        }

        public int ExcluirLogicamente(int Id, bool Excluido)
        {
            LocalEntidade Local = new LocalRepositorio().ObterUmPorCodigo(Id);
            if (Local == null)
            {
                return 0;
            }
            Local.Excluido = true;
            return new LocalRepositorio().Editar(Local);
        }
    }
}
