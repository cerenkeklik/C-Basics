using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CoorporateCustomer:Customer //Tüzel müşteri
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
