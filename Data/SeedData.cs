using System.Collections.Generic;
using CityProv.Models;
using Microsoft.EntityFrameworkCore;

public static class SeedData {

    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

        public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceCode = "1",
                ProvinceName = "British Columbia"
            },
            new Province() {
                ProvinceCode = "2",
                ProvinceName = "Ontario"
            },
            new Province() {
                ProvinceCode = "3",
                ProvinceName = "Alberta"
            },
        };

        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 10,
                CityName = "Vancouver",
                Population = 500000,
                MyProvince = "British Columbia"
            },
            new City {
                CityId = 11,
                CityName = "Victoria",
                Population = 200000,
                MyProvince = "British Columbia"
            },
            new City {
                CityId = 12,
                CityName = "Kelowna",
                Population = 100000,
                MyProvince = "British Columbia"
            },
             new City {
                CityId = 21,
                CityName = "Toronto",
                Population = 800000,
                MyProvince = "Ontario"
            },
            new City {
                CityId = 22,
                CityName = "Waterloo",
                Population = 100000,
                MyProvince = "Ontario"
            },
            new City {
                CityId = 23,
                CityName = "Kingston",
                Population = 200000,
                MyProvince = "Ontario"
            },
             new City {
                CityId = 31,
                CityName = "Calgary",
                Population = 400000,
                MyProvince = "Alberta"
            },
            new City {
                CityId = 32,
                CityName = "Edmonton",
                Population = 400000,
                MyProvince = "Alberta"
            },
            new City {
                CityId = 33,
                CityName = "Lethbridge",
                Population = 100000,
                MyProvince = "Alberta"
            }, 
        };

        return cities;
    }

}
