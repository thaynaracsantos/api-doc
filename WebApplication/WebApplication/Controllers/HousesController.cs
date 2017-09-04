using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Examples;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Net;
using WebApplication.ModelExamples;
using WebApplication.Models;
using WebApplication.Swagger;

namespace WebApplication.Controllers
{
    /// <summary>
    /// Control all house actions
    /// </summary>
    [Route("api/[controller]")]
    public class HousesController : Controller
    {
        /// <summary>
        /// List all houses
        /// </summary>
        /// <returns>Collection of houses</returns>
        /// <response code="200">Collection of houses</response> 
        [HttpGet]        
        [Produces("application/json", Type = typeof(IEnumerable<House>))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<House>))]        
        public IEnumerable<House> Get()
        {
            return new House[] { new House { Id = 1, Color = "Blue", Address = "Street 1", NumberOfWindows = 2 } };
        }

        /// <summary>
        /// Get a house
        /// </summary>
        /// <param name="id">House identifier</param>
        /// <returns>House</returns>
        /// <response code="200">The house for the <paramref name="id"/>.</response>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(House))]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(House))]
        public House Get(int id)
        {
            return new House {Id = id, Color = "Pink", Address = "Street 2", NumberOfWindows = 5 };
        }

        /// <summary>
        /// Create a house
        /// </summary>
        /// <param name="house"></param>
        /// <response code="200">House created</response>
        [HttpPost]
        [SwaggerRequestExample(typeof(HouseCreate), typeof(HouseCreateExample))]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        public void Post([FromBody]HouseCreate house)
        {
            //Add House
        }

        /// <summary>
        /// Update a house
        /// </summary>
        /// <param name="id">House identifier</param>
        /// <param name="house">House parameters</param>
        /// <response code="200">House updated</response>
        [HttpPut("{id}")]
        [SwaggerRequestExample(typeof(HouseUpdate), typeof(HouseUpdateExample))]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        public void Put(int id, [FromBody]HouseUpdate house)
        {
            //Update House
        }

        /// <summary>
        /// Delete a house
        /// </summary>
        /// <param name="id">House identifier</param>
        /// <response code="200">House deleted</response>
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [HideInDocsAttribute]
        public void Delete(int id)
        {
            //Delete House
        }
    }
}
