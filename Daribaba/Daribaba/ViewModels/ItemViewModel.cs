﻿using Daribaba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daribaba.ViewModels
{
    public class ItemViewModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}