using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class HousesController : Controller
    {
        // GET api/houses
        [HttpGet]
        public IEnumerable<House> Get()
        {
            return new House[] { new House { Id = 1, Color = "Blue", Address = "Street 1", NumberOfWindows = 2 } };
        }

        // GET api/houses/5
        [HttpGet("{id}")]
        public House Get(int id)
        {
            return new House {Id = id, Color = "Pink", Address = "Street 2", NumberOfWindows = 5 };
        }

        // POST api/houses
        [HttpPost]
        public void Post([FromBody]House house)
        {
            //Add House
        }

        // PUT api/houses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]House value)
        {
            //Update House
        }

        // DELETE api/houses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Delete House
        }
    }
}
