using Swashbuckle.AspNetCore.Examples;
using WebApplication.Models;
using Bogus;

namespace WebApplication.ModelExamples
{
    public class HouseCreateExample : IExamplesProvider
    {
        public object GetExamples()
        {
            HouseCreate house = new Faker<HouseCreate>()
            .RuleFor(h => h.Color, fh => fh.Commerce.Color())
            .RuleFor(h => h.Address, fh => fh.Address.StreetAddress(true))
            .RuleFor(h => h.NumberOfWindows, fh => fh.Random.Int(0, 10));

            return house;
        }
    }
}
