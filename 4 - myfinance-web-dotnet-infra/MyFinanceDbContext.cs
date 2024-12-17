using Microsoft.EntityFrameworkCore;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDbContext : DbContext
{
  public DbSet<PlanoConta> PlanoConta{get;set;}
  public DbSet<Transacao> Transacao{get;set;}
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server=MARCELODELLG3\SQLEXPRESS01;Database=myfinance;Trusted_Connection=True;");
  }
}
