using StockMarket.AccountAPI.Entities;
using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.DBContext;

namespace StockMarket.AccountAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StockDBContext context;
        public UserRepository(StockDBContext context)
        {
            this.context = context;
        }
        public User Login(Login login)
        {
            return context.Users.SingleOrDefault(e => e.Email == login.Email && e.Password == login.Password);
        }

        public int Register(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges();

        }
    }
}
