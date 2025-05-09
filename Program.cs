using Payments;
using Processor;
namespace PaymentSystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProcessor stripeProcessor = new StripProcessor();
            IProcessor payPalProcessor = new PayPalProcessor();
            IProcessor cryptoProcessor = new Cryptowallet();

            Payment oneTimePayment = new BasicPayment(stripeProcessor);
            oneTimePayment.pay(49.99);
            Payment monthlySubscription = new SubscriptionPayment(payPalProcessor);
            monthlySubscription.pay(9.99);

            Payment cryptoOneTime = new BasicPayment(cryptoProcessor);
            cryptoOneTime.pay(99.99);


        }
    }
}
