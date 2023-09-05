using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using System;
using System.Text.Json.Nodes;

using TestApplication.API.Models;

namespace TestApplication.API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data\\rawData.json");
        


        [HttpGet("GetStatus/{id}")]
        public async Task<IActionResult> GetStatus(string id)
        {
            try
            {
                string jsonContent = string.Empty;
                jsonContent = System.IO.File.ReadAllText(jsonFilePath);
                Flight? flight = JsonConvert.DeserializeObject<Flight>(jsonContent);
                var flightstatus = flight?.DFWGateLoungeFlightList.FindLast(x => x.aircraftregnumber == id);
                return Ok(flightstatus?.remarks);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpGet("GetActive")]
        public async Task<IActionResult> GetActive()
        {
            try
            {
                string jsonContent = string.Empty;
                jsonContent = System.IO.File.ReadAllText(jsonFilePath);
                Flight? flight = JsonConvert.DeserializeObject<Flight>(jsonContent);
                var active = flight?.DFWGateLoungeFlightList.DistinctBy(x => x.aircraftregnumber).ToList();
                return Ok(active);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetDelayedFlights")]
        public async Task<IActionResult> GetDelayedFlights()
        {
            try
            {
                string jsonContent = string.Empty;
                jsonContent = System.IO.File.ReadAllText(jsonFilePath);
                Flight? flight = JsonConvert.DeserializeObject<Flight>(jsonContent);
                var delayed = flight?.DFWGateLoungeFlightList.FindAll(x => x.remarks != "On Time" && x.airline_name == "DELTA");
                return Ok(delayed);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
