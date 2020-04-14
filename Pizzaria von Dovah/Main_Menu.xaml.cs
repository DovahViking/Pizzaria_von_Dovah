using System;
using System.Collections.Generic;
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
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
        bool cart = false;
        Cart shopping_cart = new Cart();

        public Main_Menu()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void main_menu_menu_Click(object sender, RoutedEventArgs e)
        {
            main_menu_frame.Content = new Menu();
        }

        private void main_menu_do_it_yourself_Click(object sender, RoutedEventArgs e)
        {
            main_menu_frame.Content = new Do_it_yourself();
        }

        private void main_menu_cart_Click(object sender, RoutedEventArgs e)
        {
            if (cart == false) // Only used for when I made a new shopping_cart when you clicked the "Cart" button
            {
                main_menu_frame.Content = shopping_cart;
                cart = true;
            }
            else
            {
                main_menu_frame.Content = shopping_cart;
                // main_menu_cart = null; // gets rid of the exception but removes the fucking Cart xd
                // main_menu_frame.Navigate(main_menu_cart); // returns exception

                // NavigationService nav = NavigationService.GetNavigationService(this);
                // nav.Navigate(new Uri("Cart.xaml", UriKind.RelativeOrAbsolute));

                // User Controls?
            }
        }
    }
}
