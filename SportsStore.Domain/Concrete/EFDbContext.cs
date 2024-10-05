using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SportsStore.Domain.Entities;
using System.Data.SqlClient;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext: DbContext
    {
        public EFDbContext() {}
        public DbSet<Product> Products { get; set; }
    }
}
