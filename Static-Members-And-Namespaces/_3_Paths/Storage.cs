using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _01_Point3D;

namespace _3_Paths
{
    class Storage
    {
        public static void SavePath(string fileName, params Path3D[] paths)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(fileName, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                using (streamWriter)
                {
                    foreach (Path3D path in paths)
                    {
                        streamWriter.Write(path);
                    }
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }

        public static Path3D LoadPath(string fileName)
        {
            List<Point3D>  points = new List<Point3D>();
            Path3D path;

            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    String line = streamReader.ReadLine();
                    while (line != null)
                    {
                        double[] coordinates = PointExtractor(line);
                        Point3D point = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                        points.Add(point);
                        line = streamReader.ReadLine();
                    }
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            
            path = new Path3D(points);
            return path;
        }

        private static double[] PointExtractor(string line)
        {
            double[] pointCoordinates = new double[3];
            string[] data = line.Split(',');

            for (int i = 0; i < data.Length; i++)
            {
                pointCoordinates[i] = double.Parse(data[i]);
            }

            return pointCoordinates;
        }

    }
}
