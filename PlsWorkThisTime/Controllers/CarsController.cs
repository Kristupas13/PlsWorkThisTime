using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlsWorkThisTime.Models;
using PlsWorkThisTime.Models.TestWebService.Models;
using PlsWorkThisTime.Utilities;

namespace PlsWorkThisTime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public List<Car> Get()
        {
            return Data.Cars;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Car foundCar = null;

            foreach (var car in Data.Cars)
            {
                if (car.Id == id)
                    foundCar = car;
            }

            if (foundCar == null)
                return NotFound();


            HttpClient client = new HttpClient();
            var response = await client.GetAsync("danikoAdresas");

            var rootMovieDetailsList = JsonConvert.DeserializeObject<MovieDetailsList>(await response.Content.ReadAsStringAsync());
            var listInside = rootMovieDetailsList.List;

            foundCar.MovieDetails = listInside;

            return Ok(foundCar);
        }

        [HttpPost]
        public IActionResult Create(CreateCarModel carModel)
        {
            var carToAdd = new Car
            {
                Id = 5,
                Make = carModel.Make,
                Model = carModel.Model,
                MovieDetails = carModel.MovieDetails,
                Vin = carModel.Vin
            };

            Data.Cars.Add(carToAdd);

            return Created("asdasdasdasd", carToAdd);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var existingCar = Data.Cars.SingleOrDefault(p => p.Id == id);
            if (existingCar == null)
                return NotFound("Car not found");

            Data.Cars.Remove(existingCar);
            return Ok();
        }
    }
}
