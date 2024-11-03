using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Models
{
    public class Product :
        INotifyPropertyChanged // Automatically show changes at UI when updated.
    {
        string name;
        decimal price;
        int stock;

        public string Name { 
            get => name; 
            set
            {
                name = value;
                //OnPropertyChanged(name);
                OnPropertyChanged(); // Gets property name by CallerMemberName.
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null) // Automatically get name of changed property.
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName)); // Invoke PropertyChanged.
        }
    }
}
