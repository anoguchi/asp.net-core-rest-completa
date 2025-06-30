using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<Business.Models.Perfil> Perfis { get; set; }
    public DbSet<Business.Models.Endereco> Enderecos { get; set; }
    public DbSet<Business.Models.Setup> Setups { get; set; }

}