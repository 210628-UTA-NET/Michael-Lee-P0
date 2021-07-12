using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ListofOrderId { get; set; }

        public virtual Order Order { get; set; }
        public object Customer_Id { get; internal set; }
    }
}
