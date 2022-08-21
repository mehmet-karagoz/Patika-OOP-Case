using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case
{
    public class Car : Vehicle
    {
        public override double DecreaseBalance()
        {
            Balance -= 100;
            return 100;
        }
    }
}
