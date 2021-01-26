using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AutoLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
        
    }
}
