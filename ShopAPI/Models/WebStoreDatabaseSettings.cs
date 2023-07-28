namespace ShopAPI.Models
{
	public class WebStoreDatabaseSettings
	{
		public string ConnectionString { get; set; } = null!;

		public string DatabaseName { get; set; } = null!;

		public string StoresCollectionName { get; set; } = null!;
		public string ArticlesCollectionName { get; set; } = null!;
		public string StoragesCollectionName { get; set; } = null!;
	}
}
