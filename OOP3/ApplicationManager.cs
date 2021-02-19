using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method Injection. Hangi kredi hangi loglayıcı olduğu dair bilgim yok. Soyut halleri var
        //Somut halleri enjekte ediyorum.
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme.
            //
            creditManager.Compute();
            loggerService.Log();
            //Hangi krediyi seçersen seç onun hesaplası çalışır. Interfaceimiz 
            //o interface i implement eden classın referans numarasını tutabilir.
            
        }

        public void MakeAnCreditPreinformation(List<ICreditManager> credits) {

            foreach (var credit in credits)
            {
                credit.Compute();
            }
        }
    }
}
