﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paveshop.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product> Products { get; set;}
        public IEnumerable<Category> Categories { get; set; }
    }
}
