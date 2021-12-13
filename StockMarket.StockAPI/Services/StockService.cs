using StockMarket.StockAPI.Entities;
using StockMarket.StockAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Services
{
    public class StockService:IStockService
    {
        private readonly IStockRepository repository;

        public StockService(IStockRepository repository)
        {
            this.repository = repository;
        }

        public void AddCompany(Company company)
        {
            try
            {
                repository.AddCompany(company);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void AddIPO(IPODetails Value)
        {
            try
            {
                repository.AddIPO(Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteCompany(string companyName)
        {
            try
            {
                repository.DeleteCompany(companyName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteIPO(int Id)
        {
            try
            {
                repository.DeleteIPO(Id);
            }
            catch
            {
                throw;
            }
        }

        public List<Company> GetCompanies()
        {
            try
            {
                return repository.GetCompanies();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Company GetCompany(string CompanyName)
        {
            try
            {
                return repository.GetCompany(CompanyName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IPODetails GetIPOById(int Id)
        {
            try
            {
                return repository.GetIPOById(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<IPODetails> GetIPODetails()
        {
            try
            {
                return repository.GetIPODetails();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCompany(Company company)
        {
            try
            {
                repository.UpdateCompany(company);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateIPO(IPODetails Value)
        {
            try
            {
                repository.UpdateIPO(Value);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddStockExchange(StockExchange stock)
        {
            try{
                repository.AddStockExchange(stock);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public void DeleteStockExchange(string id)
        {
            try
            {
                StockExchange stock = this.GetStockExchange(id);
                repository.DeleteStockExchange(stock);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<StockExchange> GetStockExchanges()
        {
            try
            {
                return repository.GetStockExchanges();
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public StockExchange GetStockExchange(string stockid)
        {
            try
            {
                return repository.GetStockExchange(stockid);
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void UpdateStockExchange(StockExchange stock)
        {
            try
            {
                repository.UpdateStockExchange(stock);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
