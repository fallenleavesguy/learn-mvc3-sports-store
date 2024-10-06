using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SportsStore.Domain.Entities;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
