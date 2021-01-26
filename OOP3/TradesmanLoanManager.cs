using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
