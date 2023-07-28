using Computer_Store;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Services;

namespace ShopAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StorageControler : ControllerBase
	{
		private readonly StorageDBService _storageDBService;
		private readonly IStorageService _storageService;
		public StorageControler(StorageDBService storageDBService, IStorageService storageService)
		{
			_storageDBService = storageDBService;
			_storageService = storageService;
		}
		[HttpGet("GetStorage")]
		public async Task<List<Storage>> GetStorageASync()
		{
			var articles = await _storageDBService.GetAsync();
			return articles;
		}
		[HttpGet("GetStorage")]
		public async Task<Storage> GetStorageAsync(string Id)
		{
			var article = await _storageService.GetStorageAsync(Id);
			return article;
		}
		[HttpPost("AddStorage")]
		public async Task<Storage> AddStorageAsync(Storage storage)
		{
			await _storageService.AddStorageAsync(storage);
			return storage;
		}
		[HttpPut("UpdateStorage")]
		public async Task<Storage> UpdateStorageAsync(Storage storage)
		{
			await _storageService.UpdateStorageAsync(storage);
			return storage;
		}
		[HttpDelete("DeleteStorage")]
		public async Task<Storage> DeleteStorageAsync(Storage storage)
		{
			await _storageService.DeleteStorageAsync(storage);
			return storage;
		}
	}
}
