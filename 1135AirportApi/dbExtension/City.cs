using ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1135AirportApi.db
{
    public partial class City
    {
        public static explicit operator CityApi(City city)
        {
            if (city == null)
                return null;
            return new CityApi
            {
                Id = city.Id,
                Title = city.Title,
                UtcAdd = city.UtcAdd,
            };
        }
        public static explicit operator City(CityApi city)
        {
            if (city == null)
                return null;
            return new City
            {
                Id = city.Id,
                Title = city.Title,
                UtcAdd = city.UtcAdd
            };
        }
    }

    public partial class Airport
    {
        public static explicit operator AirportApi(Airport port)
        {
            if (port == null)
                return null;
            return new AirportApi
            {
                Id = port.Id,
                Title = port.Title,
            };
        }
        public static explicit operator Airport(AirportApi port)
        {
            if (port == null)
                return null;
            return new Airport
            {
                Id = port.Id,
                Title = port.Title,
            };
        }
    }
}
