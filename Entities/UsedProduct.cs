using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceTag.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufacturedDate { get; private set; }
        public UsedProduct()
        {
        }

        public UsedProduct(string name,double price,DateOnly manufacturedDate) : base(name,price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $" + Price.ToString("F2") + " (Manufactured date: " + ManufacturedDate + ")";
        }
    }
}
