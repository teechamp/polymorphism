using System;
namespace Polymorphism
{
    public class TwoDaysPackage : Package
    {
      private decimal shippingCost;

        public TwoDaysPackage(string senderAddress, string recieverAddress, decimal shippingCost) : base(senderAddress, recieverAddress)
        {
            ShippingCost = shippingCost;
        }

        public decimal ShippingCost
        {
            get { return shippingCost; }

            private set
            {
                if (value > 0)
                {
                    shippingCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("shippingCost must", value, "must be greater than zero");
                }
            }
        }

        public override decimal CalculateCost()
        {
            return ShippingCost;
        }

        public override string ToString()
        {
            return $"Two days package\n{base.ToString()}\nShipping cost: {ShippingCost}";
        }
  
    }
}