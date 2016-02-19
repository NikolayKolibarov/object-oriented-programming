using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(10, 5, 10);
            Point3D secondPoint = new Point3D(20, 10, 30);

            double distance = DistanceCalculator.calcDistance(secondPoint, firstPoint);
            Console.WriteLine(distance);
        }
    }
}
