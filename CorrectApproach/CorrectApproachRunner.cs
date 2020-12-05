using CorrectApproach.Abstract;
using CorrectApproach.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectApproach
{
    public static class CorrectApproachRunner
    {
        public static void Run()
        {
            var phone = new Phone()
            {
                Name = "iPhone 11",
                Price = 599.0M
            };
            var eBook = new EBook()
            {
                Name = "Zülfü Livaneli Son Ada - eBook (EPUB)",
                Price = 9.99M
            };

            var products = new List<ProductBase>();
            products.Add(phone);
            products.Add(eBook);

            products.ForEach(p => p.DeliverToCustomer());
        }
    }
}
