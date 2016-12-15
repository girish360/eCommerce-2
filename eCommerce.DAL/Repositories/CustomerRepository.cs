using eCommerce.DAL.Data;
using eCommerce.Model;
using System;

namespace eCommerce.DAL.Repositories
{
    public class CustomerRepository : RepositoryBase<Product>
    {
        public CustomerRepository(DataContext context) 
            : base(context){
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
