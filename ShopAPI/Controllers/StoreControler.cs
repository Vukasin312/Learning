using Computer_Store;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Services;

namespace ShopAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StoreControler : ControllerBase
	{
		private readonly StoreService _storeService;
        public StoreControler(StoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpGet("GetStores")]
		public async Task<List<Store>> GetStoresAsync() 
		{
			var stores = await _storeService.GetAsync();
			return stores;
		}
		[HttpGet("GetStore")]
		public async Task<Store> GetStoreAsync(Store store)
		{
			await _storeService.GetAsync();
			return store;
		}
		[HttpPost("AddStore")]
		public async Task<Store> AddStoreAsync(Store store)
		{
			await _storeService.CreateAsync(store);
			return store;
		}
		[HttpPut("UpdateStore")]
		public async Task<Store> UpdateStore(Store store)
		{
			var storeFromDB = await _storeService.GetAsync(store.Id);
			if (storeFromDB == null)  throw new Exception("Store not found");
			await _storeService.UpdateAsync(store.Id, store);
			return store;
		}
		[HttpDelete("DeleteStore")]
		public async Task<Store> DeleteStore(Store store)
		{
			var storeFromDB = await _storeService.GetAsync(store.Id);
			if (storeFromDB == null) throw new Exception("Store not found");
			await _storeService.RemoveAsync(store.Id);
			return store;
		}
		// Dodaj GetStore i DeleteStore
		// Napravi isto za Artikli i Storage
	}
}
