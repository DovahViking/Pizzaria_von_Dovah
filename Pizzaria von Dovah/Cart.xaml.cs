using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizzaria_von_Dovah
{
    /// <summary>
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Page
    {
        public ObservableCollection<Pizza_Order> pizza_orders { get; set; } // XAML can only read from properties, but not fields, hence the 'get' and 'set'

        public Cart(ObservableCollection<Pizza_Order> pizza_orders)
        {
            this.pizza_orders = pizza_orders;
            InitializeComponent();
            this.DataContext = this; // Bindings will read from this value, so by setting it to "this" it will have the same members as this class
                                     // meaning one of the members will be your "pizza_orders" from the above.
                                     // There's probably a nicer way to achieve this
        }
    }
}
