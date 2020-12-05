using CorrectApproach.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectApproach.Abstract
{
    public abstract class DigitalProductBase : ProductBase, IDigitalProduct
    {
        public decimal FileSize { get; set; }

        public override void DeliverToCustomer()
        {
            DeliverViaEmail();
        }

        protected void DeliverViaEmail()
        {
            Console.WriteLine($"{this.Name} was sent by e-mail...");
        }
    }
}
