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
    public class CustomerController : Controller
    {
        private ICustomerRepository iCustomerRepository = new CustomerRepository();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(SignUpViewModel signupViewModel)
        {
            Customer obj = new Customer();
            obj.CustomerId = signupViewModel.CustomerId;
            obj.CustomerName = signupViewModel.CustomerName;
            obj.Email = signupViewModel.Email;
            obj.Password = signupViewModel.Password;
            obj.PhoneNumber = signupViewModel.PhoneNumber;
            obj.Website = signupViewModel.Website;
            obj.Company = signupViewModel.Company;
            obj.Address = signupViewModel.Address;
            iCustomerRepository.Create(obj);
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignInViewModel signinViewModel)
        {
            Customer db = iCustomerRepository.SignIn(signinViewModel.CustomerName, signinViewModel.Password);
            if (db == null)
            {
                ViewBag.Errormessage= "Invalid Customer Name and Password";
                return View("SignIn");

            }
            else
            {
                Session["Customer"] = db;
                return RedirectToAction("Index","Home");

            }
            
            return View("Login","Customer");
        }
	}
}