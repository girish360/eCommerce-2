using System;
using eCommerce.DAL.Data;
using eCommerce.Model;

namespace eCommerce.DAL.Repositories
{
    class VoucherTypeRepository : RepositoryBase<Voucher>
    {
        public VoucherTypeRepository(DataContext context)
            : base(context)
        {
            if (context == null)
                throw new ArgumentException();
        }
    }
}
