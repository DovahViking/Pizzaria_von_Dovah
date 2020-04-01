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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public ObservableCollection<Pizza_name> pizza_orders = new ObservableCollection<Pizza_name>();

        public Menu()
        {
            //Pizza pizza1 = new Pizza("pizzaaaaaaaa", "qqqq", "32");
            InitializeComponent();
        }

        private void menu_medium_pizza_button_Click(object sender, RoutedEventArgs e)
        {
            pizza_price1.Text = "7.00";
            pizza_price2.Text = "13.00";
            pizza_price3.Text = "15.00";
        }

        private void menu_family_pizza_button_Click(object sender, RoutedEventArgs e)
        {

            if (pizza_price1.Text != "7.00")
            {
                menu_family_pizza_button.IsEnabled = false;
            }
            else
            {
                double family_price1 = Convert.ToDouble(pizza_price1.Text) * 1.5;
                pizza_price1.Text = Convert.ToString(family_price1);
                double family_price2 = Convert.ToDouble(pizza_price2.Text) * 1.5;
                pizza_price2.Text = Convert.ToString(family_price2);
                double family_price3 = Convert.ToDouble(pizza_price3.Text) * 1.5;
                pizza_price3.Text = Convert.ToString(family_price3);
            }
            menu_family_pizza_button.IsEnabled = true;
        }

        private void add_to_cart_button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(pizza_order1)) // tried with switch/case but got type exception
            {
                pizza_orders.Add(new Pizza_name(pizza_name1.Text));
            }
            if (sender.Equals(pizza_order2))
            {
                pizza_orders.Add(new Pizza_name(pizza_name2.Text));
            }
            if (sender.Equals(pizza_order3))
            {
                pizza_orders.Add(new Pizza_name(pizza_name3.Text));
            }
        }
    }

    public class Pizza_name
    {
        public string pizza_name;

        public Pizza_name(string pizza_name)
        {
            this.pizza_name = pizza_name;
        }
    }

    //public class Pizza
    //{
    //    Main_Menu MM; // is null......

    //    string name;
    //    string ingredients;
    //    string price;

    //    public Pizza(string name, string ingredients, string price)
    //    {
    //        this.name = name;
    //        this.ingredients = ingredients;
    //        this.price = price;

    //        StackPanel stacc = new StackPanel();

    //        TextBlock pizza_name = new TextBlock();
    //        pizza_name.TextWrapping = TextWrapping.Wrap;
    //        //pizza_name.Margin = new Thickness(0, 50, 0, 0);
    //        pizza_name.FontSize = 25;
    //        pizza_name.Text = name;

    //        stacc.Children.Add(pizza_name);

    //        TextBlock pizza_ingredients = new TextBlock();
    //        pizza_ingredients.TextWrapping = TextWrapping.Wrap;
    //        //pizza_ingredients.Margin = new Thickness(0, 80, 0, 0);
    //        pizza_ingredients.FontSize = 25;
    //        pizza_ingredients.Text = ingredients;

    //        stacc.Children.Add(pizza_ingredients);

    //        TextBlock pizza_price = new TextBlock();
    //        pizza_price.TextWrapping = TextWrapping.Wrap;
    //        //pizza_price.Margin = new Thickness(0, 100, 0, 0);
    //        pizza_price.FontSize = 25;
    //        pizza_price.Text = price;

    //        stacc.Children.Add(pizza_price);

    //        if (MM != null)
    //        {
    //            MM.main_menu_frame.Content = stacc;
    //        }
    //    }
    //}
}
