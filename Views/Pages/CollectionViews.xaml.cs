using Views.Models;
using Image = Views.Models.Image;

namespace Views.Pages;

public partial class CollectionViews : ContentPage
{
	public CollectionViews()
	{
		InitializeComponent();
		BindingContext = new ImageViewModel(); // Define model to be used in views.
	}

    private void updateEmails_switchCell1_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("UpdateEmailsSwitchCell1", "Setting changed successfully!", "OK");
    }

    //  private async void carouselView1_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //  {
    //if (e.PreviousItem != null && e.CurrentItem != null)
    //      {
    //          Image previousImage = e.PreviousItem as Image;
    //          Image currentImage = e.CurrentItem as Image;
    //	await DisplayAlert("CarouselView1", $"Previous image: {previousImage.Name}\n" +
    //		$"Current image: {currentImage.Name}", "OK");
    //}
    //  }
}