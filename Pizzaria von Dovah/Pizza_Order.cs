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
        private string _order_name;
        public string order_name
        {
            get { return _order_name; }
            set
            {
                if (_order_name != value)
                {
                    _order_name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_price;
        public string order_price
        {
            get { return _order_price; }
            set
            {
                if (_order_price != value)
                {
                    _order_price = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_size;
        public string order_size
        {
            get { return _order_size; }
            set
            {
                if (_order_size != value)
                {
                    _order_size = value;
                    OnPropertyChanged();
                }
            }
        }

        public Pizza_Order(string order_name, string order_price, string order_size)
        {
            this.order_name = order_name;
            this.order_price = order_price;
            this.order_size = order_size;
        }

        // OVERLOAD CONSTRUCTOR FOR Do_it_yourself

        private string _order_dough;
        public string order_dough
        {
            get { return _order_dough; }
            set
            {
                if (_order_dough != value)
                {
                    _order_dough = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_sauce;
        public string order_sauce
        {
            get { return _order_sauce; }
            set
            {
                if (_order_sauce != value)
                {
                    _order_sauce = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_toppings;
        public string order_toppings
        {
            get { return _order_toppings; }
            set
            {
                if (_order_toppings != value)
                {
                    _order_toppings = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_cheese;
        public string order_cheese
        {
            get { return _order_cheese; }
            set
            {
                if (_order_cheese != value)
                {
                    _order_cheese = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _order_spice;
        public string order_spice
        {
            get { return _order_spice; }
            set
            {
                if (_order_spice != value)
                {
                    _order_spice = value;
                    OnPropertyChanged();
                }
            }
        }

        public Pizza_Order(string order_name, string order_price, string order_size, string order_dough, string order_sauce, string order_toppings, string order_cheese, string order_spice)
        {
            this.order_name = order_name;
            this.order_price = order_price;
            this.order_size = order_size;
            this.order_dough = order_dough;
            this.order_sauce = order_sauce;
            this.order_toppings = order_toppings;
            this.order_cheese = order_cheese;
            this.order_spice = order_spice;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
