using Microsoft.EntityFrameworkCore;

namespace joaoPedro.Models;

public class AppDbContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }

    public DbSet<FolhaPagamento> FolhasPagamento { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=pablo_joaoPedro.db");
    }

}

