using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;
using _02_DistanceCalculator;

namespace _3_Paths
{
    class Path3D
    {
        private readonly double distance;
        private List<Point3D> pointsList;

        public Path3D(List<Point3D> pointsList)
        {
            this.pointsList = pointsList;
            this.Distance = CalculateDistance(this.pointsList);
        }

        public double Distance { get; set; }
        //public List<Point3D> PointsList { get; set; }

        private double CalculateDistance(List<Point3D> point3D) 
        {
            double d = 0;
            for (int i = 0; i < point3D.Count - 1; i++)
            {
                d += DistanceCalculator.calcDistance(point3D[i], point3D[i + 1]);
            }

            return d;
        }

        public override string ToString()
        {
            string path = "";

            for (int i = 0; i < pointsList.Count; i++)
            {
                path += "Point " + (i + 1) + "coordintes: " + pointsList[i].PointX + ", " + pointsList[i].PointY + ", " + pointsList[i].PointZ + "\n";
            }
            path += "Distance between pointsList: " + this.Distance + "\n";

            return path;
        }
    }
}
