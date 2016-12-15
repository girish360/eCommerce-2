using System;
using System.Collections;
using System.Collections.Generic;

namespace eCommerce.Model
{
    public class Basket
    {
        public Guid BasketId { get; set; }
        public DateTime Date { get; set; }  

        public virtual ICollection<BasketItem>BasketItems { get; set; }
    }
}
