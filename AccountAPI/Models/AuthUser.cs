﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Models
{
    public class AuthUser
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
