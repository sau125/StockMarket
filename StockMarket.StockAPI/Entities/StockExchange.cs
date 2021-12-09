using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Entities
{
    [Table("StockExchange")]
    public class StockExchange
    {
        [Key]
        [StringLength(3)]
        public string ID { get; set; }

        [Required]
        [StringLength(30)]
        public string StockExchangeName { get; set; }


        [Required]
        [StringLength(500)]
        public string Brief { get; set; }

        [Required]
        [StringLength(100)]
        public string ContactAddress { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }

        public DateTime Timestamp { get; set; }


    }

}

