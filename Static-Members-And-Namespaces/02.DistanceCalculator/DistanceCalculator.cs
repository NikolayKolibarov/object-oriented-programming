using System;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    public static class DistanceCalculator
    {

        public static double calcDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Pow((secondPoint.PointX - firstPoint.PointX), 2) + Math.Pow((secondPoint.PointY - firstPoint.PointY), 2) + Math.Pow((secondPoint.PointZ - firstPoint.PointZ), 2);
            return Math.Sqrt(distance);
        }
    }
}
