using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Processor;
namespace Payments
{
    public abstract class Payment
    {
        protected IProcessor proc;
        public Payment(IProcessor proc)
        {
            this.proc = proc;
        }
        public abstract void pay(double money);   
    }
}
