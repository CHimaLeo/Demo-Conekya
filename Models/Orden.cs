using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class Orden
    {
        public string currency { get; set; }
        public Cliente customer_info { get; set; }
        public List<LineItem_> line_items { get; set; }
        public List<Charges> charges { get; set; }

        public Orden () { }
        public Orden (string currency, Cliente customer_info, List<LineItem_> line_items, List<Charges> charges)
        {
            this.currency = currency;
            this.customer_info = customer_info;
            this.line_items = line_items;
            this.charges = charges;
        }
    }
}