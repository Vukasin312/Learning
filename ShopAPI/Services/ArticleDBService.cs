﻿using Computer_Store;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ShopAPI.Models;

namespace ShopAPI.Services
{
	public class ArticleDBService
	{
		private readonly IMongoCollection<Article> _articleCollection;

		public ArticleDBService(
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

		public async Task CreateAsync(Article newArticle) =>
			await _articleCollection.InsertOneAsync(newArticle);

		public async Task UpdateAsync(string id, Article updatedArticle) =>
			await _articleCollection.ReplaceOneAsync(x => x.Id == id, updatedArticle);

		public async Task RemoveAsync(string id) =>
			await _articleCollection.DeleteOneAsync(x => x.Id == id);
	}
}
