using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_GalacticGPS
{
    public struct Location
    {
        private double longitude;
        private double latitude;
        private Planets planet;

        public Location(double longitude, double latitude, Planets planet)
            : this()
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude measurements range from -180 to 180 degrees");
                }
                this.longitude = value;
            }
        }
        public double Latitude 
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude measurements range from to -90 to 90 degrees");
                }
                this.latitude = value;
            }
        }

        public Planets Planet 
        {
            get
            {
                return this.planet;
            }
            set
            {
                this.planet = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
