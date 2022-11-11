using Microsoft.AspNetCore.Mvc;
using ASPNETCOREMVC.Models;

namespace ASPNETCOREMVC.Controllers
{
    public class CustomerController : Controller
    {
        private static List<Customer> customerVM = new List<Customer>();
        public IActionResult Index()
        {
            ViewData["Title"] = "Customer Details";

            //Customer customer = new Customer()
            //{
            //    Id = 1,
            //    CustomerName = "Micko De Josep",
            //    CustomerAge = 25
            //};
           

            return View(customerVM);
        }

        public IActionResult Create()
        {
            var CustomerVM = new Customer();
            return View(CustomerVM);
        }

        public IActionResult CreateCustomer(Customer customerViewModel)
        {
            customerVM.Add(customerViewModel);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }
        
    }
}
