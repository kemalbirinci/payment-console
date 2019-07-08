using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nakit için N");
            Console.WriteLine("Kredi kartı için K");
            var paymentMethod = Console.ReadLine();
            IPayment payment = new PaymentFactory().GetPaymentMethod(paymentMethod);
            payment.DoPayment();
            Console.ReadLine();
        }
    }
}
