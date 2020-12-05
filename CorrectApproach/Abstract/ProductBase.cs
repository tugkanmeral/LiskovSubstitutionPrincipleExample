using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectApproach.Abstract
{
    public abstract class ProductBase : IDelivery
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void DeliverToCustomer();
    }
}
