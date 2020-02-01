using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingViewComponents.Models
{
    public interface ICityRepository 
    {
        IEnumerable<City> Cities { get; }
        void AddCity(City city);
    }
    public class CityRepository:ICityRepository
    {
        private List<City> cities = new List<City>
        {
            new City{Name="London", Country="United Kingdom", Population=8539000},
            new City{Name="New York", Country="Pindosi", Population=8405000},
            new City{Name="San Francisco", Country="Pindosi", Population=998537},
            new City{Name="Moskow", Country="Great Russia", Population=7000000}
        };
        public IEnumerable<City> Cities => cities;
        public void AddCity(City city)
        {
            cities.Add(city);
        }
    }
}
