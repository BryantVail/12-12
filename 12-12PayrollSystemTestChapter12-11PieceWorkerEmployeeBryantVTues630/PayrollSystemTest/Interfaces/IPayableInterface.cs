using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystemTest
{
    public abstract class IPayable
    {
       public abstract decimal GetPaymentAmount();
    }//end Interface IPayable
}
