namespace UF11027_MauiApp1;

public partial class ContentPage1 : ContentPage
{
	public ContentPage1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}