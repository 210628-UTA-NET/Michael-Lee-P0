using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class StoreFront
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string Inventory { get; set; }
        public string ListofOrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
