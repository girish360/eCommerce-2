using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Data
{
    public class DataContext : DbContext
    {
        

        /// you can either pass the NAME of connection string (e.g. from a web.config, and explicitly declare in there
        public DataContext()
            : base("DefaultConnection")
        {
        }

        /// any entity to be persisted must be declared here
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderitem> Orderitems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
