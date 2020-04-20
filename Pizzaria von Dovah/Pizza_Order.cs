using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_von_Dovah
{
    public class Pizza_Order : INotifyPropertyChanged
    {
        private string _pizza_name;
        public string pizza_name
        {
            get { return _pizza_name; }
            set
            {
                if (_pizza_name != value)
                {
                    _pizza_name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _pizza_price;
        public string pizza_price
        {
            get { return _pizza_price; }
            set
            {
                if (_pizza_price != value)
                {
                    _pizza_price = value;
                    OnPropertyChanged();
                }
            }
        }

        public Pizza_Order(string pizza_name, string pizza_price)
        {
            this.pizza_name = pizza_name;
            this.pizza_price = pizza_price;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
