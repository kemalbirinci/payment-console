using System;

namespace Payment
{
    public class CashPayment : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("- Nakit Ödeme");
        }
    }
}
