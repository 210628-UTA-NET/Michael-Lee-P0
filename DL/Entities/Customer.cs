﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ListofOrder { get; set; }
        public string StoreName { get; internal set; }
        public string Inventory { get; internal set; }
    }
}
