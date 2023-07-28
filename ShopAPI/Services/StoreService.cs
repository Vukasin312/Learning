using Computer_Store;

namespace ShopAPI.Services
{
	public interface IStoreService
	{
		Task<Store> GetStoreAsync(string Id);
		Task<Store> AddStoreAsync(Store store);
		Task<Store> UpdateStoreAsync(Store store);
		Task<Store> DeleteStoreAsync(Store store);
	}
	public class StoreService : IStoreService
	{
		private readonly StoreDBService _storeDBService;

		public StoreService(StoreDBService storeDBService)
		{
			_storeDBService = storeDBService;
		}		
		public async Task<Store> GetStoreAsync(string id)
		{
			var store = await _storeDBService.GetAsync(id);
			return store;
		}
		public async Task<Store> AddStoreAsync(Store store)
		{
			await _storeDBService.CreateAsync(store);
			return store;
		}
		public async Task<Store> UpdateStoreAsync(Store store)
		{
			var storeFromDB = await _storeDBService.GetAsync(store.Id);
			if (storeFromDB == null) throw new Exception("Store not found");
			await _storeDBService.UpdateAsync(store.Id, store);
			return store;
		}
		public async Task<Store> DeleteStoreAsync(Store store)
		{
			var storeFromDB = await _storeDBService.GetAsync(store.Id);
			if (storeFromDB == null) throw new Exception("Store not found");
			await _storeDBService.RemoveAsync(store.Id);
			return store;
		}
	}
}
