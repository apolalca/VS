using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UWPWheater.ent.Models
{
    public class LocationManager
    {
        //https://docs.microsoft.com/en-us/windows/uwp/maps-and-location/get-location

        public async static Task<Geoposition> GetPosition()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();

            if (accessStatus != GeolocationAccessStatus.Allowed)
                throw new Exception("Location failure");

            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };
            var position = await geolocator.GetGeopositionAsync();

            return position;
        }
    }
}
