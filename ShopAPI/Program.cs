
using ShopAPI.Models;
using ShopAPI.Services;

namespace ShopAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.Configure<WebStoreDatabaseSettings>(
				builder.Configuration.GetSection("WebStore"));

			builder.Services.AddSingleton<StoreDBService>();
			builder.Services.AddSingleton<ArticleDBService>();
			builder.Services.AddSingleton<StorageDBService>();
			builder.Services.AddSingleton<IArticleService, ArticleService>();
			builder.Services.AddSingleton<IStoreService, StoreService>();
			builder.Services.AddSingleton<IStorageService, StorageService>();

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();



			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();



			app.MapControllers();

			app.Run();
		}
	}
}