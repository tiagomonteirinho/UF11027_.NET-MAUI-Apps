namespace BillSplitter;

public partial class MainPage : ContentPage
{
    decimal bill;
    int tip;
    int customerQuantity = 1;

    public MainPage()
    {
        InitializeComponent();
    }

    private void bill_entry_Completed(object sender, EventArgs e)
    {
        bill = decimal.Parse(bill_entry.Text);
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        var tipTotal =
             (bill * tip) / 100;


        var customerTip = (tipTotal / customerQuantity);
        customerTip_label.Text = $"{customerTip:C}";

        var subtotal = (bill / customerQuantity);
        subtotal_label.Text = $"{subtotal:C}";

        var total =
             (bill + tipTotal) / customerQuantity;
        total_label.Text = $"{total:C}";
    }

    private void tip_slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        tip = (int)tip_slider.Value;
        tip_label.Text = $"Tip: {tip}%";
        CalculateTotal();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            var btn = (Button)sender;
            var percentage =
                 int.Parse(btn.Text.Replace("%", ""));
            tip_slider.Value = percentage;
        }
    }

    private void remove_button_Clicked(object sender, EventArgs e)
    {
        if (customerQuantity > 1)
        {
            customerQuantity--;
        }

        customerQuantity_label.Text = customerQuantity.ToString();
        CalculateTotal();
    }

    private void add_button_Clicked(object sender, EventArgs e)
    {
        customerQuantity++;
        customerQuantity_label.Text = customerQuantity.ToString();
        CalculateTotal();
    }

    private void reset_button_Clicked(object sender, EventArgs e)
    {
        bill = 0.00m;
        tip = 0;
        bill_entry.Text = "";
        tip_slider.Value = 0;
        customerQuantity_label.Text = "1";
        customerQuantity = 1;
        CalculateTotal();
    }
}
