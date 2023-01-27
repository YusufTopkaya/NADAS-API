using Microsoft.AspNetCore.Mvc;
using Nadas.API.Business.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Blog());
        }

        [HttpPost]
        public async Task<IActionResult> Index(Blog blog)
        {
                await _blogService.AddAsync(blog);
            ModelState.Clear();
            return View(new Blog());
        }
    }
}
