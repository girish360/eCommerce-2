using eCommerce.DAL.Data;
using eCommerce.DAL.Repositories;
using System.Web.Mvc;
using eCommerce.Contracts.Repositories;
using eCommerce.Model;

namespace eCommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Customer>customers;
        IRepositoryBase<Product> products;

        public HomeController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products)
        {
            this.customers = customers;
            this.products = products;

        }

        public ActionResult Index()
        {
            var productList = products.GetAll();
         
            return View(productList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}