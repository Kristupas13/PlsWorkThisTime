using PlsWorkThisTime.Models.TestWebService.Models;
using System.Collections.Generic;

namespace PlsWorkThisTime.Models
{
    public class CreateCarModel
    {
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public List<MovieDetails> MovieDetails { get; set; }
    }
}
