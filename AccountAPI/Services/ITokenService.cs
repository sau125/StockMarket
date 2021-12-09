using StockMarket.AccountAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public interface ITokenService
    {
        string GetToken(User user);
    }
}
