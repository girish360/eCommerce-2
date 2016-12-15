﻿using System.ComponentModel.DataAnnotations;
using eCommerce.Contracts.Repositories;

namespace eCommerce.Model
{
    public class Voucher : IVoucher
    {
        public int VoucherId { get; set; }
        
        [MaxLength(10)]
        public string VoucherCode { get; set; }

        public int VoucherTypeId { get; set; }

        [MaxLength(150)]
        public string VoucherDescription { get; set; }

        public int AppliesToProductId { get; set; } // this is so we can apply it to specific product

        public decimal Value { get; set; }

        public decimal MinSpend { get; set; }

        public bool multipleUse { get; set; }

        [MaxLength(255)]
        public string AssignedTo { get; set; }
              
    }
}
