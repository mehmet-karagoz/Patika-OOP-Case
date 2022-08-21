using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_case
{
    public abstract class Vehicle
    {
        public string? LicensePlate { get; set; }
        public string? OwnerFirstName { get; set; }
        public string? OwnerLastName { get; set; }
        public double Balance { get; set; }
        public int HGSNumber { get; set; }
        public abstract double DecreaseBalance();

        public override string? ToString() => "OwnerFirstName: " + OwnerFirstName + " " + OwnerLastName + ", Balance: " + Balance;
    }
}
