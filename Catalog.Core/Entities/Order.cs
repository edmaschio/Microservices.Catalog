﻿using Catalog.Core.Entities.Base;
using System;

namespace Catalog.Core.Entities
{
    public record Order : Document
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public bool Delivered { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}