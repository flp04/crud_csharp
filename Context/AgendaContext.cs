using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
  public class AgendaContext : DbContext
  {
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
      // services.AddDbContext<MyDbContext>(options =>
      //   options.UseMySql(
      //     connectionString,
      //     ServerVersion.AutoDetect(connectionString)));
    }

  public DbSet<Contato> Contatos { get; set;}

  // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  //   {
  //     if (!optionsBuilder.IsConfigured)
  //     {
  //       optionsBuilder.UseMySql(
  //           "server=localhost;database=conversor;user=root;password=Hungria*8",
  //           new MySqlServerVersion(new Version(8, 0, 21))
  //       );
  //     }
  //   }
  }
}