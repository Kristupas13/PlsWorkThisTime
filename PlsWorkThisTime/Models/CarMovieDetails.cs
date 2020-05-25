namespace PlsWorkThisTime.Models
{
    using System.Collections.Generic;

    namespace TestWebService.Models
    {
        public class Car
        {
            public int Id { get; set; }
            public string Vin { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public List<MovieDetails> MovieDetails { get; set; }
        }

        public class MovieDetails
        {
            public string Title { get; set; }
            public string Eidr { get; set; }
            public string Year { get; set; }
            public string Director { get; set; }
        }

        public class MovieDetailsList
        {
            public List<MovieDetails> List { get; set; }
        }
    }

}
