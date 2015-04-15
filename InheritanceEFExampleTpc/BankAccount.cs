using System.ComponentModel.DataAnnotations.Schema;

namespace InheritanceEFExampleTpc
{
    [Table("BankAccounts")]
    public class BankAccount : BillingDetail
    {
        public string BankName { get; set; }
        public string Swift { get; set; }
    }

}
