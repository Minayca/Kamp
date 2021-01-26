using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {       
        //Method injection
        public void MakeApplication(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlerndirme

            loanManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void MakeCreditPreNotification(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
