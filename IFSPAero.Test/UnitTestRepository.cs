using IFSPAero.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace IFSPAero.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Aeroporto> Aeroporto { get; set; }
            public DbSet<Aviao> Aviai { get; set; }
            public DbSet<AviaoEstacionado> AviaoEstacionado { get; set; }
            public DbSet<Companhia> Companhia { get; set; }
            public DbSet<Funcao> Funcao { get; set; }
            public DbSet<Funcionario> Funcionario { get; set; }
            public DbSet<Hangar> Hangar { get; set; }
            public DbSet<TipoVoo> TipoVoo { get; set; }
            public DbSet<Voo> Voo { get; set; }
            public MyDbContext() {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "mydb";
                var username = "root";
                var password = "123a";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

        }
        [TestMethod]
        public void TestInsertAeroporto()
        {
            using (var context = new MyDbContext()) {
                var aeroporto = new Aeroporto
                {
                    Nome = "Congonhas",
                    Codigo = "CGH",
                    Cidade = "São Paulo",
                    Pais = "Brasil"
                };

                context.Aeroporto.Add(aeroporto);

                aeroporto = new Aeroporto
                {
                    Nome = "Guarulhos",
                    Codigo = "GRU",
                    Cidade = "Guarulhos",
                    Pais = "Brasil"
                };

                context.Aeroporto.Add(aeroporto);
                context.SaveChanges();
            }

        }
    }

}
