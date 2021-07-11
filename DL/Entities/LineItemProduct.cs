using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class LineItemProduct
    {
        public int? LineItemProductId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product LineItemProductNavigation { get; set; }
        public virtual LineItem Product { get; set; }
    }
}
