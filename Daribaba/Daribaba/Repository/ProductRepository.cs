using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Daribaba.Repository;

namespace Daribaba.Repository
{
    public class ProductRepository:IProductRepository
    {
        private DARIBABAEntities db = new DARIBABAEntities();
        public List<Models.Product> FeaturedItem(int n)
        {
            return db.Products.Where(p => p.Special == true).ToList();
        }

        public List<Product> RecomentedItem(int n)
        {
            return db.Products.Where(p => p.Special == true).OrderByDescending(p => p.ProductId).Take(n).ToList();
        }

        public Models.Product Find(int id)
        {
            return db.Products.Find(id);
        }
    }
}