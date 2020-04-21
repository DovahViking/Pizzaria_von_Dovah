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
        static ObservableCollection<Pizza_Order> pizza_orders; // Shows Counter = 1 if a pizza is added to the Cart
                                                               // No idea if this setup is right though

        public Cart(ObservableCollection<Pizza_Order> pizza_orders)
        {
            Cart.pizza_orders = pizza_orders;
            InitializeComponent();
            DataContext = Cart.pizza_orders; // No idea what DataContext should be
        }
    }
}
