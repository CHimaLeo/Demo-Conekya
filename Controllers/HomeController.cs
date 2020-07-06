using System;
using System.Collections.Generic;
using System.Web.Mvc;
using conekta;
using Demo_Conekya.Models;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Demo_Conekya.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //conekta.Customer customer = new conekta.Customer().create("");
            var token_id = Request.Form["conektaTokenId"];
            if (!String.IsNullOrEmpty(token_id))
            {
                return Create(token_id);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Form()
        {
           
            return View();
        }

        public ActionResult Create(string token)
        {
            conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
            conekta.Api.version = "2.0.0";

            var resultCharge = creaCaptura(token);

            ViewData["Result"] = resultCharge;
            return View();
        }

        /*public Cliente CreaCliente(string token)
        {
            Customer customer = null;
            List<PaymentSource_> list = new List<PaymentSource_>();
            PaymentSource_ paymentSource = new PaymentSource_(token, "card");
            list.Add(paymentSource);
            Cliente cliente = new Cliente("Mario Perez", "usuario@example.com", "+5215555555555", list);
            string jsonCustomer = JsonSerializer.Serialize(cliente);
            try
            {
            customer = new conekta.Customer().create(jsonCustomer);
            }
            catch (ConektaException e) {
                foreach (JObject obj in e.details)
                {
                    System.Console.WriteLine("\n [ERROR]:\n");
                    System.Console.WriteLine("message:\t" + obj.GetValue("message"));
                    System.Console.WriteLine("debug:\t" + obj.GetValue("debug_message"));
                    System.Console.WriteLine("code:\t" + obj.GetValue("code"));
                }
            }
            return customer;
        }*/

        public Order creaOrden(string token)
        {
            Order order = null;
            List<LineItem_> list = new List<LineItem_>();
            List<Charges> listas = new List<Charges>();
            Cliente cliente = new Cliente("Mario Perez", "usuario@example.com", "+5215555555555");
            PaymentSource_ paymentSource = new PaymentSource_(token, "card");
            LineItem_ lineItem = new LineItem_("Pago Perido Enero 2020 - Julio 2020",1000,1);
            list.Add(lineItem);
            Charges charges = new Charges(paymentSource);
            listas.Add(charges);
            Orden orden = new Orden("MXN", cliente, list, listas);
            string jsonOrden = JsonSerializer.Serialize(orden);
            try {
                order = new conekta.Order().create(jsonOrden);

            } catch (ConektaException e) {
                foreach (JObject obj in e.details)
                {
                    System.Console.WriteLine("\n [ERROR]:\n");
                    System.Console.WriteLine("message:\t" + obj.GetValue("message"));
                    System.Console.WriteLine("debug:\t" + obj.GetValue("debug_message"));
                    System.Console.WriteLine("code:\t" + obj.GetValue("code"));
                }
            }
            return order;
        }

        public Order creaCaptura(string token)
        {
            Order orden = creaOrden(token);
            Order order = new conekta.Order().find(orden.id);
            order.capture();
            return order;
        }


    }
}
