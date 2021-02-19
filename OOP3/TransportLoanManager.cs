using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportLoanManager : ICreditManager
    {
        public void Compute()
        {
            Console.WriteLine("Transport Loan Computed.");
        }

        public void Print()
        {
            Console.WriteLine("Transport Loan Print");
        }
    }
}
