using System.Globalization;

namespace UF11027_Views.Pages;

public partial class ValueViews : ContentPage
{
	public ValueViews()
	{
		InitializeComponent();
	}

    private async void checkBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			await DisplayAlert("CheckBox1", "Checked.", "OK");
		}
		else
        {
            await DisplayAlert("CheckBox1", "Unchecked.", "OK");
        }
    }

    private async void checkBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox2", "Checked.", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox2", "Unchecked.", "OK");
        }

    }

    private async void checkBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox3", "Checked.", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox3", "Unchecked.", "OK");
        }

    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        int value = Convert.ToInt32(slider1.Value);
        slider1_label1.Text = value.ToString();
    }

    private void slider2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = Math.Round(slider2.Value, 1);
        slider2_label1.Text = value.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        stepper1_label1.Text = e.NewValue.ToString();
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch1", "Toggled on.", "OK");
        }
        else
        {
            await DisplayAlert("Switch1", "Toggled off.", "OK");
        }
    }

    private async void datePicker1_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("en-GB");
        var date = ((DatePicker)sender).Date;
        var selectedDate = date.ToString("d", culture);
        await DisplayAlert("DatePicker1", selectedDate, "OK");
    }

    private async void timePicker1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (timePicker1 != null)
        {
            var selectedTime = timePicker1.Time.ToString(@"hh\:mm");
            await DisplayAlert("TimePicker1", selectedTime, "OK");
        }
    }
}