﻿using System;
using System.Collections.Generic;

namespace MyPharmacy.Entities
{
    public class OrderByClient
    {
        public int Id { get; set; }
        public int NumberOfOrder { get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime? DateOfReceipt { get; set; }
        public bool IsPersonalPickup { get; set; }
        public decimal Price { get; set; }

        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? PharmacyId { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
        public int? AddressId { get; set; }
        public virtual Address Address { get; set; } 
        public virtual List<Drug> Drugs { get; set; }
    }
}
