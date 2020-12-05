using System;
using System.Collections.Generic;
using System.Text;

namespace WrongApproach.Abstract
{
    public abstract class ProductBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void CargoToCustomer();
        
    }
}
