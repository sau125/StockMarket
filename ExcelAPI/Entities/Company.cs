using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelAPI.Entities
{
    [Table("Company")]
    public class Company
    {

        [Key]
        public string CompanyName { get; set; }

        [Required]
        public float CompanyTurnOver { get; set; }

        public string CEO { get; set; }
        public string BoardOfDirectors { get; set; }
        public string ListedInStockExchanges { get; set; }

        [StringLength(500)]
        public string CompanyBrief { get; set; }

        [ForeignKey("StockPrice")]
        public string CompanyCode { get; set; }
        public StockPrice StockPrice { get; set; }

        [ForeignKey("Sectors")]
        public string SectorId { get; set; }
        public Sectors Sectors { get; set; }
    }
}
