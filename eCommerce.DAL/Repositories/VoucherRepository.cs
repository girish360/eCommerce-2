using System;
using eCommerce.DAL.Data;
using eCommerce.Model;

namespace eCommerce.DAL.Repositories
{
    class VoucherRepository: RepositoryBase<Voucher>
    {
        public VoucherRepository(DataContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentException();
            
        }
    }
}
