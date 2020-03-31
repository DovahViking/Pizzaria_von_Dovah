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
using System.Windows.Shapes;

namespace Pizzaria_von_Dovah
{
    /// <summary>
    /// Interaction logic for Main_Menu.xaml
    /// </summary>
    public partial class Main_Menu : Window
    {
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

        }
    }
}
