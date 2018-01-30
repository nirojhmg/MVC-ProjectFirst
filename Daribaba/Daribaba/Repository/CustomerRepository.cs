using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daribaba.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private DARIBABAEntities db = new DARIBABAEntities();
        public void Create(Models.Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges(); 
        }


        public Customer SignIn(string customerName, string password)
        {
            try
            {
                return db.Customers.Single(c => c.CustomerName.Equals(customerName) && c.Password.Equals(password));
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}