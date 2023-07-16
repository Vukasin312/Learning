using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace TestAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;
		private readonly IMongoCollection<Book> _booksCollection;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
		{
			_logger = logger;

			var mongoClient = new MongoClient(
			bookStoreDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				bookStoreDatabaseSettings.Value.DatabaseName);

			_booksCollection = mongoDatabase.GetCollection<Book>(
				bookStoreDatabaseSettings.Value.BooksCollectionName);
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		[HttpGet("{id}", Name = "Test")]
		public ActionResult<string> GetSummary(int id)
		{
			return Summaries[id];
		}

	}
}