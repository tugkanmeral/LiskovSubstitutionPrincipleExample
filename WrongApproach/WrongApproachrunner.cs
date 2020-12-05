using System;
using System.Collections.Generic;
using WrongApproach.Abstract;
using WrongApproach.Concrete;

namespace WrongApproach
{
    public static class WrongApproachRunner
    {
        public static void Run()
        {
            var phone = new Phone()
            {
                Name = "iPhone 11",
                Price = 599.0M
            };
            var computer = new Computer()
            {
                Name = "Dell XPS 13",
                Price = 1999M
            };
            var eBook = new Ebook()
            {
                Name = "Zülfü Livaneli Son Ada - eBook (EPUB)",
                Price = 9.99M
            };

            var products = new List<ProductBase>();
            products.Add(phone);
            products.Add(computer);
            products.Add(eBook);

            products.ForEach(p => p.CargoToCustomer());
        }
    }
}
