using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEFExample
{
    public class InheritanceTphContext : DbContext
    {
        public DbSet<BillingDetail> BillingDetails { get; set; }

        //Change Discriminator Column Data Type and Values With Fluent API 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BillingDetail>()
            //            .Map<BankAccount>(m => m.Requires("BillingDetailType").HasValue("BA"))
            //            .Map<CreditCard>(m => m.Requires("BillingDetailType").HasValue("CC"));

            modelBuilder.Entity<BillingDetail>()
            .Map<BankAccount>(m => m.Requires("BillingDetailType").HasValue(1))
            .Map<CreditCard>(m => m.Requires("BillingDetailType").HasValue(2));
        }
    }
}
