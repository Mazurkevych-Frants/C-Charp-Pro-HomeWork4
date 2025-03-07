using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Charp_Pro_HomeWork4_2
{
    internal class City
    {
        public string nameCity { get; set; }
        public int population { get; set; }
        public City(string nameCity, int population)
        {
            this.nameCity = nameCity;
            this.population = population;
        }

        public static City operator +(City a, int b)
        {
            return new City(a.nameCity, a.population + b);
        }

        public static City operator -(City a, int b)
        {
            return new City(a.nameCity, a.population - b);
        }

        public static bool operator ==(City population1, City population2)
        {
            return population1 == population2;
        }

        public static bool operator !=(City population1, City population2)
        {
            return population1 != population2;
        }

        public static bool operator >(City population1, City population2)
        {
            return population1 > population2;
        }

        public static bool operator <(City population1, City population2)
        {
            return population1 < population2;
        }
    }
}
