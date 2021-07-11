using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class StoreFrontLineItem
    {
        public int? LineItemStoreId { get; set; }
        public int? LineItemId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual StoreFront LineItemStore { get; set; }
    }
}
