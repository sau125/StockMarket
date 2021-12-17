using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Entities
{
    [Table("StockPrice")]
    public class StockPrice
    {
        [Key]

        public string PriceId { get; set; }

        [Required] //set as not null
        public double CurrentStockPrice { get; set; }

        [ForeignKey("StockExchange")]
        public string StockExchangeId { get; set; }
        public StockExchange StockExchange { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }
    }
}
