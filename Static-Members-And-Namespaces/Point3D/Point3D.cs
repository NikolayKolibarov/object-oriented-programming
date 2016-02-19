using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3D
    {
        private double pointX;
        private double pointY;
        private double pointZ;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public static Point3D StartingPoint
        {
            get
            {
                return startingPoint;
            }
        }



        public Point3D(double pointX, double pointY, double pointZ)
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }

        public double PointX { get; set; }

        public double PointY { get; set; }

        public double PointZ { get; set; }

        public override string ToString()
        {
            return String.Format("X: {0}\nY: {1}\nZ: {2}", this.PointX, this.PointY, this.PointZ);
        }
    }
}
