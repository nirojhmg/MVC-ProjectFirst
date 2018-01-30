using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daribaba.ViewModels
{
    public class DetailViewModel
    {
        public Product Product { get; set; }
        public List<Product> ReleatedProducts { get; set; }
    }
}