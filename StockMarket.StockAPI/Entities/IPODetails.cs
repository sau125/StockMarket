using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Entities
{
    public class IPODetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("StockExchange")]
        public string StockExchangeCode { get; set; }

        [Required]
        public long PricePerShare { get; set; }
        public int TotalShare { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }


        public DateTime OpenDatetime { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarks { get; set; }
    }
}
