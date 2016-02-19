using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _3_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Point3D secondPoint = new Point3D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Point3D thirdPoint = new Point3D(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            List<Point3D> firstPointList = new List<Point3D>{firstPoint, secondPoint, thirdPoint};
            List<Point3D> secondPointList = new List<Point3D>{secondPoint, thirdPoint};
            List<Point3D> thridPointList = new List<Point3D> {firstPoint, thirdPoint};

            Path3D firstPath = new Path3D(firstPointList);
            Path3D secondPath = new Path3D(secondPointList);
            Path3D thirdPath = new Path3D(thridPointList);

            Storage.SavePath(@"C:\Users\Nikolay\Documents\Visual Studio 2013\Projects\StaticMembersAndNamespaces\_3_Paths\newSample");
            Path3D newPath = Storage.LoadPath(@"../../loadSample.txt");
            Storage.SavePath(@"C:\Users\Nikolay\Documents\Visual Studio 2013\Projects\StaticMembersAndNamespaces\_3_Paths\newSample");

            Console.WriteLine(newPath);
        }
    }
}
