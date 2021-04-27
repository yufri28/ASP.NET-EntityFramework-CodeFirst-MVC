﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstDatabaseCodeFirstMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}