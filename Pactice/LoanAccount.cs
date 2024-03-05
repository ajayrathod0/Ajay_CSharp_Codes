using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice
{
    internal class LoanAccount : Account
    {
        public LoanAccount(string fn, string ln, int an) : base(fn, ln, an)
        {
            AccountType = "Loan_Account";

        }
        public override void Print()
        {
            Console.WriteLine($"{FistName} {LastName} AccountNumber {AccountNumber}" +
                $"Account Type : {AccountType}");
        }

    }
}
