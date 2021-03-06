﻿using System.ComponentModel.DataAnnotations.Schema;

namespace InheritanceEFExampleTpc
{
    [Table("CreditCards")]
    public class CreditCard : BillingDetail
    {
        public int CardType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }
}
