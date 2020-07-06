using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Conekya.Models
{
    public class CoustomerInfo
    {
        public List<Cliente> customer_id { get; set; }

        public CoustomerInfo () { }

        public CoustomerInfo (List<Cliente> customer_id)
        {
            this.customer_id = customer_id;
        }
    }
}