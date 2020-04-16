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
    /// Interaction logic for Do_it_yourself.xaml
    /// </summary>
    public partial class Do_it_yourself : Page
    {
        bool diy_medium_size_checku = true;
        bool diy_family_size_checku = false;
        int diy_medium_size_price = 1;
        double diy_family_size_price = 1.5;

        bool diy_Italian_Tipo_00_checku = false;
        int diy_Italian_Tipo_00_price = 5;
        bool diy_tomato_sauce_checku = false;
        int diy_tomato_sauce_price = 1;
        bool diy_sweet_sour_sauce_checku = false;
        int diy_sweet_sour_sauce_price = 3;
        bool diy_normie_pizza_dough_checku = false;
        int diy_normie_pizza_dough_price = 2;
        double total_price;
        enum toppings {Ham, Fries, Champingon, Pepperoni, Chicken, Kebab, Spaghetti, Cocktail_Sausage, Extra_Cheese}
        toppings diy_toppings;
        int diy_toppings_ham_price = 1;
        double diy_toppings_fries_price = 1.3;
        int diy_toppings_champingon_price = 1;
        double diy_toppings_pepperoni_price = 0.5;
        int diy_toppings_chicken_price = 2;
        int diy_toppings_kebab_price = 2;
        int diy_toppings_spaghetti_price = 2;
        int diy_toppings_cocktail_sausage_price = 2;
        double diy_toppings_extra_cheese_price = 1.5;

        // WARNING: Highly inefficient way of doing this but it was the simplest way of doing it
        // example for a better solution: this.diy_pizza.dough = Italian_Tipo_00;

        public Do_it_yourself()
        {
            var diy_order = new List<string>();
            InitializeComponent();
        }

        public void enum_toppings()
        {
            //toppings.Champingon = diy_topping_combobox1 // WANT COMBOBOXES TO GET THEIR DATASOURCE FROM THE SAME SOURCE
        }

        // ---------- Size ----------

        private void diy_medium_pizza_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void diy_family_pizza_button_Click(object sender, RoutedEventArgs e)
        {

        }

        // ---------- Dough ----------

        private void diy_Italian_Tipo_00_rad_button_Checked(object sender, RoutedEventArgs e)
        {
            if (diy_normie_pizza_dough_checku)
            {
                diy_normie_pizza_dough_checku = false;
                total_price -= diy_normie_pizza_dough_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
            if (diy_Italian_Tipo_00_checku == false)
            {
                diy_Italian_Tipo_00_checku = true;
                total_price += diy_Italian_Tipo_00_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
        }

        private void diy_normie_pizza_dough_button_Checked(object sender, RoutedEventArgs e)
        {
            if (diy_Italian_Tipo_00_checku)
            {
                diy_Italian_Tipo_00_checku = false;
                total_price -= diy_Italian_Tipo_00_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
            if (diy_normie_pizza_dough_checku == false)
            {
                diy_normie_pizza_dough_checku = true;
                total_price += diy_normie_pizza_dough_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
        }

        // ---------- Sauce ----------

        private void diy_tomato_sauce_rad_button_Checked(object sender, RoutedEventArgs e)
        {
            if (diy_sweet_sour_sauce_checku)
            {
                diy_sweet_sour_sauce_checku = false;
                total_price -= diy_sweet_sour_sauce_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
            if (diy_tomato_sauce_checku == false)
            {
                diy_tomato_sauce_checku = true;
                total_price += diy_tomato_sauce_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
        }

        private void diy_sweet_sour_sauce_button_Checked(object sender, RoutedEventArgs e)
        {
            if (diy_tomato_sauce_checku)
            {
                diy_tomato_sauce_checku = false;
                total_price -= diy_tomato_sauce_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
            if (diy_sweet_sour_sauce_checku == false)
            {
                diy_sweet_sour_sauce_checku = true;
                total_price += diy_sweet_sour_sauce_price;
                diy_total_price.Text = Convert.ToString(total_price);
            }
        }

        // ---------- Topping ----------

        private void diy_topping_combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (diy_toppings)
            {
                case toppings.Champingon:
                    total_price += diy_toppings_champingon_price;
                    diy_total_price.Text = Convert.ToString(total_price);
                    break;
            }
        }

        private void diy_topping_combobox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void diy_topping_combobox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void diy_topping_combobox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // ---------- Cheese ----------

        private void diy_cheese_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // ---------- Spice ----------

        private void diy_spice_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // ---------- Reset ----------

        private void diy_reset_button_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.main_menu_frame.Content = null;

            // not working
        }

        // ---------- Next ----------

        private void diy_next_button_Click(object sender, RoutedEventArgs e)
        {
            // add everything to the list?
        }
    }
}
