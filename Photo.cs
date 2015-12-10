using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Photo
    {
        //fields
        protected double price;

        //properties
        public double Width { get; set; }

        public double Height { get; set; }

        public double Price
        {
            get
            {
                GetPrice();
                return price;
            }
        }
        

        //overrides
        public virtual string ToString()
        {
            return String.Format("Class Name: {0}\nPhoto Dimensions: {1} x {2}\nPrice: {3}\n", this.GetType(), this.Width, this.Height, this.Price.ToString("c2"));
        }

        public virtual void GetPrice()
        {
            if (Width == 8 && Height == 10)
                price = 3.99;
            else if (Width == 10 && Height == 12)
                price = 5.99;
            else
                price = 9.99;
        }


    }
}
