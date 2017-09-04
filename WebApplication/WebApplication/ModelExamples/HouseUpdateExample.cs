using Swashbuckle.AspNetCore.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ModelExamples
{
    public class HouseUpdateExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new HouseUpdate
            {
                Color = "Yellow",
                NumberOfWindows = 4
            };
        }
    }
}
