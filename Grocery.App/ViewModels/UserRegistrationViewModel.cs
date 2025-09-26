using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    public partial class UserRegistrationViewModel : ObservableObject
    {
        private readonly IAuthService _authService;

        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string password;
        [ObservableProperty] private string message;

        public UserRegistrationViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        [RelayCommand]
        private void Register()
        {
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Message = "Fill in all fields!";
                return;
            }

            var client = _authService.Register(Name, Email, Password);

            Message = "Registration complete!";
        }
    }
}