using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        // GET: Customers
 
        public ViewResult ViewCustomers()
        {
            var customers = _context.Customers.Include(c => c.MembershipTypes).ToList();

            return View(customers);
        }

        [Route("Customers/ViewCustomers/{id}")]
        public ActionResult ViewDetail(int id)
        {
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customers == null)
            {
                return HttpNotFound();
            }

            return View(customers);
        }
    }
}