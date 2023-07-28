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
		private readonly StoreDBService _storeDBService;
		private readonly IStoreService _storeService;

        public StoreControler(StoreDBService storeDBService, IStoreService storeService)
        {
			_storeService = storeService;
            _storeDBService = storeDBService;
        }
        [HttpGet("GetStores")]
		public async Task<List<Store>> GetStoresAsync() 
		{
			var stores = await _storeDBService.GetAsync();			
			return stores;
		}
		[HttpGet("GetStore")]
		public async Task<Store> GetStoreAsync(string Id)
		{
			var store = await _storeService.GetStoreAsync(Id);			
			return store;
		}
		[HttpPost("AddStore")]
		public async Task<Store> AddStoreAsync(Store store)
		{
			await _storeService.AddStoreAsync(store);
			return store;
		}
		[HttpPut("UpdateStore")]
		public async Task<Store> UpdateStoreAsync(Store store)
		{
			await _storeService.UpdateStoreAsync(store);
			return store;
		}
		[HttpDelete("DeleteStore")]
		public async Task<Store> DeleteStoreAsync(Store store)
		{
			await _storeService.DeleteStoreAsync(store);
			return store;
		}		
	}
}
