using System;
using eCommerce.DAL.Data;
using eCommerce.Model;

namespace eCommerce.DAL.Repositories
{
    class BasketRepository : RepositoryBase<Basket>
    {
        public BasketRepository(DataContext context) 
            : base(context)
        {
            if (context == null)
                throw new ArgumentException();
        }
    }
}
