using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pactice
{
    internal class Account
    {
        public string AccountType;
        public int AccountNumber;
        public string FistName;
        public string LastName;

        public Account(string fn, string ln, int an)
        {
            AccountType = fn;
            AccountNumber = an;
            FistName = fn;
            LastName = ln;
        }
        public virtual void Print()
        {

            Console.WriteLine($"{FistName} {LastName} Account Number : {AccountNumber}");
        }
    }
}
