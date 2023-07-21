using Computer_Store;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShopAPI.Models;

namespace ShopAPI.Services
{
	public class ArticleService
	{
		private readonly IMongoCollection<Article> _articleCollection;

		public ArticleService(
			IOptions<WebStoreDatabaseSettings> articleStoreDatabaseSettings)
		{
			var mongoClient = new MongoClient(
				articleStoreDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				articleStoreDatabaseSettings.Value.DatabaseName);

			_articleCollection = mongoDatabase.GetCollection<Article>(
				articleStoreDatabaseSettings.Value.ArticlesCollectionName);
		}

		public async Task<List<Article>> GetAsync() =>
			await _articleCollection.Find(_ => true).ToListAsync();

		public async Task<Article?> GetAsync(string id) =>
			await _articleCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

		public async Task CreateAsync(Article newStore) =>
			await _articleCollection.InsertOneAsync(newStore);

		public async Task UpdateAsync(string id, Article updatedStore) =>
			await _articleCollection.ReplaceOneAsync(x => x.Id == id, updatedStore);

		public async Task RemoveAsync(string id) =>
			await _articleCollection.DeleteOneAsync(x => x.Id == id);
	}
}
