using Microsoft.AspNetCore.Mvc;
using StockMarket.StockAPI.Entities;
using StockMarket.StockAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService service;

        public StockController(IStockService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("GetAllCompanies")]
        public IActionResult GetCompanies()
        {
            try
            {
                List<Company> companies = service.GetCompanies();
                return Ok(companies);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompany/{CompanyName}")]
        public IActionResult GetCompany(string CompanyName)
        {
            try
            {
                Company company = service.GetCompany(CompanyName);
                return Ok(company);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCompany/{CompanyName}")]
        public IActionResult DeleteCompany(string CompanyName)
        {
            try
            {
                service.DeleteCompany(CompanyName);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                service.AddCompany(company);
                return Ok("Added");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateCompany")]
        public IActionResult UpdateCompnayDetail(Company company) //Update Item
        {
            try
            {
                service.UpdateCompany(company);
                return Ok("Updated");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllIPO")]
        public IActionResult GetAllIpo()
        {
            try
            {
                List<IPODetails> IPOLists = service.GetIPODetails();
                return Ok(IPOLists);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIPOById/{id}")]
        public IActionResult GetIPOById(int id)
        {
            try
            {
                IPODetails IPO = service.GetIPOById(id);
                return Ok(IPO);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteIPO/{id}")]
        public IActionResult DeleteIPO(int id)
        {
            try
            {
                service.DeleteIPO(id);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddIPO")]
        public IActionResult AddIPO(IPODetails Value)
        {
            try
            {
                service.AddIPO(Value);
                return Ok("Added");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateIPO")]
        public IActionResult UpdateIPO(IPODetails ipo) //Update Item
        {
            try
            {
                service.UpdateIPO(ipo);
                return Ok("Updated");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllStockExchanges")]
        public IActionResult GetStockExchange()
        {
            try
            {
                List<StockExchange> stock = service.GetStockExchanges();
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStockExchange/{stockid}")]
        public IActionResult GetStockExchange(string stockid)
        {
            try
            {
                StockExchange stock = service.GetStockExchange(stockid);
                return Ok(stock);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult Add(StockExchange stock)
        {
            try
            {
                
                
                service.AddStockExchange(stock);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("EditStockExchange")]
        public IActionResult Update(StockExchange stock)
        {
            try
            {
                service.UpdateStockExchange(stock);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                service.DeleteStockExchange(id);
                return Ok("deleted successfully");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
