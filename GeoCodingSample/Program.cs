using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geocoding;
using Geocoding.Google;

namespace GeoCodingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeocoder geocoder = new GoogleGeocoder(){ApiKey = "your_api_key" };
            IEnumerable<Address> addresses = geocoder.Geocode("tegucigalpa honduras");
            Console.WriteLine("Formatted: " + addresses.First().FormattedAddress); 
            Console.WriteLine("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude); 
        }
    }
}
