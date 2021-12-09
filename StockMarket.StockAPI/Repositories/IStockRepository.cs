using StockMarket.StockAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.StockAPI.Repositories
{
    public interface IStockRepository
    {
        void AddCompany(Company company);
        void DeleteCompany(string CompanyName);
        List<Company> GetCompanies();
        Company GetCompany(string CompanyName);
        void UpdateCompany(Company company);

        List<IPODetails> GetIPODetails();
        public void AddIPO(IPODetails Value);
        public void DeleteIPO(int Id);
        public IPODetails GetIPOById(int Id);
        public void UpdateIPO(IPODetails Value);
        void AddStockExchange(StockExchange stock);
        void DeleteStockExchange(StockExchange stock);
        List<StockExchange> GetStockExchanges();
        StockExchange GetStockExchange(string stockid);
        void UpdateStockExchange(StockExchange stock);
    }
}
