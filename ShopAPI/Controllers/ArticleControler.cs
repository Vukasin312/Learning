using Computer_Store;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Services;

namespace ShopAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArticleControler : ControllerBase
	{
		private readonly ArticleDBService _articleDBService;
		private readonly IArticleService _articleService;
		public ArticleControler(ArticleDBService articleDBService, IArticleService articleService)
		{
			_articleDBService = articleDBService;
			_articleService = articleService;
		}
		[HttpGet("GetArcticles")]
		public async Task<List<Article>> GetArticlesASync()
		{
			var articles = await _articleDBService.GetAsync();
			return articles;
		}
		[HttpGet("GetArticle")]
		public async Task<Article> GetArticleAsync(string Id)
		{
			var article = await _articleService.GetArticleAsync(Id);
			return article;
		}
		[HttpPost("AddActicles")]
		public async Task<Article> AddArticleAsync(Article article)
		{
			await _articleService.AddArticleAsync(article);
			return article;
		}
		[HttpPut("UpdateArticle")]
		public async Task<Article> UpdateArticleAsync(Article article)
		{
			await _articleService.UpdateArticleAsync(article);
			return article;
		}
		[HttpDelete("DeleteArticle")]
		public async Task<Article> DeleteArticleAsync(Article article)
		{
			await _articleService.DeleteArticleAsync(article);
			return article;
		}
	}
}
