using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItem
    {
        internal int lineItemId;

        public int LineItemId { get; set; }
        public string Product { get; set; }
        public int? Quantity { get; set; }
        public object LineItem_Id { get; internal set; }
    }
}
