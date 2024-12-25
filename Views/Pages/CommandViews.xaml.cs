namespace Views.Pages;

public partial class CommandViews : ContentPage
{
	public CommandViews()
	{
		InitializeComponent();
	}

    private async void button1_Clicked(object sender, EventArgs e)
    {
		await label1.RelRotateTo(360, 1000);
		await DisplayAlert("Button clicked", "Button action executed successfully!", "OK");
    }

    private async void imageButton1_Clicked(object sender, EventArgs e)
    {
        await label1.RelRotateTo(360, 3000);
    }

    private void secondaryColours_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = (RadioButton)sender;
        secondaryColours_label1.Text = $"Selected: {selectedRadioButton.Value}";
    }

    private async void searchBar1_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        await DisplayAlert("Searching...", $"{searchBar.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", "Item selected successfully!", "Ok");
    }
}