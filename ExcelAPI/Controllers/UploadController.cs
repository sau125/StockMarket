using ExcelAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UploadController : ControllerBase
    {
        UploadService service;

        public UploadController(UploadService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("UploadData")]
        public IActionResult UploadExcel(string path)
        {
            try
            {
                //string path = @"D:\sample_stock_data.xlsx";
                service.UploadData(path);
                return Ok("Records Uploaded");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error" + ex.Message);
            }

        }
        [HttpGet]
        [Route("ExportData")]
        public IActionResult ExportExcel(string path)
        {
            try
            {
                //string path = @"D:\sample_stock_data1.xlsx";
                service.ExportData(path);
                return Ok("Records Exported");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error" + ex.Message);
            }

        }
    }
}
