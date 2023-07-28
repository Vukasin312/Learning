using Computer_Store;

namespace ShopAPI.Services
{
	public interface IStorageService
	{
		Task<Storage> GetStorageAsync(string id);
		Task<Storage> AddStorageAsync(Storage storage);
		Task<Storage> DeleteStorageAsync(Storage storage);
		Task<Storage> UpdateStorageAsync(Storage storage);
	}
	public class StorageService : IStorageService
	{
		private readonly StorageDBService _storageDBService;

		public StorageService(StorageDBService storageDBService)
		{
			_storageDBService = storageDBService;
		}

		public async Task<Storage> GetStorageAsync(string id)
		{
			var Storage = await _storageDBService.GetAsync(id);
			return Storage;
		}
		public async Task<Storage> AddStorageAsync(Storage storage)
		{
			await _storageDBService.CreateAsync(storage);
			return storage;
		}
		public async Task<Storage> UpdateStorageAsync(Storage storage)
		{
			var articleFromDB = await _storageDBService.GetAsync(storage.Id);
			if (articleFromDB == null) throw new Exception("Storage not found");
			await _storageDBService.UpdateAsync(storage.Id, storage);
			return storage;
		}
		public async Task<Storage> DeleteStorageAsync(Storage storage)
		{
			var articleFromDB = await _storageDBService.GetAsync(storage.Id);
			if (articleFromDB == null) throw new Exception("Storage not found");
			await _storageDBService.RemoveAsync(storage.Id);
			return storage;
		}
	}
}
