using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
 
        public ActionResult ViewCustomers()
        {
            var listCustomers = new List<Customer>()
            {
                new Customer(){ Name = "Laurent Van Beveren", Id = 0},
                new Customer(){ Name = "Mennens Louis", Id = 1}
            };

            var viewModel = new CustomersCustomerViewModel()
            {
                listCustomers = listCustomers
            };

            return View(viewModel);
        }

        [Route("Customers/ViewCustomers/{id}")]
        public ActionResult ViewDetail(int id)
        {
            var listCustomers = new List<Customer>()
            {
                new Customer(){ Name = "Laurent Van Beveren", Id = 0},
                new Customer(){ Name = "Mennens Louis", Id = 1}
            };

            return View(listCustomers[id]);
        }
    }
}