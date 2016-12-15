using eCommerce.DAL.Data;
using eCommerce.Model;
using System;

namespace eCommerce.DAL.Repositories
{
    public class ProductRepository : RepositoryBase<Customer>
    {
        public ProductRepository(DataContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}


        