using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processor;
namespace Payments
{
    public class SubscriptionPayment:Payment
    {
        public SubscriptionPayment(IProcessor p) : base(p) { }
        public override void pay(double money)
        {
            proc.ProcessPayment("Subscription", money);
        }
    }
}
