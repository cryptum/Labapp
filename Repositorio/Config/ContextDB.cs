using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repositorio.Config
{
    public class ContextDB : DbContext
    {
        const string connectionString = "server=localhost;user=root;password=root;database=betoapp";

        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        public DbSet<AnaliseEntidade> Analises { get; set; }
        public DbSet<CulturaEntidade> Culturas { get; set; }
        public DbSet<EntradaEntidade> Entradas { get; set; }
        public DbSet<LaudoEntidade> Laudos { get; set; }
        public DbSet<LocalEntidade> Locais { get; set; }
        public DbSet<ReferenciaEntidade> Referencias { get; set; }
        public DbSet<SolicitacaoEntidade> Solicitacaos { get; set; }
        public DbSet<SolicitanteEntidade> Solicitantes { get; set; }
        public DbSet<TipoAnaliseEntidade> TipoAnalises { get; set; }
        public DbSet<TipoSolicitacaoEntidade> TipoSolicitacaos { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnaliseEntidade>();
            modelBuilder.Entity<CulturaEntidade>();
            modelBuilder.Entity<EntradaEntidade>();
            modelBuilder.Entity<LaudoEntidade>();
            modelBuilder.Entity<LocalEntidade>();
            modelBuilder.Entity<ReferenciaEntidade>();
            modelBuilder.Entity<SolicitacaoEntidade>();
            modelBuilder.Entity<SolicitanteEntidade>();
            modelBuilder.Entity<TipoAnaliseEntidade>();
            modelBuilder.Entity<TipoSolicitacaoEntidade>();
            modelBuilder.Entity<UsuarioEntidade>();
            base.OnModelCreating(modelBuilder);
        }

    }
}