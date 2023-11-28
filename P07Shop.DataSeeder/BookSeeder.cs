using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;
using P06Shop.Shared;
using P07Shop.DataSeeder;
using Bogus;

namespace P07Shop.DataSeeder
{
    public class BookSeeder
    {
        public static List<Book> GenerateBookData()
        {
            int productId = 1;
            var bookFaker = new Faker<Book>()
                .UseSeed(123456)
                .RuleFor(x => x.Title, x => x.Commerce.ProductName())
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x => x.Pages, x => x.Random.Int(1, 1000))
                .RuleFor(x => x.Id, x => productId++)
                .RuleFor(x => x.ReleaseDate, x => x.Date.Past());

            return bookFaker.Generate(50).ToList();
        }

        public static Book GenerateOneBookData()
        {
            Random r = new Random();
            var bookFaker = new Faker<Book>()
                .UseSeed(123456)
                .RuleFor(x => x.Title, x => x.Commerce.ProductName())
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x => x.Pages, x => x.Random.Int(1, 1000))
                .RuleFor(x => x.Id, x => 0)
                .RuleFor(x => x.ReleaseDate, x => x.Date.Past());

            return bookFaker.Generate(1)[0];
        }
    }
}