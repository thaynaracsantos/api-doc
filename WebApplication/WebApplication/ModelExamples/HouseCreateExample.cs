using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ModelExamples
{
    public class HouseCreateExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new HouseCreate
            {
                Color = "Yellow",
                Address = "Street 3",
                NumberOfWindows = 4
            };
        }
    }
}
