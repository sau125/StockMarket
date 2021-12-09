using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StockMarket.AccountAPI.Entities;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;
        readonly ITokenService tokenService;

        public AccountController(IUserService _userService, ITokenService _tokenService)
        {
            userService = _userService;
            tokenService = _tokenService;
            
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                string userResult =userService.Register(user);
                return Created("api/created", userResult);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);


            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                AuthUser authUser = null;
                User user = userService.Login(login);

                if (user != null)
                {
                    authUser = new AuthUser()
                    {
                        UserId = user.UserId,
                        Token = tokenService.GetToken(user),
                        Role = user.Role
                    };
                }

                if (authUser != null)
                    return Created("api/Created", authUser);
                else
                {
                    throw new Exception("User not found");
                }

            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message);
                return NotFound(ex.Message);

            }
        }

    }
}
