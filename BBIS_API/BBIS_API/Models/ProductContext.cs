﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BBIS_API.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base() { }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<ProductItem> ProductItems { get; set; }
    }
}
