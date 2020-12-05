using CorrectApproach.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectApproach.Abstract
{
    public abstract class PhysicalProductBase : ProductBase, IPhysicalProduct
    {
        public decimal Weight { get; set; }

        public override void DeliverToCustomer()
        {
            DeliverViaCargo();
        }

        protected void DeliverViaCargo()
        {
            Console.WriteLine($"{this.Name} was sent by cargo...");
        }
    }
}
