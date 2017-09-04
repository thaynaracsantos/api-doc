using Swashbuckle.AspNetCore.Examples;
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
