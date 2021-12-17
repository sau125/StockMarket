using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcelAPI.Entities;

namespace ExcelAPI.Repositories
{
    public interface IUploadRepository
    {
        public IList<StockPrice> ImportStockPrice(string filePath);
        public string ExportStockPrice(string filePath);
    }
}
