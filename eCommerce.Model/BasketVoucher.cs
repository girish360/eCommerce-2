using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Model
{
    public class BasketVoucher
    {
        public int BasketVoucherId { get; set; }
        public int VoucherId { get; set; }
        public Guid BasketIId { get; set; }

        [MaxLength(10)]
        public string VoucherCode { get; set; }
        [MaxLength(100)]
        public string VoucherType { get; set; }
        public decimal Value { get; set; }
        [MaxLength(150)]
        public string VoucherDescription { get; set; }
        public int ApplicationToProductId { get; set; }
    }
}
