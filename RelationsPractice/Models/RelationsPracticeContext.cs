using Microsoft.EntityFrameworkCore;

namespace RelationsPractice.Models
{
  public class RelationsPracticeContext : DbContext
  {
    public DbSet<NonProfit> NonProfits { get; set; }
    public DbSet<BoardMember> BoardMembers { get; set; }
    
    public RelationsPracticeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}