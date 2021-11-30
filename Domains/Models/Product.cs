﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Domains.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
