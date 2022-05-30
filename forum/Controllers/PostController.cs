using forum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace forum.Controllers
{
    public class PostController : Controller
    {
        ForumContext forumContext;
        public PostController(ForumContext forumContext)
        {
            this.forumContext = forumContext;
        }

        public IActionResult Index(int? id)
        {
            Post content = new Post();
            try
            {
                content = forumContext.Posts.Where(p => p.Id == id).First();
            } catch
            {
                return Redirect("/");
            }

            return View(content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
