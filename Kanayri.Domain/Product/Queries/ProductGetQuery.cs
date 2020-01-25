﻿using System;
using Kanayri.Persistence.Models;

namespace Kanayri.Domain.Product.Queries
{
    public class ProductGetQuery : IQuery<ProductModel>
    {
        public Guid Id { get; set; }

        public ProductGetQuery(Guid id)
        {
            Id = id;
        }
    }
}
