using ExcelAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelAPI.Services
{
    public class UploadService:IUploadService
    {
        private readonly IUploadRepository repository;

        public UploadService(IUploadRepository repository)
        {
            this.repository = repository;
        }

        public void UploadData(string path)
        {
            repository.ImportStockPrice(path);
        }
   
        public void ExportData(string path)
        {
            repository.ExportStockPrice(path);
        }
    }
}
