using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItemOrder
    {
        public int? LineItemOrdersId { get; set; }
        public int? OrderId { get; set; }

        public virtual Order LineItemOrders { get; set; }
        public virtual LineItem Order { get; set; }
    }
}
