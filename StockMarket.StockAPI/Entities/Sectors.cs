using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Entities
{
    [Table("Sectors")]
    public class Sectors
    {
        [Key]
        public string SectorId { get; set; }
        [StringLength(20)]
        [Required] //set as not null
        public string SectorName { get; set; }
    }

}
