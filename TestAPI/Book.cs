using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TestAPI
{
	public class Book
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }
		public string? Title { get; set; }

		[BsonElement("Name")]
		public string? BookName { get; set; }

		public decimal Price { get; set; }

		public string? Category { get; set; }

		public string? Author { get; set; }
	}
}
