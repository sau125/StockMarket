using Microsoft.EntityFrameworkCore;
using StockMarket.AccountAPI.Entities;

namespace StockMarket.AccountAPI.DBContext
{
    public class StockDBContext : DbContext

    {
        public StockDBContext(DbContextOptions<StockDBContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

    }

}


