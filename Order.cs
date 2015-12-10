using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Order : IComparable
    {
        //fields
        protected double price;

        //properties
        public int OrderNum { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrdered { get; set; }
        public double Price
        {
            get
            {
                return price;
            }
        }

        //constructor
        public Order(int orderNum, string name, int amount)
        {
            OrderNum = orderNum;
            CustomerName = name;
            QuantityOrdered = amount;
            price = SetPrice();
        }

        public virtual double SetPrice()
        {
            if (QuantityOrdered > 0)
                price = QuantityOrdered * 19.95;
            else
                price = 0;

            return price;
        }

        //overrides
        //compares each order by item number
        int IComparable.CompareTo(object obj)
        {
            int returnVal;

            Order temp = (Order)obj;

            if (this.OrderNum > temp.OrderNum)
                returnVal = 1;
            else
                if (this.OrderNum < temp.OrderNum)
                    returnVal = -1;
                else
                    returnVal = 0;

            return returnVal;
        }

        public override bool Equals(object o)
        {
            bool isEqual;

            if (this.GetType() != o.GetType())
                isEqual = false;
            else
            {
                Order temp = (Order)o;

                if (this.OrderNum == temp.OrderNum)
                    isEqual = true;
                else
                    isEqual = false;
            }

            return isEqual;
        }

        public override int GetHashCode()
        {
            return this.OrderNum;
        }

        public override string ToString()
        {
            return String.Format("Order #: {0}\nCustomer Name: {1}\nQuantity: {2}\nPrice: {3}\n", this.OrderNum, this.CustomerName, this.QuantityOrdered, this.Price.ToString("c2"));
        }
    }
}
