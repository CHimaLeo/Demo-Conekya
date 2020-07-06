using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class LineItem_
    {
        public string name { get; set; }
        public int unit_price { get; set; }
        public int quantity { get; set; }

        public LineItem_ () { }

        public LineItem_ (string name, int unit_price, int quantity)
        {
            this.name = name;
            this.unit_price = unit_price;
            this.quantity = quantity;
        }
    }
}