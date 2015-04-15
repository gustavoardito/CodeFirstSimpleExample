using System.Data.Entity;

namespace InheritanceEFExampleTpt
{
    public class InheritanceTptContext : DbContext
    {
        public DbSet<BillingDetail> BillingDetails { get; set; }
        public DbSet<User> Users { get; set; }

        //Change Discriminator Column Data Type and Values With Fluent API 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().ToTable("BankAccounts");
            modelBuilder.Entity<CreditCard>().ToTable("CreditCards");
        }
    }
}
