namespace UF11027_Views.Pages;

public partial class ActionViews : ContentPage
{
	public ActionViews()
	{
		InitializeComponent();
        BindingContext = this;
        IsBusy = false;
        button1.Clicked += button1_Clicked;
	}

    private async void button1_Clicked(object? sender, EventArgs e)
    {
        IsBusy = true;
        await Task.Delay(3000);
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
        await DisplayAlert("Entry1", $"Old text: {e.OldTextValue}\nNew text: {e.NewTextValue}\n" +
            $"Current text: {entry1.Text}", "OK");
    }

    private async void entry1_Completed(object sender, EventArgs e)
    {
        await DisplayAlert("Entry1", $"Submitted text: {((Entry)sender).Text}", "OK");
    }

    private async void progressBar1_button1_Clicked(object sender, EventArgs e)
    {
        await progressBar1.ProgressTo(.75, 500, Easing.Linear);
    }
}