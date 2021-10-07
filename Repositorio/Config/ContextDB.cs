using System;
using Entidade;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Config
{
    public class ContextDB : DbContext
    {
        //MYSQL
        const string connectionString = "server=localhost;user=root;password=root;database=betoapp";
        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

        //HEROKU MYSQL
        //const string connectionString = "server=us-cdbr-east-04.cleardb.com;user=b6e9f8aa4e49dd;password=a4d7bcf8;database=heroku_85a77976580b632";
        //MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

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
        public DbSet<SolicitanteEntidade> Solicitantes { get; set; }
        public DbSet<TipoAnaliseEntidade> TipoAnalises { get; set; }
        public DbSet<TipoSolicitacaoEntidade> TipoSolicitacaos { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //builder.Entity<Notification>().HasOne(e => e.Shipment).WithMany(c => c.Notification);
            //builder.Entity<NotificationFile>().HasKey(u => u.Id);

            modelBuilder.Entity<AnaliseEntidade>().HasKey(u => u.IdAnalise);

            modelBuilder.Entity<CulturaEntidade>().HasKey(u => u.IdCultura);

            modelBuilder.Entity<EntradaEntidade>().HasKey(u => u.IdEntrada);

            modelBuilder.Entity<LaudoEntidade>().HasKey(u => u.IdLaudo);

            modelBuilder.Entity<LocalEntidade>().HasKey(u => u.IdLocal);
            //modelBuilder.Entity<LocalEntidade>().HasOne(e => e.Solicitante).WithOne(c => c.IdSolicitante);

            modelBuilder.Entity<ReferenciaEntidade>().HasKey(u => u.IdReferencia);

            modelBuilder.Entity<SolicitanteEntidade>().HasKey(u => u.IdSolicitante);

            modelBuilder.Entity<TipoAnaliseEntidade>().HasKey(u => u.IdTipoAnalise);

            modelBuilder.Entity<TipoSolicitacaoEntidade>().HasKey(u => u.IdTipoSolicitacao);

            modelBuilder.Entity<UsuarioEntidade>().HasKey(u => u.IdUsuario);

            base.OnModelCreating(modelBuilder);
        }

    }
}