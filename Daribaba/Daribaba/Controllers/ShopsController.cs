using Daribaba.Models;
using Daribaba.Repository;
using Daribaba.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daribaba.Controllers
{
    public class ShopsController : Controller
    {
        private IProductRepository iProductRepository = new ProductRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult ProductsDetails()
        {
            //Product product = iProductRepository.Find();
            //DetailViewModel DetailVM = new DetailViewModel();
            //DetailVM.Product = product;
            //DetailVM.RecomentedItem = iProductRepository.RecomentedItem(iProductRepository.Find(id), 5);
            return View();
        }
        public ActionResult CheckOut()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        //public ActionResult Buy(int id)
        //{
        //    if (Session["Cart"] == null)
        //    {
        //        List<ItemViewModel> lst = new List<ItemViewModel>();
        //        lst.Add(new ItemViewModel()
        //        {
        //            Product = iProductRepository.Find(id),
        //            Quantity = 1
        //        });
        //        Session["Cart"] = lst;
        //    }
        //    else
        //    {
        //        List<ItemViewModel> lst = (List<ItemViewModel>)Session["Cart"];
        //        lst.Add(new ItemViewModel()
        //        {
        //            Product = iProductRepository.Find(id),
        //            Quantity = 1
        //        });
        //        Session["Cart"] = lst;
        //    }
        //    return View("Cart");
        //}
	}
}