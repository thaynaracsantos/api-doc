using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.ModelExamples
{
    public class HouseGetExamples : IExamplesProvider
    {
        public object GetExamples()
        {
            HouseGetExample houseGetExample = new HouseGetExample();

            return new List<House>()
            {
                houseGetExample.GetExamples() as House,
                houseGetExample.GetExamples() as House
            };
        }
    }
}
