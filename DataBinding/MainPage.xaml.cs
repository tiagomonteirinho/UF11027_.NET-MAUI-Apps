using DataBinding.Models;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void button1_Clicked(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        Name = "Samsung Galaxy A53",
        //        Price = 579.00M,
        //        Stock = 1099
        //    };

        //    //Binding productBinding = new Binding();
        //    ////productBinding.Source = product.Name; // Replaced by separation.
        //    //productBinding.Source = product;
        //    //productBinding.Path = "Name";

        //    //label1.SetBinding(Label.TextProperty, productBinding); // SetBinding([view property], [binding]).

        //    Binding nameBinding = new Binding { Source = product, Path = "Name", StringFormat = "Product: {0}" };
        //    name_label1.SetBinding(Label.TextProperty, nameBinding);

        //    Binding priceBinding = new Binding { Source = product, Path = "Price", StringFormat = "Price: {0}" };
        //    price_label1.SetBinding(Label.TextProperty, priceBinding);

        //    Binding stockBinding = new Binding { Source = product, Path = "Stock", StringFormat = "Stock: {0}" };
        //    stock_label1.SetBinding(Label.TextProperty, stockBinding);
        //}
        // Implemented at view.
    }
}
