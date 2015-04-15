using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new InheritanceMappingContext())
            {
                CreditCard cred = new CreditCard() {Number  = "12300001", Owner = "Yo"};

                ctx.BillingDetails.Add(cred);
                ctx.SaveChanges();

                var acc = new BankAccount() { Number = "123456780", Owner = "Otro" ,BankName = "Banco de la Alegria SA"};

                ctx.BillingDetails.Add(acc);
                ctx.SaveChanges();

                IQueryable<BankAccount> query = from b in ctx.BillingDetails.OfType<BankAccount>()
                                                select b;

                foreach (var bankAccount in query)
                {
                    Console.WriteLine("bankName: " + bankAccount.BankName + ", Owner: " + bankAccount.Number);
                }
            }

            Console.ReadKey();
        }
    }
}
