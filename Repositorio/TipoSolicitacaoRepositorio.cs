﻿using Repositorio.Config;
using Entidade.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class TipoSolicitacaoRepositorio
    {

        public TipoSolicitacaoRepositorio() { }

        public List<TipoSolicitacaoDTO> ObterTodos()
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoSolicitacaos
                                .Select(x => new TipoSolicitacaoDTO
                                {
                                    Código = x.IdTipoSolicitacao,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public List<TipoSolicitacaoNomesDTO> ObterTodosOsNomes()
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoSolicitacaos
                                .Select(x => new TipoSolicitacaoNomesDTO
                                {
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public TipoSolicitacaoEntidade ObterUmPorCodigo(int id)
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoSolicitacaos
                                .Where(w => w.IdTipoSolicitacao == id)
                                .FirstOrDefault();

                return query;
            }
        }

        public List<TipoSolicitacaoDTO> ObterListaPorNome(string nome)
        {
            using (var db = new ContextDB())
            {
                var query = db.TipoSolicitacaos
                                .Where(w => EF.Functions.Like(w.Nome, "%" + nome + "%"))
                                .Select(x => new TipoSolicitacaoDTO
                                {
                                    Código = x.IdTipoSolicitacao,
                                    Nome = x.Nome
                                })
                                .ToList();

                return query;
            }
        }

        public int Salvar(TipoSolicitacaoEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.TipoSolicitacaos.Add(TipoSolicitacao);
                db.SaveChanges();
            }

            return TipoSolicitacao.IdTipoSolicitacao;
        }

        public int Editar(TipoSolicitacaoEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.Entry<TipoSolicitacaoEntidade>(TipoSolicitacao).State = EntityState.Modified;
                db.SaveChanges();
            }

            return TipoSolicitacao.IdTipoSolicitacao;
        }

        public int Excluir(TipoSolicitacaoEntidade TipoSolicitacao)
        {
            using (var db = new ContextDB())
            {
                db.Remove(TipoSolicitacao);
                db.SaveChanges();
            }

            return TipoSolicitacao.IdTipoSolicitacao;
        }
    }
}
