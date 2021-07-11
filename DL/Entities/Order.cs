using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string OrderLineItems { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual StoreFront Order1 { get; set; }
        public virtual Customer OrderNavigation { get; set; }
    }
}
