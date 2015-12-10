using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab3
{
    class OrderDemo
    {
        static void Main(string[] args)
        {
            int orderNum = -999, amount = 0, a;
            string name = "";


            ShippedOrder[] orders = new ShippedOrder[5];
            int[] usedNums = new int[5];

            //loops until 5 orders have been filled
            for(int x = 0; x < orders.Length; ++x)
            {
                //loops until the user enters a order number that hasnt been used yet
                do
                {
                    //makes the current usedNums index = to the last orderNum
                    usedNums[x] = orderNum;

                    Write("Enter Order Number: ");
                    int.TryParse(ReadLine(), out orderNum);

                    a = Array.BinarySearch(usedNums, orderNum);

                    if (a >= 0)
                    {
                        WriteLine("Enter a new order number.");
                        WriteLine();
                        continue;
                    }
                    
                    Write("Enter Name: ");
                    name = ReadLine();

                    Write("Enter Quantity: ");
                    int.TryParse(ReadLine(), out amount);

                    if (a < 0)
                        WriteLine("Order #{0} Created.", x + 1);

                    WriteLine();
                } while (a >= 0);
                
                orders[x] = new ShippedOrder(orderNum, name, amount);
            }

            //sorts orders by order number
            Array.Sort(orders);

            //display each order
            foreach(ShippedOrder order in orders)
            {
                WriteLine("{0}", order.ToString());
            }
        }
    }
}
