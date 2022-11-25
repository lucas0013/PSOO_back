using Microsoft.EntityFrameworkCore;

namespace lojaGeekAPI.Models;

public class lojaGeekAPIContext : DbContext
{
    public lojaGeekAPIContext(DbContextOptions<lojaGeekAPIContext> options)
        : base(options)
    {
    }
    public DbSet<Produto> Produto { get; set; } = null!;
    public DbSet<Usuario> Usuario { get; set; } = null!;
    public DbSet<Carrinho> Carrinho { get; set; } = null!;
    public DbSet<Pagamento> Pagamento { get; set; } = null!;
    public DbSet<Pedido> Pedido { get; set; } = null!;

}