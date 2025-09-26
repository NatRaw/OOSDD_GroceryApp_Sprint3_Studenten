﻿
using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Client? Login(string email, string password);
        
        //added for register
        Client? Register(string name, string email, string password);
    }
}
