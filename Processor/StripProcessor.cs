using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class StripProcessor:IProcessor
    {
        public void ProcessPayment(string t,double m)
        {
            Console.WriteLine($"{t} Strip payment money {m}");
        }
        

    }
}
