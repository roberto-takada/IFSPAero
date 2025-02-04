using System.Data.Common;
using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using IFSPAero.Repository.Mapping;

namespace IFSPAero.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Aeroporto> Aeroporto { get; set; }
        public DbSet<Companhia> Companhia { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<Hangar> Hangar { get; set; }
        public DbSet<Aviao> Aviao { get; set; }
        public DbSet<TipoVoo> TipoVoo { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<AviaoEstacionado> AviaoEstacionado { get; set; }
        public DbSet<Voo> Voo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aeroporto>(new AeroportoMap().Configure);
            modelBuilder.Entity<Companhia>(new CompanhiaMap().Configure);
            modelBuilder.Entity<Funcao>(new FuncaoMap().Configure);
            modelBuilder.Entity<Hangar>(new HangarMap().Configure);
            modelBuilder.Entity<Aviao>(new AviaoMap().Configure);
            modelBuilder.Entity<TipoVoo>(new TipoVooMap().Configure);
            modelBuilder.Entity<Funcionario>(new FuncionarioMap().Configure);
            modelBuilder.Entity<AviaoEstacionado>(new AviaoEstacionadoMap().Configure);
            modelBuilder.Entity<Voo>(new VooMap().Configure);

        }
    }
}

