using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services; 
using Grocery.Core.Services; 

namespace Grocery.App.Views;

public partial class UserRegistrationView : ContentPage
{
    public UserRegistrationView(UserRegistrationViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    
    public UserRegistrationView()
    {
        InitializeComponent();

        // Manually create the ViewModel
        var authService = new AuthService(
            App.Current.Handler.MauiContext.Services.GetService<IClientService>()
        );

        BindingContext = new UserRegistrationViewModel(authService);
    }
}