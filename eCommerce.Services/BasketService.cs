using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using eCommerce.Contracts.Repositories;
using eCommerce.Model;

namespace eCommerce.Services
{
    class BasketService
    {
        IRepositoryBase<Basket> baskets;
        private IRepositoryBase<Voucher> vouchers;
        private IRepositoryBase<VoucherType> voucherTypes;
        private IRepositoryBase<BasketVoucher> basketVouchers;

        public const string BasketSessionName = "eCommerce";

        public BasketService(IRepositoryBase<Basket> baskets, IRepositoryBase<Voucher> vouchers, IRepositoryBase<BasketVoucher> basketVouchers, IRepositoryBase<VoucherType> voucherTypes)
        {
            this.baskets = baskets;
            this.vouchers = vouchers;
            this.basketVouchers = basketVouchers;
            this.voucherTypes = voucherTypes;
        }

        private Basket createNewBasket(HttpContextBase httpContext)
        {
            // Create a new basket.

            //first create a new cookie.
            HttpCookie Cookie = new HttpCookie(BasketSessionName);
            //now create a new basket and set the creation date.
            Basket basket = new Basket();
            basket.Date = DateTime.Now;
            basket.BasketId = Guid.NewGuid();

            //add and persist in the dabase
            baskets.Insert(basket);
            baskets.Commit();

            //add the basket id to a cookie
            Cookie.Value = basket.BasketId.ToString();
            Cookie.Expires = DateTime.Now.AddDays(1);
            httpContext.Response.Cookies.Add(Cookie);

            return basket;
        }

        public bool AddToBasket(HttpContextBase httpContext, int productId, int quantity)
        {
            bool success = true;

            Basket basket = GetBasket(httpContext);
            BasketItem item = basket.BasketItems.FirstOrDefault(i => i.ProductId == productId);

            if (item == null)
            {
                item =new BasketItem();
                {
                    BasketId = basket.BasketId,
                    ProductId = productId,
                    Quantity = quantity
                }
                else
                {
                    item.Quantity = item.Quantity + quantity;
                }
                baskets.Commit();
                return success;
            }          
        }

        public Basket GetBasket(HttpContextBase httpContext)
        {
            HttpCookie cookie = httpContext.Request.Cookies.Get(BasketSessionName);
            Basket basket;

            Guid basketId;
            if (cookie != null)
            {
                if (Guid.TryParse(cookie.Value, out basketId))
                {
                    basket = baskets.GetById(basketId);
                }
                else
                {
                    basket = createNewBasket(httpContext);
                }
            }
            else
            {
                basket = createNewBasket(httpContext);
            }

            return basket;
        }

        public void AddVoucher(string voucherCode, HttpContextBase httpContext)
        {
            Basket basket = GetBasket(httpContext);
            Voucher voucher = vouchers.GetAll().FirstOrDefault(v => v.VoucherCode == voucherCode);

            if (voucher != null)
            {
                VoucherType voucherType = voucherTypes.GetById(voucher.VoucherTypeId);
                if (voucherType !=null)
                {
                    
                }
            }
        }
    }
}
