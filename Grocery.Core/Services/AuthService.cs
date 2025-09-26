using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            Client? client = _clientService.Get(email);
            if (client == null) return null;
            if (PasswordHelper.VerifyPassword(password, client.Password)) return client;
            return null;
        }
        
        //client register class
        public Client Register(string name, string email, string password)
        {
            //make a new id
            int newId = _clientService.GetAll().Count + 1;
            
            //uc9 hash the password before saving
            string hashedPassword = PasswordHelper.HashPassword(password);
            
            //Create new client
            var newClient = new Client(newId, name, email, hashedPassword);
            
            //Save in repository
            _clientService.Add(newClient);
            
            return newClient;
        }
    }
}
