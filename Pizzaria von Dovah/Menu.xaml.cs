using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Runtime.CompilerServices;

namespace Pizzaria_von_Dovah
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        ObservableCollection<Pizza_Order> pizza_orders;

        double pizza1_price = 7.00;
        double pizza2_price = 13.00;
        double pizza3_price = 15.00;
        double pizza_family_size_price = 1.5;

        double drink_s_price = 2.00;
        double drink_m_price = 3.30;
        double drink_l_price = 4.00;

        bool pizza_family = false;

        bool smol_drink = false;
        bool medium_drink = false;
        bool large_drink = false;

        public Menu(ObservableCollection<Pizza_Order> pizza_orders)
        {
            //Pizza pizza1 = new Pizza("pizzaaaaaaaa", "qqqq", "32");
            this.pizza_orders = pizza_orders;
            InitializeComponent();
        }

        private void menu_medium_pizza_button_Click(object sender, RoutedEventArgs e)
        {
            pizza_family = false;
            pizza_price1.Text = Convert.ToString(pizza1_price);
            pizza_price2.Text = Convert.ToString(pizza2_price);
            pizza_price3.Text = Convert.ToString(pizza3_price);
        }

        private void menu_family_pizza_button_Click(object sender, RoutedEventArgs e)
        {
            pizza_family = true;
            pizza_price1.Text = Convert.ToString(pizza1_price * pizza_family_size_price);
            pizza_price2.Text = Convert.ToString(pizza2_price * pizza_family_size_price);
            pizza_price3.Text = Convert.ToString(pizza3_price * pizza_family_size_price);
        }

        private void add_to_cart_button_Click(object sender, RoutedEventArgs e) // Bad shit kode, will get fixed in future update probably
        {
            if (sender.Equals(pizza_order1)) // tried with switch/case but got type exception
            {
                if (pizza_family)
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name1.Text, pizza_price1.Text, "Family"));
                }
                else
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name1.Text, pizza_price1.Text, "Medium"));
                }
            }
            if (sender.Equals(pizza_order2))
            {
                if (pizza_family)
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name2.Text, pizza_price2.Text, "Family"));
                }
                else
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name2.Text, pizza_price2.Text, "Medium"));
                }
            }
            if (sender.Equals(pizza_order3))
            {
                if (pizza_family)
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name3.Text, pizza_price3.Text, "Family"));
                }
                else
                {
                    pizza_orders.Add(new Pizza_Order(pizza_name3.Text, pizza_price3.Text, "Medium"));
                }
            }
            if (sender.Equals(drink_order1))
            {
                if (smol_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name1.Text, drink_price1.Text, "Small"));
                }
                if (medium_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name1.Text, drink_price1.Text, "Medium"));
                }
                if (large_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name1.Text, drink_price1.Text, "Large"));
                }
                else
                {

                }
            }
            if (sender.Equals(drink_order2))
            {
                if (smol_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name2.Text, drink_price2.Text, "Small"));
                }
                if (medium_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name2.Text, drink_price2.Text, "Medium"));
                }
                if (large_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name2.Text, drink_price2.Text, "Large"));
                }
                else
                {

                }
            }
            if (sender.Equals(drink_order3))
            {
                if (smol_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name3.Text, drink_price3.Text, "Small"));
                }
                if (medium_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name3.Text, drink_price3.Text, "Medium"));
                }
                if (large_drink)
                {
                    pizza_orders.Add(new Pizza_Order(drink_name3.Text, drink_price3.Text, "Large"));
                }
                else
                {

                }
            }
        }

        private void drink_size_s_Checked(object sender, RoutedEventArgs e)
        {
            smol_drink = true;
            medium_drink = false;
            large_drink = false;

            drink_price1.Text = Convert.ToString(drink_s_price);
            drink_price2.Text = Convert.ToString(drink_s_price);
            drink_price3.Text = Convert.ToString(drink_s_price);
        }

        private void drink_size_m_Checked(object sender, RoutedEventArgs e)
        {
            smol_drink = false;
            medium_drink = true;
            large_drink = false;

            drink_price1.Text = Convert.ToString(drink_m_price);
            drink_price2.Text = Convert.ToString(drink_m_price);
            drink_price3.Text = Convert.ToString(drink_m_price);
        }

        private void drink_size_l_Checked(object sender, RoutedEventArgs e)
        {
            smol_drink = false;
            medium_drink = false;
            large_drink = true;

            drink_price1.Text = Convert.ToString(drink_l_price);
            drink_price2.Text = Convert.ToString(drink_l_price);
            drink_price3.Text = Convert.ToString(drink_l_price);
        }
    }

    //public class Pizza
    //{
    //    Main_Menu MM = new Main_Menu();

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
