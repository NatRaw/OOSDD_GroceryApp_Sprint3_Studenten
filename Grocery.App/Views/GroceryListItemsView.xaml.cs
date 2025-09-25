using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
	
	//reset to full list after clearing search bar text
	private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (string.IsNullOrEmpty(e.NewTextValue)) // if cleared
		{
			var viewModel = (GroceryListItemsViewModel)BindingContext;
			viewModel.SearchProducts(string.Empty); // reset to full list
		}
	}
}