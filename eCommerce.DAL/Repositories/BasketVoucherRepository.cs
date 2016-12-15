﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.DAL.Data;
using eCommerce.Model;

namespace eCommerce.DAL.Repositories
{
    class BasketVoucherRepository : RepositoryBase<Basket>
    {
        public BasketVoucherRepository(DataContext context) 
            : base(context)
        {
            if (context == null)
                throw new ArgumentException();
        }
    }
}
