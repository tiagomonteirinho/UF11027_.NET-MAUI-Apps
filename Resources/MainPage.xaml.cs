using System.Text.Json;

namespace Resources
{
    public partial class MainPage : ContentPage
    {
        File file;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadMauiAsset();
        }

        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("JSONFile.json");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();

            var file = JsonSerializer.Deserialize<File>(contents);
            BindingContext = file;
        }
    }

    public class File
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Number { get; set; }
        public string Image { get; set; }
    }
}
