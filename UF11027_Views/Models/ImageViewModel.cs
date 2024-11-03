using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF11027_Views.Models
{
    public class ImageViewModel
    {
        public ObservableCollection<Image> images { get; private set; }

        public ObservableCollection<Image> Images // 'ObservableCollection': automatically show changes in UI when updated.
        {
            get { return images; }
            set { images = value; }
        }

        public ImageViewModel()
        {
            Images = new ObservableCollection<Image>()
            {
                new Image() { Name = ".NET MAUI Bot 1", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 2", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 3", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 4", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 5", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 6", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 7", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 8", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 9", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 10", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 11", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 12", ImageUrl = "dotnet_bot.png" },
                new Image() { Name = ".NET MAUI Bot 13", ImageUrl = "dotnet_bot.png" },
            };
        }
    }
}
