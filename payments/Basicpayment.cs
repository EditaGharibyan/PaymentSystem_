using Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class BasicPayment:Payment
    {
        public BasicPayment(IProcessor proc):base(proc)
        {
        }
        public override void payed()
        {
            proc.pay();
        }
    }
}
