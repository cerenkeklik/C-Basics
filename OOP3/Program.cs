using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //SOLID 
        //O- Open Closed Principle
        //Sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
        static void Main(string[] args)
        {
            //Interfaceler de o interfacei implemente eden class ın referans numarasını tutabilir.
            ICreditManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ICreditManager transportLoanManager = new TransportLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ApplicationManager appManager = new ApplicationManager();
            appManager.MakeAnApplication(personalFinanceLoanManager, new DatabaseLoggerService());
            appManager.MakeAnApplication(mortgageLoanManager, new FileLoggerService());


            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceLoanManager, transportLoanManager};

            //.MakeAnCreditPreinformation(credits);


        }
    }
}
