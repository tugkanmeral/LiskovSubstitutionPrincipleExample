﻿using System;
using System.Collections.Generic;
using System.Text;
using WrongApproach.Abstract;

namespace WrongApproach.Concrete
{
    public class Computer : ProductBase
    {
        public override void CargoToCustomer()
        {
            Console.WriteLine($"{Name} was shipped to customer...");
        }
    }
}
