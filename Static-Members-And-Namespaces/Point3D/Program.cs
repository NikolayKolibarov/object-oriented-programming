using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = Point3D.StartingPoint;
            Console.WriteLine("Before: {0}", point);
            point = new Point3D(20, 30, -5);
            Console.WriteLine("After: {0}", point);
            string fax = Console.ReadLine();
            Console.WriteLine("{0}", fax == "" ? "No fax" : fax);
        }
    }
}
