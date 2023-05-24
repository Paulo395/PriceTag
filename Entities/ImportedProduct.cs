using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceTag.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + (Price + CustomsFee).ToString("F2") + " (Customs fee: $" + CustomsFee + ")";
        }
    }
}
