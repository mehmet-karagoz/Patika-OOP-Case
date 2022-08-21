using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case
{
    public class BoxOffice //gişe sınıfı
    {
        public Dictionary<DateTime, double> Balance = new();
        public Dictionary<DateTime,Vehicle> PassedVehicles = new();

        public void PassVehicle(Vehicle vehicle, DateTime passedTime)
        {
            PassedVehicles.Add(passedTime,vehicle);
            Balance.Add(passedTime,vehicle.DecreaseBalance());
        }
    }
}
