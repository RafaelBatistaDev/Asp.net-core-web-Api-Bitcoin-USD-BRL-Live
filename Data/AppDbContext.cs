using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Moeda> Moedas { get; set; } = null!;
    public DbSet<Produto> Produtos { get; set; } = null!;
}