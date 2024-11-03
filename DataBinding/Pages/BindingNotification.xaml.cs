using DataBinding.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace DataBinding.Pages;

public partial class BindingNotification : ContentPage
{
	Product product = new Product();

	public BindingNotification()
	{
        InitializeComponent();   
        
        product = new Product
        {
            Name = "Samsung Galaxy A53",
            Price = 579.00M,
            Stock = 1099
        };

        BindingContext = product;
    }

    private async void update_button1_Clicked(object sender, EventArgs e)
    {
        product.Name = "Apple iPhone 14";
        product.Price = 770.00M;
        product.Stock = 899;

        await DisplayAlert("Product update", "Product updated successfully!", "OK");
    }
}