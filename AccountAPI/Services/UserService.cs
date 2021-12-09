using StockMarket.AccountAPI.Entities;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }
        public User Login(Login login)
        {
            try
            {
                return repository.Login(login);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string Register(User user)
        {
            try
            {
                var userResult = repository.Register(user);
                return userResult == 1 ? "success" : "failure";

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
