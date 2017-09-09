using Bogus;
using Swashbuckle.AspNetCore.Examples;
using WebApplication.Models;

namespace WebApplication.ModelExamples
{
    public class HouseGetExample : IExamplesProvider
    {
        public object GetExamples()
        {
            House house = new Faker<House>()
            .RuleFor(h => h.Id, fh => fh.Random.Int(1,100))
            .RuleFor(h => h.Color, fh => fh.Commerce.Color())
            .RuleFor(h => h.Address, fh => fh.Address.StreetAddress(true))
            .RuleFor(h => h.NumberOfWindows, fh => fh.Random.Int(0, 10));

            return house;
        }
    }
}
