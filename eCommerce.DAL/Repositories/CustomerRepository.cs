using eCommerce.DAL.Data;
using eCommerce.DAL.Repositories;
using eCommerce.Model;
using System;

namespace eCommerce.DAL.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
