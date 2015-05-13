using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            double aX = double.Parse(Console.ReadLine());
            double aY = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());

            double distanceAB = 
                Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));

            double distanceBC =
                Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));

            double distanceAC =
                Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));


            if ((distanceAB + distanceBC) > distanceAC && 
                (distanceBC + distanceAC) > distanceAB && 
                (distanceAB + distanceAC) > distanceBC)
            {
                Console.WriteLine("Yes");

                double halfPerim =
                    (distanceAB + distanceBC + distanceAC) / 2;

                double perimeter =
                    Math.Sqrt(halfPerim * (halfPerim - distanceAB) * (halfPerim - distanceBC) * (halfPerim - distanceAC));

                Console.WriteLine("{0:F2}", perimeter);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", distanceAB);
            }
        }
    }
}
