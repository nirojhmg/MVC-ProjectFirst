using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daribaba.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
        private DARIBABAEntities db = new DARIBABAEntities();
        public List<Models.Category> FindAll()
        {
            return db.Categories.ToList();
        }

        public Models.Category Find(int id)
        {
            return db.Categories.Find(id);
        }
    }
}