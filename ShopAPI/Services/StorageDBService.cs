using Computer_Store;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShopAPI.Models;

namespace ShopAPI.Services
{
	public class StorageDBService
	{
		private readonly IMongoCollection<Storage> _storageCollection;

		public StorageDBService(
			IOptions<WebStoreDatabaseSettings> storageStoreDatabaseSettings)
		{
			var mongoClient = new MongoClient(
				storageStoreDatabaseSettings.Value.ConnectionString);

			var mongoDatabase = mongoClient.GetDatabase(
				storageStoreDatabaseSettings.Value.DatabaseName);

			_storageCollection = mongoDatabase.GetCollection<Storage>(
				storageStoreDatabaseSettings.Value.StoragesCollectionName);
		}

		public async Task<List<Storage>> GetAsync() =>
			await _storageCollection.Find(_ => true).ToListAsync();

		public async Task<Storage?> GetAsync(string id) =>
			await _storageCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

		public async Task CreateAsync(Storage newStorage) =>
			await _storageCollection.InsertOneAsync(newStorage);

		public async Task UpdateAsync(string id, Storage updatedStorage) =>
			await _storageCollection.ReplaceOneAsync(x => x.Id == id, updatedStorage);

		public async Task RemoveAsync(string id) =>
			await _storageCollection.DeleteOneAsync(x => x.Id == id);
	}
}

