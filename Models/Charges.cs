using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class Charges
    {
        public PaymentSource_ payment_method { get; set; }

        public Charges () { }
        public Charges (PaymentSource_ payment_method)
        {
            this.payment_method = payment_method;
        }

    }
}