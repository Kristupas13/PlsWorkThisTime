using PlsWorkThisTime.Models.TestWebService.Models;
using System.Collections.Generic;

namespace PlsWorkThisTime.Utilities
{
    public static class Data
    {
        public static List<Car> Cars = new List<Car>
        {
            new Car
            {
                Id = 0,
                Vin = "whd2",
                Make = "nissan",
                Model = "200sx",
                MovieDetails = new List<MovieDetails>
                {
                    new MovieDetails
                    {
                        Eidr = "101"
                    },
                    new MovieDetails
                    {
                        Eidr = "102"
                    }
                }
            },
            new Car
            {
                Id = 1,
                Vin = "whdd",
                Make = "mazda",
                Model = "mx-5",
                MovieDetails = new List<MovieDetails>
                {
                    new MovieDetails
                    {
                        Eidr = "102"
                    },
                    new MovieDetails
                    {
                        Eidr = "103"
                    },
                }
            },
        };
    }
}
