using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ShippedOrder : Order
    {
        private const double SHIPPING = 4.00;

        public ShippedOrder(int num, string name, int amount) : base(num, name, amount) { }

        public override double SetPrice()
        {
            if (QuantityOrdered > 0)
                price = QuantityOrdered * 19.95 + SHIPPING;
            else
                price = 0;

            return price;
        }
    }
}
