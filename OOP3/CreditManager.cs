using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar
    //için kullanırız. 

    //Loglama: kim ne zaman hangi operasyonu çağırdı. Operasyon dökümü.
    interface ICreditManager
    {
        void Compute();
        void Print();

      
    }
}
