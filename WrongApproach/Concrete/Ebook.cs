using System;
using System.Collections.Generic;
using System.Text;
using WrongApproach.Abstract;

namespace WrongApproach.Concrete
{
    public class Ebook : ProductBase
    {
        public override void CargoToCustomer()
        {
            throw new NotSupportedException("e-Book cannot be shipped by cargo!");
        }
    }
}
