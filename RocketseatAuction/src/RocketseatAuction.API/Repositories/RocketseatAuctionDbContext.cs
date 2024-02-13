using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext:DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Soruce=C:\\Users\\Tarcísio\\Documents\\Programação\\NLW-Expert\\RocketseatAuction\\src\\RocketseatAuction.API\\leilaoDbNLW.db");
    }
}
