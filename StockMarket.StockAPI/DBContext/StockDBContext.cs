using Microsoft.EntityFrameworkCore;
using StockMarket.StockAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.DBContext
{
    public class StockDBContext : DbContext

    {
        public StockDBContext(DbContextOptions<StockDBContext> options) : base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Sectors> SectorsList { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
        public DbSet<IPODetails> IPOList { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        

    }

}