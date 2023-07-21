using Computer_Store;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Services;

namespace ShopAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ArticleControler : ControllerBase
	{
		private readonly ArticleService _articleService;

		public ArticleControler(ArticleService articleService)
		{
			_articleService = articleService;
		}
		[HttpGet("GetArcticles")]
		public async Task<List<Article>> GetArticlesASync()
		{
			var articles = await _articleService.GetAsync();
			return articles;
		}
		[HttpPost("AddActicles")]
		public async Task<Article> AddArticleAsync(Article article)
		{
			await _articleService.CreateAsync(article);
			return article;
		}

	}

}
