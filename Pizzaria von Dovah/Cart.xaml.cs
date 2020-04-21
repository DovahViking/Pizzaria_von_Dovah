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
        static ObservableCollection<Pizza_Order> pizza_orders;

        public Cart(ObservableCollection<Pizza_Order> pizza_orders)
        {
            Cart.pizza_orders = pizza_orders; // "this.pizza_orders = pizza_orders;" returns instance reference error, therefore; Cart.pizza_orders = pizza_orders;
            InitializeComponent();
            PizzaGrid.ItemsSource = pizza_orders; // Avoid using DataContext and instead apply the ItemsSource to the list
        }
    }
}
