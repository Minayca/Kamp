using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {            
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager autoLoanManager = new AutoLoanManager();          
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager tradesmanLoanManager = new TradesmanLoanManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(),new DatabaseLoggerService(),new FileLoggerService()};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(tradesmanLoanManager,loggers);

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager, autoLoanManager};

            //applicationManager.MakeCreditPreNotification(loans);

        }
    }
}
