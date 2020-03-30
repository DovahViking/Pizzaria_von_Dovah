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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            Pizza pizza1 = new Pizza("pizzaaaaaaaa", "qqqq", "32");
            InitializeComponent();
        }
    }

    public class Pizza
    {
        Main_Menu MM; // is null......

        string name;
        string ingredients;
        string price;

        public Pizza(string name, string ingredients, string price)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.price = price;

            StackPanel stacc = new StackPanel();

            TextBlock pizza_name = new TextBlock();
            pizza_name.TextWrapping = TextWrapping.Wrap;
            //pizza_name.Margin = new Thickness(0, 50, 0, 0);
            pizza_name.FontSize = 25;
            pizza_name.Text = name;

            stacc.Children.Add(pizza_name);

            TextBlock pizza_ingredients = new TextBlock();
            pizza_ingredients.TextWrapping = TextWrapping.Wrap;
            //pizza_ingredients.Margin = new Thickness(0, 80, 0, 0);
            pizza_ingredients.FontSize = 25;
            pizza_ingredients.Text = ingredients;

            stacc.Children.Add(pizza_ingredients);

            TextBlock pizza_price = new TextBlock();
            pizza_price.TextWrapping = TextWrapping.Wrap;
            //pizza_price.Margin = new Thickness(0, 100, 0, 0);
            pizza_price.FontSize = 25;
            pizza_price.Text = price;

            stacc.Children.Add(pizza_price);

            if (MM != null)
            {
                MM.main_menu_frame.Content = stacc;
            }

        }
    }
}
