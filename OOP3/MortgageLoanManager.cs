using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Compute()
        {
            Console.WriteLine("Mortgage Loan Computed.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
