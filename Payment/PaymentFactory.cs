using System;

namespace Payment
{
    public class PaymentFactory
    {
        public IPayment GetPaymentMethod(string method)
        {
            switch (method.ToLower())
            {
                case "n":
                    return new CashPayment();
                case "k":
                    return new CreditCardPayment();
                default:
                    throw new NotImplementedException("Geçersiz ödeme yöntemi");
            }
        }
    }
}
