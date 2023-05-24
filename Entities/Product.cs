﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTag.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
}
