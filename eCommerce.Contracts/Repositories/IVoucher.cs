namespace eCommerce.Contracts.Repositories
{
    public interface IVoucher
    {
        int VoucherId { get; set; }
        string VoucherCode { get; set; }
        int VoucherTypeId { get; set; }
        string VoucherDescription { get; set; }
        int AppliesToProductId { get; set; }
        decimal Value { get; set; }
        decimal MinSpend { get; set; }
        bool multipleUse { get; set; }
        string AssignedTo { get; set; }
    }
}