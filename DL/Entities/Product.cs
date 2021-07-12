using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string Description { get; set; }
        public int Product_Id { get; internal set; }
        public string Product_Name { get; internal set; }
    }
}
