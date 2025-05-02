using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public class Cryptowallet:IProcessor
    {
        public void pay()
        {
            Console.WriteLine("It is CryptoWallet");
        }

    }
}
