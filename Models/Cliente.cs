using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class Cliente
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        /*public List<PaymentSource_> payment_sources { get; set; }*/

        public Cliente() { }

        public Cliente (string name, string email, string phone/*, List<PaymentSource_> payment_sources*/) {
            this.name = name;
            this.email = email;
            this.phone = phone;
            /*this.payment_sources = payment_sources;*/
        }
            
    }
}