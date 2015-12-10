using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class PhotoDemo
    {
        static void Main(string[] args)
        {
            Photo photo1 = new Photo();
            FramedPhoto photo2 = new FramedPhoto();
            MattedPhoto photo3 = new MattedPhoto();

            photo1.Width = 12;
            photo1.Height = 12;

            photo2.Width = 8;
            photo2.Height = 10;
            photo2.FrameMaterial = "Silver";
            photo2.FrameStyle = "Modern";

            photo3.Width = 10;
            photo3.Height = 12;
            photo3.MatteColor = "Black";

            Console.WriteLine(photo1.ToString());
            Console.WriteLine(photo2.ToString());
            Console.WriteLine(photo3.ToString());
        }
    }
}
