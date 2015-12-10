using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class FramedPhoto : Photo
    {

        //properties
        public string FrameMaterial { get; set; }
        public string FrameStyle { get; set; }

        //overrides
        public override void GetPrice()
        {
            if (Width == 8 && Height == 10)
                price = 3.99;
            else if (Width == 10 && Height == 12)
                price = 5.99;
            else
                price = 9.99;

            price += 25;
        }

        public override string ToString()
        {
            return String.Format("Class Name: {0}\nPhoto Dimensions: {1} x {2}\nFrame Material: {3}\nFrame Style: {4}\nPrice: {5}\n", this.GetType(), this.Width, this.Height, this.FrameMaterial, this.FrameStyle, this.Price.ToString("c2"));
        }
    }
}
