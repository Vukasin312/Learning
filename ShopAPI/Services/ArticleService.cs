using Computer_Store;

namespace ShopAPI.Services
{
	public interface IArticleService
	{		
		Task<Article> GetArticleAsync(string id);
		Task<Article> AddArticleAsync(Article article);
		Task<Article> DeleteArticleAsync(Article article);
		Task<Article> UpdateArticleAsync(Article article);
	}
	public class ArticleService : IArticleService
	{
		private readonly ArticleDBService _articleDBService;

		public ArticleService(ArticleDBService articleDBService)
		{
			_articleDBService = articleDBService;
		}

		public async Task<Article> GetArticleAsync(string id)
		{
			var article = await _articleDBService.GetAsync(id);
			return article;
		}
		public async Task<Article> AddArticleAsync(Article article)
		{
			await _articleDBService.CreateAsync(article);
			return article;
		}
		public async Task<Article> UpdateArticleAsync(Article article)
		{
			var articleFromDB = await _articleDBService.GetAsync(article.Id);
			if (articleFromDB == null) throw new Exception("Article not found");
			await _articleDBService.UpdateAsync(article.Id, article);
			return article;
		}
		public async Task<Article> DeleteArticleAsync(Article article)
		{
			var articleFromDB = await _articleDBService.GetAsync(article.Id);
			if (articleFromDB == null) throw new Exception("Article not found");
			await _articleDBService.RemoveAsync(article.Id);
			return article;
		}
	}
}
