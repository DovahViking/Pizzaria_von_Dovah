using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_von_Dovah
{
    public class Pizza_Order
    {
        public string pizza_name { get; set; }
        public string pizza_price { get; set; }

        public Pizza_Order(string pizza_name, string pizza_price)
        {
            this.pizza_name = pizza_name;
            this.pizza_price = pizza_price;
        }
    }
}
