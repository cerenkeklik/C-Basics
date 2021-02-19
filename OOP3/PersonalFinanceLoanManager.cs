using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceLoanManager : ICreditManager
    {
        public void Compute()
        {
            Console.WriteLine("Personal Finance Loan Computed.");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
