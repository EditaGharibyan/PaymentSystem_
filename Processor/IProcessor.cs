﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    public interface IProcessor
    {
        public void ProcessPayment(string type,double m);

    }
}
