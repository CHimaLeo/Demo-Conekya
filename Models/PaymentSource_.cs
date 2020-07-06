using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class PaymentSource_
    {
        public string token_id { get; set; }
        public string type { get; set; }

        public PaymentSource_ () { }

        public PaymentSource_ (string token_id, string type)
        {
            this.token_id = token_id;
            this.type = type;
        }

    }
}