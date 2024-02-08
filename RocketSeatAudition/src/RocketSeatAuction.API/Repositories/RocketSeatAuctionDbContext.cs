using Microsoft.EntityFrameworkCore;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories;

public class RocketSeatAuctionDbContext : DbContext
{
  public DbSet<Auction> Auctions { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Offer> Offers {  get; set; }   
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=H:\GitHub\NLW Expert - Trilha C#\RocketSeatAudition\src\RocketSeatAuction.API\DB\leilaoDbNLW.db");
    }
}
