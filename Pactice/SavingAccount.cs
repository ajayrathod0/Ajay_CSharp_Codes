using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string fn, string ln, int an) : base(fn, ln, an)
        {
            AccountType = "Saving_Account";
        }
        public override void Print()
        {
            Console.WriteLine($"{FistName} {LastName} Account Number : {AccountNumber} " +
                 $"Account Type : {AccountType}");
        }

    }
}

