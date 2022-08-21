using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case
{
    public class Bus : Vehicle
    {
        public override double DecreaseBalance()
        {
            Balance -= 200;
            return 200;
        }
    }
}
