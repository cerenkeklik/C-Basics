using System;

namespace OOP2
{
    class Program
    {
        //Eğer base classın varsa, o base class referans tutucudur.
        static void Main(string[] args)
        {
            //SOLID 
            //L- Liskov substitution principle
            // Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları,
            //türedikleri(üst) sınıfların yerine kullanabilmeliyiz.

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Ceren";
            customer1.Surname = "Keklik";
            customer1.IdentificationNumber = "12334434242";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "636232";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "12312412214";



            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);


        }
    }
}
