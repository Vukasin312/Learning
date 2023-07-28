using Computer_Store;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShopAPI.Models;

namespace ShopAPI.Services
{
	public class StoreDBService
	{
		private readonly IMongoCollection<Store> _storeCollection;		

		public StoreDBService(
			IOptions<WebStoreDatabaseSettings> storeStoreDatabaseSettings)
		{
			var mongoClient = new MongoClient(
				storeStoreDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				storeStoreDatabaseSettings.Value.DatabaseName);

			_storeCollection = mongoDatabase.GetCollection<Store>(
				storeStoreDatabaseSettings.Value.StoresCollectionName);
		}

		public async Task<List<Store>> GetAsync() =>
			await _storeCollection.Find(_ => true).ToListAsync();

		public async Task<Store?> GetAsync(string id) =>
			await _storeCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

		public async Task CreateAsync(Store newStore) =>
			await _storeCollection.InsertOneAsync(newStore);

		public async Task UpdateAsync(string id, Store updatedStore) =>
			await _storeCollection.ReplaceOneAsync(x => x.Id == id, updatedStore);

		public async Task RemoveAsync(string id) =>
			await _storeCollection.DeleteOneAsync(x => x.Id == id);		
	}
}
