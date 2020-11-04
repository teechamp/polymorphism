using System;
namespace Polymorphism
{
    public class OvernightPackage : Package
    {
        private decimal shippingCost;

        public OvernightPackage(string senderAddress, string recieverAddress, decimal shippingCost) : base(senderAddress, recieverAddress)
        {
            ShippingCost = shippingCost;
        }

        public decimal ShippingCost
        {
            get {return shippingCost;}
            private set {
                if (value > 0)
                {
                    shippingCost = value;
                } else {
                     throw new ArgumentOutOfRangeException("shippingCost must", value, "must be greater than zero");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return shippingCost;
        }

        public override  string ToString()
        {
            return $"Overnight Package\n{base.ToString()}\nShipping cost: {ShippingCost}\n";
        }
    }
}