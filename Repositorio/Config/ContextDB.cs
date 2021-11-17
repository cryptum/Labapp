using Entidade;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositorio.Config
{
    public class ContextDB : DbContext
    {
        //MYSQL
        //const string connectionString = "server=localhost;user=root;password=root;database=betoapp";
        //MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

        //HEROKU MYSQL
        const string connectionString = "server=us-cdbr-east-04.cleardb.com;user=bb99f016b6b5bf;password=19b53d70;database=heroku_90e938867b37517";
        MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        public DbSet<AmostraEntidade> Amostras { get; set; }
        public DbSet<AnaliseEntidade> Analises { get; set; }
        public DbSet<CulturaEntidade> Culturas { get; set; }
        public DbSet<LocalEntidade> Locais { get; set; }
        public DbSet<ReferenciaEntidade> Referencias { get; set; }
        public DbSet<SolicitanteEntidade> Solicitantes { get; set; }
        public DbSet<TipoAnaliseEntidade> TipoAnalises { get; set; }
        public DbSet<TipoSolicitacaoEntidade> TipoSolicitacaos { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<AmostraEntidade>().HasKey(u => u.IdAmostras);

            modelBuilder.Entity<AnaliseEntidade>().HasKey(u => u.IdAnalise);
            modelBuilder.Entity<AnaliseEntidade>().HasOne(e => e.Solicitantes).WithMany(c => c.Analises);

            modelBuilder.Entity<CulturaEntidade>().HasKey(u => u.IdCultura);
            modelBuilder.Entity<CulturaEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<LocalEntidade>().HasKey(u => u.IdLocal);

            modelBuilder.Entity<ReferenciaEntidade>().HasKey(u => u.IdReferencia);

            modelBuilder.Entity<SolicitanteEntidade>().HasKey(u => u.IdSolicitante);
            modelBuilder.Entity<SolicitanteEntidade>().HasMany(bc => bc.Analises).WithOne(b => b.Solicitantes);

            modelBuilder.Entity<TipoAnaliseEntidade>().HasKey(u => u.IdTipoAnalise);
            modelBuilder.Entity<TipoAnaliseEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<TipoSolicitacaoEntidade>().HasKey(u => u.IdTipoSolicitacao);
            modelBuilder.Entity<TipoSolicitacaoEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<UsuarioEntidade>().HasKey(u => u.IdUsuario);

            base.OnModelCreating(modelBuilder);
        }

    }
}