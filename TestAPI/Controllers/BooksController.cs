using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace TestAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BooksController : ControllerBase
	{
		private readonly IMongoCollection<Book> _booksCollection;

		public BooksController(IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
		{
			var mongoClient = new MongoClient(
				bookStoreDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				bookStoreDatabaseSettings.Value.DatabaseName);

			_booksCollection = mongoDatabase.GetCollection<Book>(
				bookStoreDatabaseSettings.Value.BooksCollectionName);
		}

		[HttpPost(Name = "AddBook")]
		public void Add(Book book)
		{
			_booksCollection.InsertOne(book);
		}

		[HttpGet(Name = "ListAll")]
		public List<Book> GetBooks()
		{
			var books = _booksCollection.Find<Book>(x => true);
			return books.ToList();
		}
		[HttpDelete(Name = "Delete")]
		public void DeleteBook(string id)
		{
			_booksCollection.DeleteOne<Book>(x => x.Id == id);
		}
	}
}
