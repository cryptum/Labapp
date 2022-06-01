using Entidade;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositorio.Config
{
    public class ContextDB : DbContext
    {
        //HEROKU MYSQL
        //const string connectionString = "server=us-cdbr-east-04.cleardb.com;user=bb99f016b6b5bf;password=19b53d70;database=heroku_90e938867b37517";
        //MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Env env = new();
            string connectionString = null;
            MySqlServerVersion serverVersion = null;

            switch (env.Select)
            {
                case Environments.local:
                    connectionString = "server=localhost;user=root;password=rootroot;database=LabAPP";
                    serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
                    optionsBuilder.UseMySql(connectionString, serverVersion);
                    break;

                case Environments.beto:
                    connectionString = "server=us-cdbr-east-04.cleardb.com;user=b6e9f8aa4e49dd;password=a4d7bcf8;database=heroku_85a77976580b632";
                    serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
                    optionsBuilder.UseMySql(connectionString, serverVersion);
                    break;

                case Environments.preisser:
                    connectionString = "server=us-cdbr-east-04.cleardb.com;user=bb99f016b6b5bf;password=19b53d70;database=heroku_90e938867b37517";
                    serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
                    optionsBuilder.UseMySql(connectionString, serverVersion);
                    break;

                case Environments.betoInMemory:
                    optionsBuilder.UseInMemoryDatabase("betoInMemory");
                    break;

                case Environments.preisserInMemory:
                    optionsBuilder.UseInMemoryDatabase("preisserInMemory");
                    break;

                case Environments.paginaUnica:
                    connectionString = "server=localhost;user=root;password=root;database=LabAPP";
                    serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
                    optionsBuilder.UseMySql(connectionString, serverVersion);
                    break;

                case Environments.paginaUnicaInMemory:
                    optionsBuilder.UseInMemoryDatabase("PUInMemory");
                    break;

                default:
                    this.Dispose();
                    break;
            }
        }
        public DbSet<AmostraEntidade> Amostras { get; set; }
        public DbSet<AnaliseEntidade> Analises { get; set; }
        public DbSet<CulturaEntidade> Culturas { get; set; }
        public DbSet<FazendaEntidade> Fazendas { get; set; }
        public DbSet<ReferenciaEntidade> Referencias { get; set; }
        public DbSet<ProprietarioEntidade> Proprietarios { get; set; }
        public DbSet<TipoAnaliseEntidade> TipoAnalises { get; set; }
        public DbSet<ConvenioEntidade> Convenios { get; set; }
        public DbSet<UsuarioEntidade> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<AmostraEntidade>().HasKey(u => u.IdAmostras);

            modelBuilder.Entity<AnaliseEntidade>().HasKey(u => u.IdAnalise);
            modelBuilder.Entity<AnaliseEntidade>().HasOne(e => e.Proprietarios).WithMany(c => c.Analises);

            modelBuilder.Entity<CulturaEntidade>().HasKey(u => u.IdCultura);
            modelBuilder.Entity<CulturaEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<FazendaEntidade>().HasKey(u => u.IdFazenda);

            modelBuilder.Entity<ReferenciaEntidade>().HasKey(u => u.IdReferencia);

            modelBuilder.Entity<ProprietarioEntidade>().HasKey(u => u.IdProprietario);
            modelBuilder.Entity<ProprietarioEntidade>().HasMany(bc => bc.Analises).WithOne(b => b.Proprietarios);

            modelBuilder.Entity<TipoAnaliseEntidade>().HasKey(u => u.IdTipoAnalise);
            modelBuilder.Entity<TipoAnaliseEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<ConvenioEntidade>().HasKey(u => u.IdConvenio);
            modelBuilder.Entity<ConvenioEntidade>().HasIndex(u => u.Nome).IsUnique();

            modelBuilder.Entity<UsuarioEntidade>().HasKey(u => u.IdUsuario);

            base.OnModelCreating(modelBuilder);
        }

    }
}