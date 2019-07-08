using System;

namespace Payment
{
    public class CreditCardPayment : IPayment
    {
        public void DoPayment()
        {
            Console.WriteLine("- Kredi Kartı ile Ödeme");
        }
    }
}
