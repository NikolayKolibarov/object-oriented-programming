using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planets.Earth);
            Console.WriteLine(home);
        }
    }
}
