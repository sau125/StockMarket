using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelAPI.Services
{
    public interface IUploadService
    {
        void UploadData(string path);
        void ExportData(string path);
    }
}
