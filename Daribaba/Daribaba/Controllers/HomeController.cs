using Daribaba.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daribaba.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository iProductRepository = new ProductRepository();
        public ActionResult Index()
        {
            ViewBag.FeaturedItem = iProductRepository.FeaturedItem(5);
            ViewBag.RecomentedItem = iProductRepository.RecomentedItem(3);
            return View();
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