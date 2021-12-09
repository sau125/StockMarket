using StockMarket.StockAPI.DBContext;
using StockMarket.StockAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Repositories
{
    public class StockRepository:IStockRepository
    {
        private readonly StockDBContext db;

        public StockRepository(StockDBContext db)
        {
            this.db = db;
        }

        public void AddCompany(Company company)
        {
            db.Companies.Add(company);
            db.SaveChanges();
        }

        public void DeleteCompany(string companyName)
        {
            Company company = db.Companies.SingleOrDefault(c => c.CompanyName == companyName);
            db.Companies.Remove(company);
            db.SaveChanges();
        }

        public List<Company> GetCompanies()
        {
            return db.Companies.ToList();
        }

        public Company GetCompany(string CompanyName)
        {
            Company company = db.Companies.Find(CompanyName);

            return company;

        }

        public void UpdateCompany(Company company)
        {
            db.Companies.Update(company);
            db.SaveChanges();
        }

        public List<IPODetails> GetIPODetails()
        {
            return db.IPOList.ToList();
        }

        public void AddIPO(IPODetails Value)
        {
            db.IPOList.Add(Value);
            db.SaveChanges();
        }

        public void DeleteIPO(int Id)
        {
            IPODetails IPO = db.IPOList.SingleOrDefault(i=>i.Id==Id);
            db.IPOList.Remove(IPO);
            db.SaveChanges();
        }

        public IPODetails GetIPOById(int Id)
        {
            IPODetails IPO = db.IPOList.Find(Id);
            return IPO;

        }

        public void UpdateIPO(IPODetails Value)
        {
            db.IPOList.Update(Value);
            db.SaveChanges();
        }
        public void AddStockExchange(StockExchange stock)
        {
            db.StockExchanges.Add(stock);
            db.SaveChanges();
        }
        public void DeleteStockExchange(StockExchange stock)
        {

            db.StockExchanges.Remove(stock);
            db.SaveChanges();
        }

        public List<StockExchange> GetStockExchanges()
        {
            return db.StockExchanges.ToList();
        }

        public StockExchange GetStockExchange(string stockid)
        {

            StockExchange stock = db.StockExchanges.Find(stockid);

            return stock;

        }

        public void UpdateStockExchange(StockExchange stock)
        {
            db.StockExchanges.Update(stock);
            db.SaveChanges();
        }

    }
}
