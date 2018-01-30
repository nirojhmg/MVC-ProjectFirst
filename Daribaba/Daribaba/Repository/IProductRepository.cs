using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daribaba.Repository
{
   public interface IProductRepository
    {
       List<Product> FeaturedItem(int n);
        List<Product> RecomentedItem(int n);
        Product Find(int id);
    }
}
