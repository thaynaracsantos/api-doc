using Swashbuckle.AspNetCore.Examples;
using WebApplication.Models;
using Bogus;

namespace WebApplication.ModelExamples
{
    public class HouseUpdateExample : IExamplesProvider
    {
        public object GetExamples()
        {
            HouseUpdate house = new Faker<HouseUpdate>()
            .RuleFor(h => h.Color, fh => fh.Commerce.Color())
            .RuleFor(h => h.NumberOfWindows, fh => fh.Random.Int(0, 10));

            return house;
        }
    }
}
