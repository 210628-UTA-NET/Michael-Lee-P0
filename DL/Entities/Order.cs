using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Order
    {
        internal int p_order_Id;

        public int OrderId { get; set; }
        public string OrderLineItems { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual StoreFront Order1 { get; set; }
        public virtual Customer OrderNavigation { get; set; }
        public object Order_Id { get; internal set; }
    }
}
